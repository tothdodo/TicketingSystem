import { Component } from '@angular/core';
import { GameHeader } from 'src/app/api/models';
import { GameService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';
@Component({
  selector: 'app-tickets',
  templateUrl: './tickets.component.html',
  styleUrls: ['./tickets.component.css']
})
export class TicketsComponent {  
  /**
   * Collection of all the games
   */
  games: GameHeader[] = [];

  /**
   * @param gameService DI for the game service
   */
  constructor(private gameService: GameService){}

  /**
   * Gets all the gameswW
   */
  ngOnInit(): void{
    this.gameService.apiGameGamesGet$Json$Response().subscribe(
      (response: StrictHttpResponse<Array<GameHeader>>) => {
      //alert('Seats loaded successfully for Game with Id' + this.gameId);
      this.games = response.body;
      },
    (err) => {
      console.error(err);
    });
  }

  /**
   * Deletes a game from the database
   * @param gameId Game id to be deleted
   */
  deleteGame(gameId: number){
    this.gameService.apiGameGameIdDelete$Response({gameId: gameId}).subscribe(
      (response: StrictHttpResponse<void>) => {
        alert('Game deleted successfully!');
        this.ngOnInit();
      },
      (err) => {
        console.error(err);
      }
    );
  }

  /**
   * @param date Date to be formatted
   * @returns Date in the format of DD MMM HH:MM
   */
  getDate(date: Date): string{
    const dateTime = new Date(date);
    const month = String(dateTime.getMonth() + 1).padStart(2, '0');
    const newDate = String(dateTime.getDate()).padStart(2, '0');
    const hour = String(dateTime.getHours()).padStart(2, '0');
    const minute = String(dateTime.getMinutes()).padStart(2, '0');
    return `${newDate} ${this.getMonthName(Number(month)).slice(0, 3)} ${hour}:${minute}`.toUpperCase();
  }

  /**
   * @param monthNumber Month number to get the name of
   * @returns Month name
   */
  getMonthName(monthNumber: number) {
    const date = new Date();
    date.setMonth(monthNumber - 1);
  
    return date.toLocaleString('en-US', { month: 'long' });
  }
}
