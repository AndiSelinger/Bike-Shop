import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { from, Observable, of, take, tap } from 'rxjs';
import { Bike } from './bike.model';
import { SharedService } from './shared.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {

  public http! : HttpClient;
  sharedService = new SharedService(this.http);

  title = "BikeShopAngularClient";

  //bikeList: Bike[] = [];

  //readBikeListFromHttp() {
  //  this.sharedService.getBikeList().subscribe(res => this.bikeList = res as Bike[]);
  //}
  

  bikeList: Bike[] =
  [
    new Bike('Suzuki', 'GSXR', 'Hayabusa', 'VAM3456493847365', 175, 1300, new Date('2005-01-06'), 8000, 23000, 'assets/img/Hayabusa.jpg'),
    new Bike('Yamaha', 'YZF', 'R1', 'YAM58376859472846', 198, 998, new Date('2020-06-10'), 19000, 6750, 'assets/img/R1.jfif'),
    new Bike('Honda', 'CBR', '1000RR-R Fireblade SP', 'HOL000051T2123456', 217, 1000, new Date('2022-02-02'), 32000, 100, 'assets/img/Fireblade.jfif')
  ];

  selectedBike!: Bike;

  sendDetails(_selectedBike: Bike) {
    this.selectedBike = _selectedBike;
  }
}
