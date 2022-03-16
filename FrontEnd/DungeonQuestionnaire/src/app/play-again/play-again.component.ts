import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { delay } from 'rxjs';
import { Player } from '../models/player.models';
import { FrontEndService } from '../Services/front-end.service';

@Component({
  selector: 'app-play-again',
  templateUrl: './play-again.component.html',
  styleUrls: ['./play-again.component.css']
})
export class PlayAgainComponent implements OnInit {
  playerID: number = 0;
  playerName: string  = "";
  playerHP: number = 0;
  enemyCurrentlyFighting: number = 0;
  userEmail: string  = "";
  userPassword: string  = "";
  userVictories: number = 0;
  spriteURL: string  = "";
  listofPlayers: Player[];
  constructor(private savelogout:FrontEndService, private router:Router) { 

    this.listofPlayers = [];
    
  }

  ngOnInit(): void {
  }

  // runs all functions needed to reset char data and update to db
  changeToPlayAgain(){
    this.getResetData();
    this.setUpdatePlayer();
    this.clearLocal();
    delay(500);
    this.router.navigate(["/fight"]);
  }

  goBackToLoginPage(){
    sessionStorage.clear();
    this.router.navigate(["/login"]);

  }

  // gets and sets the reset data we will use to play again
  getResetData(){
    this.playerHP = 40;
    this.userVictories = Number(sessionStorage.getItem("userVictories"));
    this.userEmail = sessionStorage.getItem("userEmail");
    this.enemyCurrentlyFighting = 1;
    this.spriteURL = (sessionStorage.getItem("spriteURL"));
  }
  
  // api call to update player to play again
  setUpdatePlayer()
  {
    this.savelogout.updatePlayer(this.spriteURL, this.playerHP, this.enemyCurrentlyFighting, this.userEmail, this.userVictories).subscribe(result => console.log(result));
  }
  
  // this is needed to ensure the reloads on the fight page happen
  clearLocal(){
    localStorage.clear();
  }

}
