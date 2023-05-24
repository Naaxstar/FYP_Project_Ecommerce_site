import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthorizeGuard } from '../api-authorization/authorize.guard';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { TodoComponent } from './todo/todo.component';
import { TokenComponent } from './token/token.component';
import {EnlightmentComponent} from "./enlightment/enlightment.component";
import {InformationComponent} from "./information/information.component";
import {LifestyleComponent} from "./lifestyle/lifestyle.component";
import {DressComponent} from "./dress/dress.component";
import {BajukurungComponent} from "./bajukurung/bajukurung.component";
import {HijabComponent} from "./hijab/hijab.component";
import {ServicesComponent} from "./services/services.component";

export const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'enlightment', component: EnlightmentComponent  },
  { path: 'information', component: InformationComponent},
  { path: 'lifestyle', component: LifestyleComponent},
  { path: 'dress', component: DressComponent},
  { path: 'bajukurung', component: BajukurungComponent},
  { path: 'hijab', component: HijabComponent},
  { path: 'services', component: ServicesComponent },
  { path: 'fetch-data', component: FetchDataComponent },
  { path: 'todo', component: TodoComponent, canActivate: [AuthorizeGuard] },
  { path: 'token', component: TokenComponent, canActivate: [AuthorizeGuard] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
