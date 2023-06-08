import { ChangeDetectorRef, Component } from '@angular/core';
import { TeamHeader } from 'src/app/api/models';
import { TeamService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';
import { AddNewTeamComponent } from '../add-new-team/add-new-team.component';
import { MatDialog } from '@angular/material/dialog';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-manage-teams',
  templateUrl: './manage-teams.component.html',
  styleUrls: ['./manage-teams.component.css']
})
export class ManageTeamsComponent {
  //teams: Observable<Array<TeamHeader>> = new Observable<Array<TeamHeader>>;
  /**
   * Collection of all the teams
   */
  teams: Array<TeamHeader> = new Array<TeamHeader>;

  /**
   * @param teamService DI for the team service
   * @param dialog DI for the dialog service
   * @param cdr DI for the change detector
   */
  constructor(
    private teamService: TeamService,
    private dialog: MatDialog,
    private cdr: ChangeDetectorRef) { }

  /**
   * Calls the setTeams method
  */
  ngOnInit() {
    this.setTeams();
  }

  /**
   * Opens add team dialog and after close refreshes the teams
   */
  openAddTeamDialog(): void {
    const dialogRef = this.dialog.open(AddNewTeamComponent, {
      width: '400px',
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.setTeams();
      }
    });
  }

  /**
   * Deletes a team from the database
   * Refreshes the teams
   * Inform the user if the selected team has an active match
   * @param teamId Team id to be deleted
   */
  deleteTeam(teamId: number) {
    this.teamService.apiTeamTeamIdDelete$Response({ teamId: teamId }).subscribe(
      (response: StrictHttpResponse<void>) => {
        this.teams = this.teams.filter(team => team.id !== teamId);
      },
      (err) => {
        if(err.status == 405){
          alert("Can't delete a team with an active match.");
        }
        console.error(err);
      }
    );
  }

  /**
   * Sets the teams from the database in ABC order
   */
  setTeams() {
    this.teamService.apiTeamGet$Json$Response({
    }).subscribe(
      (response: StrictHttpResponse<Array<TeamHeader>>) => {
        this.teams = response.body;
        this.teams.sort((a, b) => a.name!.localeCompare(b.name!));
        this.cdr.detectChanges();
      },
      (err) => {
        console.error(err);
      });
  }
}

