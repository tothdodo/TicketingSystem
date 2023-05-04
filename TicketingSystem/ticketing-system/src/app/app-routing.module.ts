import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddPlayerComponent } from 'src/components/add-player/add-player.component';
import { GameSeatsComponent } from 'src/components/game-seats/game-seats.component';
import { HomeComponent } from 'src/components/home/home.component';
import { PageNotFoundComponent } from 'src/components/page-not-found/page-not-found.component';
import { SettingsComponent } from 'src/components/settings/settings.component';
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
  { path: 'settings',
    title: 'Settings',
     children: [
      {
        path: '',
        component: SettingsComponent
      },
       {
         path: 'add-player',
         title: 'Add Player',
         component: AddPlayerComponent
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
