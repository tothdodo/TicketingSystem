import { NgModule } from '@angular/core';
import { BrowserModule} from '@angular/platform-browser';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms'
import { MatSelectCountryModule } from "@angular-material-extensions/select-country";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TicketsComponent } from 'src/components/tickets/tickets.component';
import { GameSeatsComponent } from 'src/components/game-seats/game-seats.component';
import { HeaderComponent } from 'src/components/header/header.component';
import { HomeComponent } from 'src/components/home/home.component';
import { PageNotFoundComponent } from 'src/components/page-not-found/page-not-found.component';
import { ApiModule } from './api/api.module';
import { AuditoriumComponent } from 'src/components/auditorium/auditorium.component';
import { MarkedSeatsComponent } from 'src/components/marked-seats/marked-seats.component';
import { DataService } from 'src/my-services/data-service';
import { FooterComponent } from 'src/components/footer/footer.component';
import { TeamComponent } from 'src/components/team/team.component';
import { AddPlayerComponent } from 'src/components/add-player/add-player.component';
import { SignalRService } from 'src/my-services/signal-r.service';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { ReactiveFormsModule } from '@angular/forms';
import { NgxMatTimepickerModule } from 'ngx-mat-timepicker';
import { MatSelectModule } from '@angular/material/select';
import { MatButtonModule } from '@angular/material/button';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatChipsModule } from '@angular/material/chips';
import { SortByPipe } from 'src/pipes/sortByPipe';
import { SortByDescPipe } from 'src/pipes/sortByDescendingPipe';
import { NewsDetailsComponent } from 'src/components/news-details/news-details.component';
import { AddNewsComponent } from 'src/components/add-news/add-news.component';
import { AddGameComponent } from 'src/components/add-game/add-game.component';
import { AngularMarkdownEditorModule } from 'angular-markdown-editor';
import { ManageTeamsComponent } from 'src/components/manage-teams/manage-teams.component';
import { MatDialogModule } from '@angular/material/dialog';
import { AddNewTeamComponent } from 'src/components/add-new-team/add-new-team.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TicketsComponent,
    GameSeatsComponent,
    HeaderComponent,
    AuditoriumComponent,
    MarkedSeatsComponent,
    FooterComponent,
    PageNotFoundComponent,
    TeamComponent,
    AddPlayerComponent,
    AddNewsComponent,
    AddGameComponent,
    NewsDetailsComponent,
    ManageTeamsComponent,
    AddNewTeamComponent,
    SortByPipe,
    SortByDescPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgxMatTimepickerModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    ApiModule,
    BrowserAnimationsModule,
    MatDatepickerModule,
    MatInputModule,
    MatNativeDateModule,
    MatSelectModule,
    MatButtonModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDialogModule,
    AngularMarkdownEditorModule.forRoot({ iconlibrary: 'fa' }),
    MatSelectCountryModule.forRoot('en')
  ],
  providers: [DataService, SignalRService],
  bootstrap: [AppComponent]
})
export class AppModule { }
