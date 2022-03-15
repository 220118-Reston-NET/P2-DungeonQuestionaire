import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Player } from '../models/player.models';

@Component({
  selector: 'app-upgradetext',
  templateUrl: './upgradetext.component.html',
  styleUrls: ['./upgradetext.component.css']
})
export class UpgradetextComponent implements OnInit {
  playerName: string  = "";
  playerHP: number = 0;
  enemyCurrentlyFighting: number = 0;
  userEmail: string  = "";
  userPassword: string  = "";
  userVictories: number = 0;
  spriteURL: string  = "";
  viewSpriteURL: string = "";
  listofPlayers: Player[];
  constructor( private router: Router) { }

  ngOnInit(): void {
    this.getSessionData();
    this.changeSpriteImageOnPage();

    
  }

  getSessionData(){

    this.playerHP = Number(sessionStorage.getItem("playerHP"));
    this.userVictories = Number(sessionStorage.getItem("userVictories"));
    this.userEmail = sessionStorage.getItem("userEmail");
    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
    this.spriteURL = (sessionStorage.getItem("spriteURL"));
    this.viewSpriteURL = (sessionStorage.getItem("viewSpriteURL"));
  
  }

  changeSpriteImageOnPage() {
    if(this.userVictories==1 && this.spriteURL== "Male"){
      this.viewSpriteURL = "../assets/images/Male-1.png";
      this.setSessionViewSpriteURL();
    }
    else if (this.userVictories==2 && this.spriteURL== "Male"){
      this.viewSpriteURL = "../assets/images/Male-2.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==3 && this.spriteURL== "Male"){
      this.viewSpriteURL = "../assets/images/Male-3.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories>=4 && this.spriteURL== "Male"){
      this.viewSpriteURL = "../assets/images/Male-4.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==1 && this.spriteURL== "Female"){
      this.viewSpriteURL = "../assets/images/Female-1.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==2 && this.spriteURL== "Female"){
      this.viewSpriteURL = "../assets/images/Female-2.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==3 && this.spriteURL== "Female"){
      this.viewSpriteURL = "../assets/images/Female-3.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories>=4 && this.spriteURL== "Female"){
      this.viewSpriteURL = "../assets/images/Female-4.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories == 0 && this.spriteURL== "Male"){
      this.viewSpriteURL = "../assets/images/Male-0.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories == 0 && this.spriteURL== "Female"){
      this.viewSpriteURL = "../assets/images/Female-0.png";
      this.setSessionViewSpriteURL();

    }else{
    this.viewSpriteURL = this.spriteURL;
    this.setSessionViewSpriteURL();
    }
  }

  setSessionViewSpriteURL()
  {
    sessionStorage.setItem("viewSpriteURL", this.viewSpriteURL);
  }

  

  
}
