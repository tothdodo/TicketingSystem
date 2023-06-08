import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateGame, GameHeader, TeamHeader } from 'src/app/api/models';
import { GameService, TeamService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';

@Component({
  selector: 'app-add-game',
  templateUrl: './add-game.component.html',
  styleUrls: ['./add-game.component.css']
})
export class AddGameComponent {
  /**
   * Hours and minutes for the time picker
   */
  hours: number[] = Array.from({ length: 24 }, (_, i) => i);
  minutes: number[] = Array.from({ length: 60 }, (_, i) => i);

  /**
   * Form group for the add game form
   */
  addGameForm!: FormGroup;

  /**
   * Minimum date for the date picker
   */
  minDate: Date;

  /**
   * Loading and success flags
   */
  loading = false;
  success = false;

  /**
   * Array of teams in the league
   */
  leagueTeams: Array<TeamHeader> = new Array<TeamHeader>;

  /**
   * 
   * @param gameService DI for the game service
   * @param fb DI for the form builder
   * @param teamService DI for the team service
   */
  constructor(private gameService: GameService, private fb: FormBuilder, private teamService: TeamService) {
    this.minDate = new Date();    
  }

  /**
   * Builds the form group and subscribes to its value changes
   * Sets teams for the dropdowns
   */
  ngOnInit() {
    this.addGameForm = this.fb.group({
      homeTeam: ['', Validators.required],
      awayTeam: ['', Validators.required],
      date: ['', Validators.required],
      hour: ['', Validators.required],
      min: ['', Validators.required]
    });
    this.setTeams();
    this.addGameForm.valueChanges.subscribe(console.log);
  }

  /**
   * Creates a new game with the given data
   * Http post request to the server
   * 
   * @returns if team selection is invalid
   */
  submitHandler() {
    if(this.addGameForm.get("homeTeam")?.value == this.addGameForm.get("awayTeam")?.value){
      alert("Home and away team cannot be the same!");
      return;
    }
    this.loading = true;

    const startTime = new Date(this.addGameForm.get("date")?.value);
    startTime.setHours(this.addGameForm.get("hour")?.value);
    startTime.setMinutes(this.addGameForm.get("min")?.value);

    let newGame: CreateGame = {
      homeTeam: this.addGameForm.get("homeTeam")?.value.name,
      awayTeam: this.addGameForm.get("awayTeam")?.value.name,
      startTime: startTime
    }

    this.gameService.apiGamePost$Json$Response({
        body: newGame
     }).subscribe(
       (response: StrictHttpResponse<GameHeader>) => {
         console.log(response);
         this.success = true;
       },
     (err) => {
      if(err.status == 409)
        alert("There cannot be another match within 2 hours range!");
      else
       console.error(err);
     });
     this.loading = false;
  }

  /**
   * Sets the teams for the dropdowns from the server
   */
  setTeams(){
    this.teamService.apiTeamGet$Json$Response({
    }).subscribe(
      (response: StrictHttpResponse<Array<TeamHeader>>) => {
        this.leagueTeams = response.body;
        this.leagueTeams.sort((a, b) => a.name!.localeCompare(b.name!));
      },
      (err) => {
        console.error(err);
      });
  }

  /**
   * Getters for the form controls
   */

  get homeTeam() { return this.addGameForm.get('homeTeam'); }

  get awayTeam() { return this.addGameForm.get('awayTeam'); }
  
  get startDate() { return this.addGameForm.get('startDate'); }

  get startTime() { return this.addGameForm.get('startTime'); }

}
