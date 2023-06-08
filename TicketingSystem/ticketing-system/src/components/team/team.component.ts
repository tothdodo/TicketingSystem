import { Component } from '@angular/core';
import { PlayerHeader } from 'src/app/api/models';
import { PlayerService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';

@Component({
  selector: 'app-team',
  templateUrl: './team.component.html',
  styleUrls: ['./team.component.css']
})
export class TeamComponent {
  /**
   * Collection of all the players
   */
  players: Array<PlayerHeader> = new Array<PlayerHeader>;

  /**
   * 
   * @param playerService DI for the player service
   */
  constructor(private playerService: PlayerService){}

  /**
   * Gets all the players and sorts them by jersey number ascending
   */
  ngOnInit(){
    this.playerService.apiPlayerTeamGet$Json$Response({
    }).subscribe(
      (response: StrictHttpResponse<Array<PlayerHeader>>) => {
      this.players = response.body;      
      this.players.sort((a, b) => a.jerseyNumber! - b.jerseyNumber!);
      },
    (err) => {
      console.error(err);
    });
  }

  /**
   * Calculates the age from the birth date
   * @param birthDate Birth date to calculate the age from
   * @returns Age
   */
  calculateAge(birthDate: Date): number {
    const currentDate = new Date();

    const validBirthDate = new Date(birthDate.toString());
    
    const age = currentDate.getFullYear() - validBirthDate.getFullYear();
    
    if (currentDate.getMonth() < validBirthDate.getMonth() || 
      (currentDate.getMonth() === validBirthDate.getMonth() && currentDate.getDate() < validBirthDate.getDate())) {
      return age - 1;
    } else {
      return age;
    }
  }

  /**
   * Gets the first three letters from the string and capitalizes them
   * Used for the Nationality
   * @param str String to get the substring from
   * @returns First 3 letters of the string capitalized
   */
  getUppercaseSubstring(str: string): string {
    const substring = str.substr(0, 3);
    
    const capitalizedSubstring = substring.toUpperCase();
    
    return capitalizedSubstring;
  }

  /**
   * @param player Player to get the image source for
   * @returns source
   */
  getImageSource(player: PlayerHeader): string {
    const source = player.source;

    if(source === undefined || source === null || source === ''){
      return 'assets/images/players/default.png';
    }

    const extension = source.substr(source.length - 3, source.length);
    if(!(extension === 'jpg' || extension === 'png')){
      return 'assets/images/players/default.png';
    }

    return "assets/images/players/" + source;
  }

  /**
   * Calls service's the deletePlayer method with the player to be deleted
   * @param player Player to be deleted
   */
  deletePlayer(player: PlayerHeader){
    this.playerService.apiPlayerPlayerIdDelete$Response({
      playerId: player.id!
    }).subscribe(
      (response: StrictHttpResponse<void>) => {
        const index = this.players.indexOf(player);
        this.players.splice(index, 1);
      },
    (err) => {
      console.error(err);
    });
  }
}
