import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { FightComponent } from './fight/fight.component';
import { SaveLogoutComponent } from './save-logout/save-logout.component';
import { WinnerPageComponent } from './winner-page/winner-page.component';
import { GameOverComponent } from './game-over/game-over.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FooterComponent } from './footer/footer.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    FightComponent,
    SaveLogoutComponent,
    WinnerPageComponent,
    GameOverComponent,
    NavBarComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    FontAwesomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
