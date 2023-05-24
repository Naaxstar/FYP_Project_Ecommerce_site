import {Component, OnInit, SecurityContext} from '@angular/core';
import {BookingClient, CreateBooking} from "../web-api-client";
import {DomSanitizer} from "@angular/platform-browser";

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {
  date: any = '';
  serviceName: any = '';
  time: any = '';
  firstName: any = '';
  lastName: any = '';
  phoneNumber: any = '';

  servicesType = [
    "Shariah Compliant Consultation",
   "Sizing Consultation",
   "Skint Tone Consultation"
  ]
  constructor(private _booking:BookingClient,private sanitizer:DomSanitizer) { }

  ngOnInit(): void {

  }

  createBooking() {
    let booking = new CreateBooking()
    booking.date = this.date
    booking.firstName = this.firstName
    booking.lastName = this.lastName
    booking.time = this.time
    booking.phoneNumber = this.phoneNumber
    booking.serviceName = this.serviceName
    booking.price = 0
    this._booking.createBooking(booking)
      .subscribe(x=>console.log(x))
  }

  onValueChange(value: any) {

  }
}
