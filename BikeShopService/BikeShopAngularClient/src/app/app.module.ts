import { HttpClientModule } from '@angular/common/http';    //automatically registered HttpClientModule for consuming the Http-Methods
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { BikeListBoxComponent } from './bike-list-box/bike-list-box.component';
import { BikeDetailsComponent } from './bike-details/bike-details.component';
import { FooterComponent } from './footer/footer.component';
import { NavbarComponent } from './navbar/navbar.component';
import { SharedService } from './shared.service';     //registered the Shared Service

import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    BikeListBoxComponent,
    BikeDetailsComponent,
    FooterComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule, ReactiveFormsModule
  ],
  providers: [SharedService], //registered Shared Service as Provider
  bootstrap: [AppComponent]
})
export class AppModule { }
