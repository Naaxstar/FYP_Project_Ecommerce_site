import { Component, OnInit } from '@angular/core';
import {EnlightmentComponent} from "../enlightment/enlightment.component";

@Component({
  selector: 'app-information',
  templateUrl: './information.component.html',
  styleUrls: ['./information.component.scss']
})
export class InformationComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  protected readonly EnlightmentComponent = EnlightmentComponent;
}
