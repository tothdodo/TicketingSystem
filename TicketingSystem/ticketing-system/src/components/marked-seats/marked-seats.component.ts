import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SeatHeader } from 'src/app/api/models';
import { SeatService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';
import { DataService } from 'src/my-services/data-service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-marked-seats',
  templateUrl: './marked-seats.component.html',
  styleUrls: ['./marked-seats.component.css']
})
export class MarkedSeatsComponent {
seatClickedEventSubscription?: Subscription;

  markedSeats: Map<SeatHeader, string> = new Map<SeatHeader, string>();

  ticketTypes: string[] = [];
  //selectedTypes: any[] = Array(5).fill("Adult");
  price: number = 3000;

  gameId!: number;
  
  totalPrice: number = 0;

  constructor(
    private dataService: DataService,
    private route: ActivatedRoute,
    private seatService: SeatService
    ){
      this.seatClickedEventSubscription = this.dataService.getEvent().subscribe(() => {
        this.calculateTotalPrice();
      })
    }

  ngOnInit(){
    this.dataService.currentMarkedSeats.subscribe(markedSeats => this.markedSeats = markedSeats);
    this.gameId = Number(this.route.snapshot.paramMap.get('gameId'));

    this.ticketTypes = [
      "Adult",
      "Student/Pensioner"
    ]
  }

  buyClick(){
     for(let markedSeat of this.markedSeats){
       //console.log(`seatid: ${markedSeat.seatId}, gameid: ${markedSeat.gameId}`)
       markedSeat[0].status = "Bought";
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
     alert(`Successful transaction for ${this.totalPrice} Ft!`);

     this.markedSeats.clear();
  }

  onChange(chosenType: string, key: SeatHeader) {
    this.markedSeats.set(key, chosenType);
    this.calculateTotalPrice();
  }

  calculateTotalPrice(){
    this.totalPrice = 0;
    for(let markedSeat of this.markedSeats){
      this.totalPrice += this.calculateTicketPrice(markedSeat[1]);
    }
  }
  
  calculateTicketPrice(value: string): number{
    switch(value){
      case "Adult" : return this.price;
      case "Student/Pensioner": return this.price * 0.5;
      default: return this.price;
    }
  }
}
