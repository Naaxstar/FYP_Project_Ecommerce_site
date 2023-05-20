import {Component, OnInit} from '@angular/core';
import {WeatherForecastClient, WeatherForecast, BookingClient, Booking, GetBookings} from '../web-api-client';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit{
  public bookings: Booking[] = [];
  deleteId: number;

  constructor(private BookingClient: BookingClient) {

  }

  deleteItem() {
    this.BookingClient.delete(this.deleteId).subscribe(result => {
      console.log('delete success')
      this.getBookings()
    }, error => console.error(error));
  }

  ngOnInit(): void {
    this.getBookings()
  }

  getBookings () {
    let bookingquery = new GetBookings()
    this.BookingClient.getBookings(bookingquery).subscribe(result => {
      this.bookings = result;
    }, error => console.error(error));
  }
}
