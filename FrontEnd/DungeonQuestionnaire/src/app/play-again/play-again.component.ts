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

  changeToPlayAgain(){
    this.getResetData();
    this.setUpdatePlayer();
    delay(500);
    this.router.navigate(["/fight"]);
  }

  goBackToLoginPage(){
    sessionStorage.clear();
    this.router.navigate(["/login"]);

  }

  getResetData(){
    this.playerHP = 40;
    this.userVictories = Number(sessionStorage.getItem("userVictories"));
    this.userEmail = sessionStorage.getItem("userEmail");
    this.enemyCurrentlyFighting = 1;
    this.spriteURL = (sessionStorage.getItem("spriteURL"));
  }
  
  setUpdatePlayer()
  {
    this.savelogout.updatePlayer(this.spriteURL, this.playerHP, this.enemyCurrentlyFighting, this.userEmail, this.userVictories).subscribe(result => console.log(result));
  }
  

}
