import { Component, Input, OnInit } from '@angular/core';
import { Bike } from '../bike.model';

@Component({
  selector: 'app-bike-details',
  templateUrl: './bike-details.component.html',
  styleUrls: ['./bike-details.component.css']
})
export class BikeDetailsComponent implements OnInit {

  @Input() selected!: Bike;

  constructor() { }

  ngOnInit(): void {
  }

}
