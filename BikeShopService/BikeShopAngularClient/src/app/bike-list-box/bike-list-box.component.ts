import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Bike } from '../bike.model';

@Component({
  selector: 'app-bike-list-box',
  templateUrl: './bike-list-box.component.html',
  styleUrls: ['./bike-list-box.component.css']
})
export class BikeListBoxComponent implements OnInit {


  constructor() { }

  @Input() bike!: Bike;
  @Output() selectedBike = new EventEmitter<void>();

  ngOnInit() {
  }

  selectBike() {
    this.selectedBike.emit();
  }
}
