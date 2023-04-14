/* tslint:disable */
/* eslint-disable */
import { SeatHeader } from './seat-header';
export interface RowHeader {
  id?: number;
  rowNumber?: number;
  seats?: null | Array<SeatHeader>;
  sectorId?: number;
}
