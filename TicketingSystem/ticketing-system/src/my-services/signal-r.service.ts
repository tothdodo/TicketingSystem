import { Injectable } from '@angular/core';
import * as signalR from "@aspnet/signalr";
import { SeatHeader, SectorHeader } from 'src/app/api/models';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  /**
   * Collection of all the sectors
   */
  public sectors: SectorHeader[] = [];

  /**
   * Hub connection to the server
   */
  private hubConnection!: signalR.HubConnection;

  /**
   * Starts the connection with the server
   */
  public startConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:7090/seat-status')
      .build();

    this.hubConnection
      .start()
      .then(() => console.log("Connection started"))
      .catch(err => console.log("Error while starting connection: " + err)); 
  }

  /**
   * Listening for the seat status change and changes the status of the seat
   */
  public addTransferSeatStatusListener = () => {
    this.hubConnection.on('transferseatstatus', (seat) => {
      this.changeSeatStatus(seat);
      console.log(seat.status);
    })
  }

  /**
   * Broadcast the seat status to the other clients
   * @param seat Seat to be broadcasted
   */
  public broadcastSeatStatus = (seat: SeatHeader) => {
    this.hubConnection.invoke('broadcastseatstatus', seat)
      .catch(err => console.log(err));
  }

  /**
   * Listening for the seat status change and changes the status of the seat
   */
  public addBroadcastSeatStatusListener = () => {
    this.hubConnection.on('broadcastseatstatus', (seat) => {
      this.changeSeatStatus(seat);
    })
  }

  /**
   * Sets the status of the seat
   * @param changedSeat Seat to be changed
   */
  public changeSeatStatus(changedSeat: SeatHeader){
    for(let sector of this.sectors){
      for(let row of sector.rows!){
        for(let seat of row.seats!){
          if(seat.id == changedSeat.id){
            seat.status = changedSeat.status;
          }
        }
      }
    }
  }
}
