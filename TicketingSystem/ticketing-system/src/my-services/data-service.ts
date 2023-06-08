import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { SeatHeader } from 'src/app/api/models';

@Injectable()
export class DataService {
    /**
     * Map of marked seats with their type
     */
    private markedSeatsSource = new BehaviorSubject<Map<SeatHeader, string>>(new Map<SeatHeader, string>); 
    currentMarkedSeats = this.markedSeatsSource.asObservable();

    /**
     * @param markedSeats Map of marked seats with their type
     */
    changeMarkedSeats(markedSeats: Map<SeatHeader, string>){
        this.markedSeatsSource.next(markedSeats);
    }
    
    private subject = new Subject<any>();

    /**
     * Sends an event
     */
    sendEvent() {
        this.subject.next("sent");
    }

    /**
     * Gets the event
     * @returns Observable of the event
     */
    getEvent(): Observable<any> {
        return this.subject.asObservable();
    }
}