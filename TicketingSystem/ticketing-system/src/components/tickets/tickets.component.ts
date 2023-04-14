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
  games: GameHeader[] = [];

  constructor(private gameService: GameService){}

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

  getDate(date: string): string{
    const dateTime = new Date(date);
    const year = dateTime.getFullYear();
    const month = String(dateTime.getMonth() + 1).padStart(2, '0');
    const newDate = String(dateTime.getDate()).padStart(2, '0');
    const hour = String(dateTime.getHours()).padStart(2, '0');
    const minute = String(dateTime.getMinutes()).padStart(2, '0');
    return `${newDate} ${this.getMonthName(Number(month)).slice(0, 3)} ${hour}:${minute}`.toUpperCase();
    return `${year}/${month}/${newDate} ${hour}:${minute}`;
  }

  getMonthName(monthNumber: number) {
    const date = new Date();
    date.setMonth(monthNumber - 1);
  
    return date.toLocaleString('en-US', { month: 'long' });
  }

  getLogo(gameId: number): string{
    switch(gameId){
      case 1: return "assets/deac_logo.png";
      case 2: return "assets/alba_logo.png";
      case 3: return "assets/szolnok_logo.png";
      default: return "";
    }
  }
}
