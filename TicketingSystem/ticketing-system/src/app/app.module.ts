import { NgModule } from '@angular/core';
import { BrowserModule} from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

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
    TeamComponent
  ],
  imports: [
    BrowserModule,  
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ApiModule
  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
