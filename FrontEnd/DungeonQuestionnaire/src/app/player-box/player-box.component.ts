import { Component, OnInit } from '@angular/core';
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
  playerSpriteUrl: string = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUqZyg896rd_E6YEm-Ghk4FnON2imS2PbHPg&usqp=CAU";
  enemyCurrentlyFighting: number = 0;
  userVictories: number = 0;

  listOfPlayers: Player[];

  constructor(private frontEndServ: FrontEndService) {
    //getAllPlayers() method gives an observable that has a subscibe method to start the http request and then handle x amount of responses
    this.listOfPlayers = [];
  };


  ngOnInit(): void {

    this.frontEndServ.getAllPlayers().subscribe(result => {
      //the result of a response is then stored in our listOfPlayers Property
      this.listOfPlayers = result;

      this.loadPlayerInfo();

      this.setSessionStoragePlayerHP();
      this.setSessionStorageEnemyCurrentlyFighting();
    })
  }
  //***Will need to be changed to a filtered listOfPlayers where user email = the one that was provided***
  loadPlayerInfo(): void {

    this.playerName = this.listOfPlayers[0].playerName;

    this.playerHealth = this.listOfPlayers[0].playerHP;

    // this.playerSpriteUrl = this.listOfPlayers[0].SpriteURL;
    this.enemyCurrentlyFighting = this.listOfPlayers[0].enemyCurrentlyFighting;
    this.userVictories = this.listOfPlayers[0].userVictories;

  }

  filterPlayerInfoByEmail() {


  }

  setSessionStoragePlayerHP() {

    sessionStorage.setItem("playerHP", this.playerHealth.toString());
  }

  setSessionStorageEnemyCurrentlyFighting() {

    sessionStorage.setItem("enemyCurrentlyFighting", this.enemyCurrentlyFighting.toString());
  }

}


