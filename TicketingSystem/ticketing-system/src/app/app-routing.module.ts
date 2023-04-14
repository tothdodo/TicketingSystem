import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GameSeatsComponent } from 'src/components/game-seats/game-seats.component';
import { HomeComponent } from 'src/components/home/home.component';
import { PageNotFoundComponent } from 'src/components/page-not-found/page-not-found.component';
import { TeamComponent } from 'src/components/team/team.component';
import { TicketsComponent } from 'src/components/tickets/tickets.component';

const routes: Routes = [
  { path: 'home', title: 'Home', component: HomeComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'tickets',
    title: 'Tickets',
     children: [
      {
        path: '',
        component: TicketsComponent
      },
       {
         path: 'seats/:gameId',
         title: 'Seats',
         component: GameSeatsComponent
       }
     ]
  },
  { path: 'team', title: 'Team', component: TeamComponent},
  
  { path: '**', component: PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
