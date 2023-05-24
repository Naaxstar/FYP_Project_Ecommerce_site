import {Component, OnInit} from '@angular/core';
import {HomeComponent} from "./home/home.component";
import {NavService} from "./nav-menu/nav.service";
import {ActivatedRoute, NavigationEnd, Router} from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  title = 'app';
  currentRoute = ''
  headerImage: any = '';
  headerMessage: any = ''

  constructor(private _nav: NavService,
              private route: ActivatedRoute,
              private router: Router) {
  }

  ngOnInit(): void {

    this._nav.navData.subscribe(x => {
      this.headerImage = x.image
      this.headerMessage = x.message
    })

    this.router.events.subscribe((val) => {
      console.log('asdasdasdasd', val)
      if (val instanceof NavigationEnd) {

        if (val.url == '/') {
          let data = {
            message: 'MUSLIMAH STREET APPAREL',
            image: './assets/bannerIndex.jpg'
          }
          this._nav.navData.next(data)
        }

        if (val.url == '/enlightment') {
          let data = {
            message: 'test edestinytiesnt',
            image: './assets/bannerIndex.jpg'
          }
          this._nav.navData.next(data)
        }

        if (val.url == '/lifestyle') {
          let data = {
            message: 'test edestinytiesnt',
            image: './assets/bannerIndex.jpg'
          }
          this._nav.navData.next(data)
        }

      }
    });
  }
}
