import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddGameComponent } from 'src/components/add-game/add-game.component';
import { AddNewsComponent } from 'src/components/add-news/add-news.component';
import { AddPlayerComponent } from 'src/components/add-player/add-player.component';
import { GameSeatsComponent } from 'src/components/game-seats/game-seats.component';
import { HomeComponent } from 'src/components/home/home.component';
import { ManageTeamsComponent } from 'src/components/manage-teams/manage-teams.component';
import { NewsDetailsComponent } from 'src/components/news-details/news-details.component';
import { PageNotFoundComponent } from 'src/components/page-not-found/page-not-found.component';
import { TeamComponent } from 'src/components/team/team.component';
import { TicketsComponent } from 'src/components/tickets/tickets.component';

const routes: Routes = [
  { path: 'home', title: 'Home', component: HomeComponent },
  { path: 'news/:newsUrlId', title: 'News', component: NewsDetailsComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  {
    path: 'tickets',
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
  {
    path: 'settings',
    title: 'Settings',
    children: [
      {
        path: 'add-player',
        title: 'Add Player',
        component: AddPlayerComponent
      },
      {
        path: 'add-game',
        title: 'Add Game',
        component: AddGameComponent
      },
      {
        path: 'add-news',
        title: 'Add News',
        component: AddNewsComponent
      },
      {
        path: 'manage-teams',
        title: 'Manage Teams',
        component: ManageTeamsComponent
      }
    ]
  },
  { path: 'team', title: 'Team', component: TeamComponent },

  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
