import { Component, Input, OnInit } from '@angular/core';
import { Player } from '../models/player.models';
import { FrontEndService } from '../Services/front-end.service';

@Component({
  selector: 'app-player-box',
  templateUrl: './player-box.component.html',
  styleUrls: ['./player-box.component.css']
})
export class PlayerBoxComponent implements OnInit {

  playerName: string = "(name)";
  playerHealth: number = 40;
  playerSpriteUrl: string = "";
  enemyCurrentlyFighting: number = 0;
  userVictories: number = 0;
  userEmail: string | null = "";

  viewSpriteURL:string = "";

  @Input()
  currentPlayerHP: number = 0;


  listOfPlayers: Player[];

  constructor(private frontEndServ: FrontEndService) {
    //getAllPlayers() method gives an observable that has a subscibe method to start the http request and then handle x amount of responses
    this.listOfPlayers = [];
  };


  ngOnInit(): void {

    this.frontEndServ.getAllPlayers().subscribe(result => {
      //the result of a response is then stored in our listOfPlayers Property
      this.listOfPlayers = result;
      this.getSessionStorageUserEmail();
      this.filterPlayerByEmail();
      this.loadPlayerInfo();
      this.setSessionStoragePlayerHP();
      this.currentPlayerHP = this.playerHealth;
      this.setSessionStorageEnemyCurrentlyFighting();
      this.setSessionStoragePlayerName();
      this.setSessionStorageUserVictories();
      this.setSessionSpriteURL();
      this.changeSpriteImageOnPage();
      
      this.getSessionSpriteURL();

    })



  }


  filterPlayerByEmail() {
    this.listOfPlayers = this.listOfPlayers.filter(x => x.userEmail == this.userEmail);
  }

  loadPlayerInfo(): void {

    this.playerName = this.listOfPlayers[0].playerName;
    this.playerHealth = this.listOfPlayers[0].playerHP;
    this.playerSpriteUrl = this.listOfPlayers[0].spriteURL;
    this.enemyCurrentlyFighting = this.listOfPlayers[0].enemyCurrentlyFighting;
    this.userVictories = this.listOfPlayers[0].userVictories;

  }

  changeSpriteImageOnPage() {
    if(this.userVictories==1 && this.playerSpriteUrl== "../assets/images/Male-0.png"){
      this.viewSpriteURL = "../assets/images/Male-1.png";
      this.setSessionViewSpriteURL();
    }
    else if (this.userVictories==2 && this.playerSpriteUrl== "../assets/images/Male-0.png"){
      this.viewSpriteURL = "../assets/images/Male-2.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==3 && this.playerSpriteUrl== "../assets/images/Male-0.png"){
      this.viewSpriteURL = "../assets/images/Male-3.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories>=4 && this.playerSpriteUrl== "../assets/images/Male-0.png"){
      this.viewSpriteURL = "../assets/images/Male-4.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==1 && this.playerSpriteUrl== "../assets/images/Female-0.png"){
      this.viewSpriteURL = "../assets/images/Female-1.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==2 && this.playerSpriteUrl== "../assets/images/Female-0.png"){
      this.viewSpriteURL = "../assets/images/Female-2.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories==3 && this.playerSpriteUrl== "../assets/images/Female-0.png"){
      this.viewSpriteURL = "../assets/images/Female-3.png";
      this.setSessionViewSpriteURL();

    }
    else if (this.userVictories>=4 && this.playerSpriteUrl== "../assets/images/Female-0.png"){
      this.viewSpriteURL = "../assets/images/Female-4.png";
      this.setSessionViewSpriteURL();

    }else{
    this.viewSpriteURL = this.playerSpriteUrl;
    this.setSessionViewSpriteURL();
    }
  }

  getSessionStorageUserEmail() {
    this.userEmail = sessionStorage.getItem("userEmail");
  }

  setSessionStoragePlayerHP() {

    sessionStorage.setItem("playerHP", this.playerHealth.toString());
  }

  setSessionStorageEnemyCurrentlyFighting() {

    sessionStorage.setItem("enemyCurrentlyFighting", this.enemyCurrentlyFighting.toString());
  }

  setSessionStorageUserVictories() {
    sessionStorage.setItem("userVictories", this.userVictories.toString());
  }
  
  setSessionStoragePlayerName() {
    sessionStorage.setItem("playerName", this.playerName);
  }

  setSessionSpriteURL()
  {
    sessionStorage.setItem("spriteURL", this.playerSpriteUrl);
  }

  getSessionStoragePlayerHP() {
    this.playerHealth = Number(sessionStorage.getItem("playerHP"));
  }

  getSessionStorageEnemyCurrentlyFighting() {
    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
  }



  getSessionSpriteURL()
  {
    this.viewSpriteURL = sessionStorage.getItem("viewSpriteURL");
  }

  setSessionViewSpriteURL(){
    sessionStorage.setItem("viewSpriteURL", this.viewSpriteURL);
  }



}
