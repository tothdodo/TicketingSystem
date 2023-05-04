import { Component } from '@angular/core';
import { PlayerService } from 'src/app/api/services';
import { PlayerHeader } from 'src/app/api/models';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
  
@Component({
  selector: 'app-add-player',
  templateUrl: './add-player.component.html',
  styleUrls: ['./add-player.component.css']
})
export class AddPlayerComponent {
  numbers: number[] = Array.from({length: 100}, (_, i) => i);

  addPlayerForm!: FormGroup;

  minDate: Date;
  maxDate: Date;

  loading = false;
  success = false;

  selectedPictureFile!: File;
  pictureSrc?: string;

  constructor(private playerService: PlayerService, private fb: FormBuilder){
    const currentYear = new Date().getFullYear();
    this.minDate = new Date(currentYear - 60, 0, 1);
    this.maxDate = new Date(currentYear - 14, 11, 31);
  }

  ngOnInit() {
    this.addPlayerForm = this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      jerseyNumber: ['', [Validators.required, Validators.min(0), Validators.max(99)]],
      country: ['', Validators.required],
      bornDate: ['', Validators.required],
      weight: ['', [Validators.required, Validators.min(50), Validators.max(250)]],
      height: ['', [Validators.required, Validators.min(150), Validators.max(250)]],
      position: ['', Validators.required]
    });

    this.addPlayerForm.valueChanges.subscribe(console.log);
  }

  async submitHandler() {
    this.loading = true;

    let newPlayer: PlayerHeader = {
      firstName: this.addPlayerForm.get('firstName')?.value,
      lastName: this.addPlayerForm.get('lastName')?.value,
      jerseyNumber: this.addPlayerForm.get('jerseyNumber')?.value,
      nationality: this.addPlayerForm.get('country')?.value.name,
      birthDate: this.addPlayerForm.get('bornDate')?.value,
      weigth: this.addPlayerForm.get('weight')?.value,
      heigth: this.addPlayerForm.get('height')?.value,
      position: this.addPlayerForm.get('position')?.value,
      source: this.selectedPictureFile.name
    }

    this.playerService.apiPlayerPost$Json$Response({
        body: newPlayer
     }).subscribe(
       (response: StrictHttpResponse<PlayerHeader>) => {
         console.log(response);
         this.success = true;
       },
     (err) => {
      if(err.status == 409)
        alert("Player with this jersey number already exists!");
      else
       console.error(err);
     });
     this.loading = false;
  }

  requiredFileType( types: string[], fileName: string) : boolean{{
      if ( fileName ) {
        const extension = fileName.split('.')[1].toLowerCase();
        let supported: boolean = false;
        for(let type of types){
          if ( type.toLowerCase() === extension.toLowerCase() ) {
            supported = true;
          }
        }
        if(!supported){
          alert('Unsupported file format!');
          return false;
        }
        return true;
      }
      return true;
    };
  }

  showPreview(event: any) {
    console.log(event.target.files[0].name);
    this.selectedPictureFile = <File>event.target.files[0];
    if(!this.requiredFileType(['png', 'jpg'],event.target.files[0].name)){
      this.pictureSrc = undefined;
      return;
    }    

    const file = (event.target as HTMLInputElement)?.files?.[0];
    if (!file) return;
    
    // File Preview
    const reader = new FileReader();
    reader.onload = () => {
      this.pictureSrc = reader.result as string;
    }
    reader.readAsDataURL(file)
  }

  get firstName() { return this.addPlayerForm.get('firstName'); }

  get lastName() { return this.addPlayerForm.get('lastName'); }

  get jerseyNumber() { return this.addPlayerForm.get('jerseyNumber'); }

  get country() { return this.addPlayerForm.get('country'); }

  get bornDate() { return this.addPlayerForm.get('bornDate'); }

  get weight() { return this.addPlayerForm.get('weight'); }

  get height() { return this.addPlayerForm.get('height'); }

  get position() { return this.addPlayerForm.get('position'); }

  get image() { return this.addPlayerForm.get('image'); }
}
