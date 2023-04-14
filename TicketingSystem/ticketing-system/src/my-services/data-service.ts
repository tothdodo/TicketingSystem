import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { SeatHeader } from 'src/app/api/models';

@Injectable()
export class DataService {
    private markedSeatsSource = new BehaviorSubject<Map<SeatHeader, string>>(new Map<SeatHeader, string>); 
    currentMarkedSeats = this.markedSeatsSource.asObservable();

    changeMarkedSeats(markedSeats: Map<SeatHeader, string>){
        this.markedSeatsSource.next(markedSeats);
    }

    private subject = new Subject<any>();

    sendEvent() {
        this.subject.next("sent");
    }

    getEvent(): Observable<any> {
        return this.subject.asObservable();
    }
}