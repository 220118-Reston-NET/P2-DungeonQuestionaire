import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Player } from '../models/player.models';
import { FrontEndService } from '../Services/front-end.service';

@Component({
  selector: 'app-save-logout',
  templateUrl: './save-logout.component.html',
  styleUrls: ['./save-logout.component.css']
})
export class SaveLogoutComponent implements OnInit {
  playerID: number = 0;
  playerName: string  = "";
  playerHP: number = 0;
  enemyCurrentlyFighting: number = 0;
  userEmail: string  = "";
  userPassword: string  = "";
  userVictories: number = 0;
  spriteURL: string  = "";

 viewSpriteURL:string =""

  listofPlayers: Player[];

  constructor(private savelogout:FrontEndService, private router:Router) { 

    this.listofPlayers = [];
    
  }
  
  ngOnInit(): void {
   
      this.getSessionData();
      this.setUpdatePlayer();
    
  }

getSessionData(){

  this.playerHP = Number(sessionStorage.getItem("playerHP"));
  this.userVictories = Number(sessionStorage.getItem("userVictories"));
  this.userEmail = sessionStorage.getItem("userEmail");
  this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
  this.spriteURL = (sessionStorage.getItem("spriteURL"));
  this.viewSpriteURL = sessionStorage.getItem("viewSpriteURL");

}


setUpdatePlayer()
{

  this.savelogout.updatePlayer(this.spriteURL, this.playerHP, this.enemyCurrentlyFighting, this.userEmail, this.userVictories).subscribe(result => console.log(result));
  

}

goToHome()
{
  sessionStorage.clear();
  this.router.navigate(["/login"])
}

}
