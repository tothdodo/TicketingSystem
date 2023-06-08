import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GameDetails, SeatHeader, SectorHeader } from 'src/app/api/models';
import { GameService, SeatService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';
import { DataService } from 'src/my-services/data-service';
import { SignalRService } from 'src/my-services/signal-r.service';

@Component({
  selector: 'app-auditorium',
  templateUrl: './auditorium.component.html',
  styleUrls: ['./auditorium.component.css']
})
export class AuditoriumComponent {  

  /**
   * Map of marked seats with their type
   */
  markedSeats: Map<SeatHeader, string> = new Map<SeatHeader, string>();

  /**
   * Game id from the route
   */
  gameId!: number;

  /**
   * Game details
   */
  game!: GameDetails;

  /**
   * @param gameService DI for the game service
   * @param seatService DI for the seat service
   * @param dataService DI for the data service
   * @param route Activated route DI
   * @param signalRService DI for the signalR service
   */
  constructor(
    private gameService: GameService,
    private seatService: SeatService,
    private dataService: DataService,
    private route: ActivatedRoute,
    public signalRService: SignalRService
    ){}
  
  /**
   * Subscribes to the marked seats map and starts the signalR connection
   * Gets the game id from the route and calls the game service to get the game details
   * Sets the auditorium sectors
   */
  ngOnInit(): void{
    this.dataService.currentMarkedSeats.subscribe(markedSeats => this.markedSeats = markedSeats);
    
    this.signalRService.startConnection();
    this.signalRService.addTransferSeatStatusListener();
    this.signalRService.addBroadcastSeatStatusListener();

    this.gameId = Number(this.route.snapshot.paramMap.get('gameId'));
    this.gameService.apiGameGamesGameIdGet$Json$Response({
      gameId: this.gameId
    }).subscribe(
      (response: StrictHttpResponse<GameDetails>) => {
      this.signalRService.sectors = response.body.sectors!;
      this.game = response.body;
      },
    (err) => {
      console.error(err);
    });
  }
  /**
   * After the view is checked, sets the color of the seats
   */
  ngAfterViewChecked(){    
    for(let sector of this.signalRService.sectors){
      for(let row of sector.rows!){
        for(let seat of row.seats!){
          const seatButton = document.getElementById(seat.id!.toString());
        }
      }      
    }    
  }
  /**
   * If there are marked seats, calls the seat service to set their status to available
   * Inform the user that the ticket reservations are lost
   */
  ngOnDestroy(){
     if(this.markedSeats.size != 0){      
       for(let markedSeat of this.markedSeats){
         markedSeat[0].status = "Available";
         this.seatService.apiSeatGameIdPut$Json$Response({
          gameId: this.gameId,
          body: markedSeat[0]
        }).subscribe(
          (response: StrictHttpResponse<SeatHeader>) => {},
        (err) => {
          console.error(err);
          return;
        });           
       }
       alert('Ticket reservations are lost!');
     }    
     this.markedSeats.clear();
  }

  /**
   * Increase or decrease the marked seats map
   * Sets the seat status to available or bought
   * Calls the seat service to update the seat status
   * Calls the signalR service to broadcast the seat status
   * If the maximum number of tickets is reached, inform the user 
   * @param seat Clicked seat by the user
   */
  seatClicked(seat: SeatHeader): void{
     if(this.markedSeats.has(seat)){
       this.markedSeats.delete(seat);
       seat.status = "Available";
       this.signalRService.broadcastSeatStatus(seat);
       this.seatService.apiSeatGameIdPut$Json$Response({
        gameId: this.gameId,
        body: seat
      }).subscribe(
        (response: StrictHttpResponse<SeatHeader>) => {
          console.log("GameSeat available again!" + response);
        },
      (err) => {
        console.error(err);
      });
     }
     else {
       const maximumTicket = 5;
       if(this.markedSeats.size == maximumTicket){
         alert(`Maximum ${maximumTicket} tickets can be bought at a time.`);
       }
       else{        
         this.markedSeats.set(seat, "Adult");
         seat.status = "Marked";
         let tempSeat = {...seat};
         tempSeat.status = "Bought";
         this.signalRService.broadcastSeatStatus(tempSeat);
         this.seatService.apiSeatGameIdPut$Json$Response({
          gameId: this.gameId,
          body: tempSeat
        }).subscribe(
          (response: StrictHttpResponse<SeatHeader>) => {
            console.log("GameSeat not available anymore!" + response);
          },
        (err) => {
          console.error(err);
        });
         };      
      }
      this.dataService.sendEvent();
    }
  
  /**
   * @param sectorName Sector name
   * @returns The sector with the given name
   */
  findBySector(sectorName: string): SectorHeader{
    let sector = this.signalRService.sectors.find(sector => sector.sectorName === sectorName)!;
    return sector;
  }

  /**
   * Gives color based on the seat status
   * @param seat Seat header
   * @returns The background color of the seat
   */
  setBackgroundColor( seat: SeatHeader): string {
    if(this.isMarkedSeat(seat)){
      return "orange";
    }
    switch(seat.status){
      case "Available": {
        return "yellow";
      }
      case "Seasonal": {
        return "grey";
      }
      case "Bought": {
        return "black";
      }
      default: return "yellow";
    }
  }

  /**
   * Gives color based on the seat status
   * @param seat Seat header
   * @returns The color of the seat
   */

  setColor(seat: SeatHeader): string {
    if(this.isMarkedSeat(seat)){
      return "black";
    }
    switch(seat.status){
      case "Available": {
        return "black";
      }
      case "Seasonal": {
        return "White";
      }
      case "Bought": {
        return "White";
      }
      default: return "";
    }
  }

  /**
   * Checks if the seat is disabled based on the seat status
   * @param seat Seat header
   * @returns True if the seat is disabled, false otherwise
   */
  public isDisabled(seat: SeatHeader): boolean{    
    if((seat.status === "Bought" || seat.status === "Seasonal")  && !this.isMarkedSeat(seat)){
      return true;
    }
    return false;
  }

  /**
   * Checks if the seat is contained in the marked seats map
   * @param seat Seat header
   * @returns True if the seat is contained in the marked seats map, false otherwise 
   */
  public isMarkedSeat = (seat: SeatHeader): boolean => {
    for(let markedSeat of this.markedSeats){
      if(seat.id == markedSeat[0].id){
        return true;
      }
    }
    return false;
  }
  
  /**
   * Format the Date object to a string
   * @param date Date to be formatted
   * @returns Formatted date
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
   * Month number to string converter
   * @param monthNumber Month number
   * @returns Month name
   */
  getMonthName(monthNumber: number) {
    const date = new Date();
    date.setMonth(monthNumber - 1);
  
    return date.toLocaleString('en-US', { month: 'long' });
  }
}
