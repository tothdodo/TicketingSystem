/* tslint:disable */
/* eslint-disable */
import { SectorHeader } from './sector-header';
export interface GameDetails {
  awayTeam?: null | string;
  awayTeamLogoUrl?: null | string;
  homeTeam?: null | string;
  homeTeamLogoUrl?: null | string;
  id?: number;
  place?: null | string;
  sectors?: null | Array<SectorHeader>;
  startTime?: Date;
}
