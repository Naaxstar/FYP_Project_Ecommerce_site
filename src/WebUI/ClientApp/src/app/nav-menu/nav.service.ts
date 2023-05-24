import { Injectable } from '@angular/core';
import {BehaviorSubject} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class NavService {
  navData = new BehaviorSubject<any>({})

  constructor() { }
}
