/* tslint:disable */
/* eslint-disable */
import { GameSeatHeader } from './game-seat-header';
export interface SeatHeader {
  gameSeats?: null | Array<GameSeatHeader>;
  id?: number;
  rowId?: number;
  rowNumber?: number;
  seatNumber?: number;
  sectorName?: null | string;
  status?: null | string;
}
