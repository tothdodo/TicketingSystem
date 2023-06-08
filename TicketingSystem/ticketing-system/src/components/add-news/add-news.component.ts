import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateNews } from 'src/app/api/models';
import { NewsService } from 'src/app/api/services';

@Component({
  selector: 'app-add-news',
  templateUrl: './add-news.component.html',
  styleUrls: ['./add-news.component.css']
})
export class AddNewsComponent {
  /**
   * Form group for the add news form
   */
  addNewsForm!: FormGroup;

  /**
   * Publish time for the news
   */
  time = new Date().toLocaleString();

  /**
   * File for the news picture
   */
  pictureSrc?: string;
  selectedPictureFile!: File;

  /**
   * Loading and success flags
   */
  loading = false;
  success = false;

  /**
   * @param fb Form builder DI
   * @param newsService News service DI
   */
  constructor(
    private fb: FormBuilder,
    private newsService: NewsService) {
  }

  /**
   * Builds the form group and subscribes to its value changes
   */
  ngOnInit() {
    this.addNewsForm = this.fb.group({
      mainTitle: ['', Validators.required],
      subTitle: ['', Validators.required],
      detailsTitle: ['', [Validators.required]],
      content: ['', Validators.required]
    });

    this.addNewsForm.valueChanges.subscribe(console.log);
  }

  /**
   * Submits the form and calls the news service to add the news to the database
   */
  onSubmit() {
    this.loading = true;

    const now = new Date();
    const twoHoursLater = new Date(now.getTime() + 2 * 60 * 60 * 1000);

    let latestNews: CreateNews = {
      urlId: this.convertToUrlId(this.addNewsForm.get('mainTitle')?.value),
      mainTitle: this.addNewsForm.get('mainTitle')?.value,
      subTitle: this.addNewsForm.get('subTitle')?.value,
      detailsTitle: this.addNewsForm.get('detailsTitle')?.value,
      content: this.addNewsForm.get('content')?.value,
      publishDate: twoHoursLater,
      image: this.selectedPictureFile.name
    }
    this.newsService.apiNewsPost$Response({body: latestNews}).subscribe(
      res => {
        console.log(res);
        this.success = true;
      },
      err => {
        console.log(err);
        alert("Error happened!");
      }
    );
    this.loading = false;
  }

  /**
   * Converts a string to a urlId
   */
  convertToUrlId(str: string): string {
    // Replace any non-alphabetic characters with a space
    str = str.replace(/[^a-zA-Z]/g, ' ');
  
    // Convert to lowercase and replace spaces with hyphens
    str = str.toLowerCase().replace(/\s+/g, '-');
  
    // Remove any trailing hyphens
    str = str.replace(/^-+|-+$/g, '');

    // subjoin year-month-day to the end of the urlId
    // month has 05 if it is May, not 5
    const date = new Date();
    const year = date.getFullYear();
    const month = date.getMonth() + 1;
    const newDate = date.getDate();
    str = str + '-' + year + '-' + String(month).padStart(2, '0') + '-' + String(newDate).padStart(2, '0');
    return str;
  }

  /**
   * Shows the preview of the selected picture
   * @param event Event for the file input
   * @returns If the file is of the correct type
   */
  showPreview(event: any) {
    console.log(event.target.files[0].name);
      this.selectedPictureFile = <File>event.target.files[0];
      if (!this.requiredFileType(['png', 'jpg'], event.target.files[0].name)) {
        this.pictureSrc = undefined;
        return;
      }

      const file = (event.target as HTMLInputElement)?.files?.[0];
      if (!file) return;

      const reader = new FileReader();
      reader.onload = () => {
        this.pictureSrc = reader.result as string;
      }
      reader.readAsDataURL(file)
  }

  /**
   * Validates the filetype
   * @param types Valid types
   * @param fileName Chosen filename by the user
   * @returns Isvalid file type
   */
  requiredFileType(types: string[], fileName: string): boolean {
    {
      if (fileName) {
        const extension = fileName.split('.')[1].toLowerCase();
        let supported: boolean = false;
        for (let type of types) {
          if (type.toLowerCase() === extension.toLowerCase()) {
            supported = true;
          }
        }
        if (!supported) {
          alert('Unsupported file format!');
          return false;
        }
        return true;
      }
      return true;
    };
  }

  /**
   * Getters for the form controls
   */
  get mainTitle() { return this.addNewsForm.get('mainTitle'); }
  get subTitle() { return this.addNewsForm.get('subTitle'); }
  get detailsTitle() { return this.addNewsForm.get('detailsTitle'); }
  get content() { return this.addNewsForm.get('content'); }
  get date() { return this.addNewsForm.get('date'); }

}
