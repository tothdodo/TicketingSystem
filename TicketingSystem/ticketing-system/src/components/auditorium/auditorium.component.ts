import { Component, EventEmitter, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SeatHeader, SectorHeader } from 'src/app/api/models';
import { SeatService, SectorService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';
import { DataService } from 'src/my-services/data-service';
import { SignalRService } from 'src/my-services/signal-r.service';

@Component({
  selector: 'app-auditorium',
  templateUrl: './auditorium.component.html',
  styleUrls: ['./auditorium.component.css']
})
export class AuditoriumComponent {  

  markedSeats: Map<SeatHeader, string> = new Map<SeatHeader, string>();

  gameId!: number;

  constructor(
    private sectorService: SectorService,
    private seatService: SeatService,
    private dataService: DataService,
    private route: ActivatedRoute,
    public signalRService: SignalRService
    ){}

  ngOnInit(): void{
    this.dataService.currentMarkedSeats.subscribe(markedSeats => this.markedSeats = markedSeats);
    
    this.signalRService.startConnection();
    this.signalRService.addTransferSeatStatusListener();
    this.signalRService.addBroadcastSeatStatusListener();

    this.gameId = Number(this.route.snapshot.paramMap.get('gameId'));
    this.sectorService.apiSectorGameIdGet$Json$Response({
      gameId: this.gameId
    }).subscribe(
      (response: StrictHttpResponse<Array<SectorHeader>>) => {
      this.signalRService.sectors = response.body;
      },
    (err) => {
      console.error(err);
    });
  }
  //???
  ngAfterViewChecked(){    
    for(let sector of this.signalRService.sectors){
      for(let row of sector.rows!){
        for(let seat of row.seats!){
          const seatButton = document.getElementById(seat.id!.toString());
        }
      }      
    }    
  }

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
  
  findBySector(sectorName: string): SectorHeader{
    let sector = this.signalRService.sectors.find(sector => sector.sectorName === sectorName)!;
    //if(sectorName === 'C'){
      //return sector.reverse();
    //}
    return sector;
  }

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

  public isDisabled(seat: SeatHeader): boolean{    
    if((seat.status === "Bought" || seat.status === "Seasonal")  && !this.isMarkedSeat(seat)){
      return true;
    }
    return false;
  }

  public isMarkedSeat = (seat: SeatHeader): boolean => {
    for(let markedSeat of this.markedSeats){
      if(seat.id == markedSeat[0].id){
        return true;
      }
    }
    return false;
  }
}
