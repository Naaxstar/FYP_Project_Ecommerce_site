import { Component, OnInit } from '@angular/core';
import {RouterLink} from "@angular/router";

@Component({
  selector: 'app-enlightment',
  templateUrl: './enlightment.component.html',
  styleUrls: ['./enlightment.component.scss'],

})
export class EnlightmentComponent implements OnInit {
  isExpanded = true;

  constructor() { }

  ngOnInit(): void {
  }

}
