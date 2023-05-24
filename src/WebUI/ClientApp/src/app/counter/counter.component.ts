import { Component } from '@angular/core';

@Component({
  selector: 'app-service-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;

  public incrementservice() {
    this.currentCount++;
  }
}

