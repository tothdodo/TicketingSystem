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
  /**
   * Subscription for the seat clicked event
   */
  seatClickedEventSubscription?: Subscription;

  /**
   * Map of marked seats with their type
   */
  markedSeats: Map<SeatHeader, string> = new Map<SeatHeader, string>();

  /**
   * Collection of ticket types
   */
  ticketTypes: string[] = [];
  /**
   * Price of the regular ticket
   */
  price: number = 3000;

  /**
   * Game id from the route
   */
  gameId!: number;
  
  /**
   * Total price of the tickets
   */
  totalPrice: number = 0;

  /**
   * Subscribes to the total price change event through the data service
   * @param dataService DI for the data service
   * @param route Activated route DI
   * @param seatService DI for the seat service
   */
  constructor(
    private dataService: DataService,
    private route: ActivatedRoute,
    private seatService: SeatService
    ){
      this.seatClickedEventSubscription = this.dataService.getEvent().subscribe(() => {
        this.calculateTotalPrice();
      })
    }

  /**
   * Subscribes the markedseats to the dataserivce
   * Gets the game id from the route
   * Sets the ticket types
   */
  ngOnInit(){
    this.dataService.currentMarkedSeats.subscribe(markedSeats => this.markedSeats = markedSeats);
    this.gameId = Number(this.route.snapshot.paramMap.get('gameId'));

    this.ticketTypes = [
      "Adult",
      "Student/Pensioner"
    ]
  }

  /**
   * Calls the seat service to buy the marked seats
   * Alerts the user about the successful transaction
   * Clears the marked seats
   */
  buyClick(){
     for(let markedSeat of this.markedSeats){
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

  /**
   * Recalculates the total price
   * @param chosenType Ticket type
   * @param key SeatHeader key of the marked seat map
   */
  onChange(chosenType: string, key: SeatHeader) {
    this.markedSeats.set(key, chosenType);
    this.calculateTotalPrice();
  }

  /**
   * Calculates the total price of the marked seats
   */
  calculateTotalPrice(){
    this.totalPrice = 0;
    for(let markedSeat of this.markedSeats){
      this.totalPrice += this.calculateTicketPrice(markedSeat[1]);
    }
  }
  
  /**
   * Calculates the price of the ticket based on the ticket type
   * @param value Ticket type
   * @returns Price of the ticket
   */
  calculateTicketPrice(value: string): number{
    switch(value){
      case "Adult" : return this.price;
      case "Student/Pensioner": return this.price * 0.5;
      default: return this.price;
    }
  }
}
