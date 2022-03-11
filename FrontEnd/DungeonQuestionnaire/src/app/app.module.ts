import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import { FightComponent } from './fight/fight.component';
import { SaveLogoutComponent } from './save-logout/save-logout.component';
import { WinnerPageComponent } from './winner-page/winner-page.component';
import { GameOverComponent } from './game-over/game-over.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FooterComponent } from './footer/footer.component';
import { UpgradetextComponent } from './upgradetext/upgradetext.component';
import { NewSpriteChoiceComponent } from './new-sprite-choice/new-sprite-choice.component';
import { PlayAgainComponent } from './play-again/play-again.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { QuestionsAnswersComponent } from './questions-answers/questions-answers.component';
import { PlayerBoxComponent } from './player-box/player-box.component';
import { EnemyBoxComponent } from './enemy-box/enemy-box.component';
import { RouterModule } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';

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
    FooterComponent,
    UpgradetextComponent,
    NewSpriteChoiceComponent,
    PlayAgainComponent,
    QuestionsAnswersComponent,
    PlayerBoxComponent,
    EnemyBoxComponent,
    HomepageComponent
  ],
  imports: [
    BrowserModule,
    FontAwesomeModule,
    RouterModule.forRoot([
      {path: "login", component: LoginComponent},
      {path: "signup", component: SignupComponent},
      {path: "logout", component: SaveLogoutComponent},
      {path: "fight", component: FightComponent},
      {path: "winner", component: WinnerPageComponent},
      {path: "gameover", component: GameOverComponent},
      {path: "", component: HomepageComponent}, //Default component you want to show
      {path: "**", component:HomepageComponent}
    ]),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
