import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public purchaseViewModel = {};
  public totalAmount: any;
  http: HttpClient;
  constructor(http: HttpClient) {
    this.http = http;
    this.purchaseViewModel = { numberOfCustomer: 2, pricePerPerson: 500, couponCode:'NONE'}
  }
  calculate() {
    this.http.post<any>(environment.apiUrl + '/api/Purchase', this.purchaseViewModel).subscribe(result => {
      this.totalAmount = result;
    }, error => console.error(error));
  }
}

