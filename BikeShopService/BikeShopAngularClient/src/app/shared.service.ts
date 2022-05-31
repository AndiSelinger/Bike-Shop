import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { Bike } from './bike.model';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly APIUrl = "https://localhost:5001/api";
  readonly PhotoUrls = "";

  constructor(private http: HttpClient) { }

  getBikeList(){
    return this.http.get<Bike[]>(this.APIUrl + '/Bike');
  }

  addBike(val: any) {
    return this.http.post(this.APIUrl + '/Bike', val);
  }

  updateBike(val: any) {
    return this.http.put(this.APIUrl + '/Bike', val);
  }

  deleteBike(val: any) {
    return this.http.delete(this.APIUrl + '/Bike', val);
  }

  getShopList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/Shop');
  }

  addShop(val: any) {
    return this.http.post(this.APIUrl + '/Shop', val);
  }

  updateShop(val: any) {
    return this.http.put(this.APIUrl + '/Shop', val);
  }

  deleteShop(val: any) {
    return this.http.delete(this.APIUrl + '/Shop', val);
  }
}
