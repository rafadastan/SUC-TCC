import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';

import { RouterModule, Routes } from '@angular/router';
import { MainSiteComponent } from './main-site/main-site.component';

const appRoutes : Routes = [
  {
    path: '', component: MainSiteComponent,
    children: [{path: 'login', component: LoginComponent}]
  }
];

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    MainSiteComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
