import { Injectable } from '@angular/core';
import * as signalR from "@aspnet/signalr";
import { SeatHeader, SectorHeader } from 'src/app/api/models';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  public sectors: SectorHeader[] = [];

  private hubConnection!: signalR.HubConnection;

  public startConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:7090/seat-status')
      .build();

    this.hubConnection
      .start()
      .then(() => console.log("Connection started"))
      .catch(err => console.log("Error while starting connection: " + err)); 
  }

  //
  // Figyeli, ha kap infot a szerverről beállítja a this.data-t data-ra
  //
  public addTransferSeatStatusListener = () => {
    this.hubConnection.on('transferseatstatus', (seat) => {
      this.changeSeatStatus(seat);
      console.log(seat.status);
    })
  }


  //
  // Szétkürtöli
  //
  public broadcastSeatStatus = (seat: SeatHeader) => {
    this.hubConnection.invoke('broadcastseatstatus', seat)
      .catch(err => console.log(err));
  }

  //
  // Figyeli, ha kap infot a másik klienstől beállítja a this.broadcastedData-t data-ra
  //
  public addBroadcastSeatStatusListener = () => {
    this.hubConnection.on('broadcastseatstatus', (seat) => {
      this.changeSeatStatus(seat);
    })
  }

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
