import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { TeamHeader } from 'src/app/api/models';
import { TeamService } from 'src/app/api/services';

@Component({
  selector: 'app-add-new-team',
  templateUrl: './add-new-team.component.html',
  styleUrls: ['./add-new-team.component.css']
})
export class AddNewTeamComponent {
/**
 * Team props for the add team form
 */
  team: any = {
    name: '',
    homeCourt: '',
    logoUrl : ''
  };

  /**
   * File for the team logo
   */
  selectedPictureFile!: File;
  pictureSrc?: string;

  /**
   * 
   * @param dialogRef DI for the dialog reference 
   * @param data Data passed to the dialog
   * @param teamService DI for the team service 
   */
  constructor(
    public dialogRef: MatDialogRef<AddNewTeamComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private teamService: TeamService
  ) { }

  /**
   * Closes the dialog
   */
  onNoClick(): void {
    this.dialogRef.close();
  }

 /**
  * Creates a new team object and calls the team service to add it to the database
  */ 
  onAddClick(): void {
    console.log(this.team);
    const route = this.team.logoUrl;
    const cleanedRoute = route.replace(/^[\\/]+/, '');

    const routeSegments = cleanedRoute.split('\\');

    const filename = routeSegments[routeSegments.length - 1];

    console.log(filename);

    const newTeam : TeamHeader = {
      name: this.team.name,
      homeCourt: this.team.homeCourt,
      logoUrl: filename
    };

    this.teamService.apiTeamPost$Json$Response({ body: newTeam }).subscribe(
      (response) => {
        console.log(response);
        this.dialogRef.close(true);
      },
      (err) => {
        console.error(err);
        this.dialogRef.close(false)
      }
    );
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
   * Validates the file type
   * @param types Valid types
   * @param fileName Selected filename by the user
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
}
