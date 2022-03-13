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
  playerSpriteUrl: string = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUqZyg896rd_E6YEm-Ghk4FnON2imS2PbHPg&usqp=CAU";
  enemyCurrentlyFighting: number = 0;
  userVictories: number = 0;
  userEmail: string | null = "";
  //userEmail: string | null = "decimater@email.com";
  filteredListOfPlayers: Player[];

  @Input()
  currentPlayerHP: number = 0;


  listOfPlayers: Player[];

  constructor(private frontEndServ: FrontEndService) {
    //getAllPlayers() method gives an observable that has a subscibe method to start the http request and then handle x amount of responses
    this.listOfPlayers = [];
    this.filteredListOfPlayers = [];
  };


  ngOnInit(): void {

    this.frontEndServ.getAllPlayers().subscribe(result => {
      //the result of a response is then stored in our listOfPlayers Property
      this.listOfPlayers = result;
      this.filteredListOfPlayers = result;
      this.setSessionStorageUserEmail();
      this.getSessionStorageUserEmail();
      this.filterPlayerByEmail();
      this.loadPlayerInfo();
      this.setSessionStoragePlayerHP();
      this.currentPlayerHP = this.playerHealth;
      this.setSessionStorageEnemyCurrentlyFighting();
      this.setSessionStoragePlayerName();
      this.setSessionStorageUserVictories();
    })



  }


  filterPlayerByEmail() {
    //let email = this.getSessionStorageUserEmail();

    this.listOfPlayers = this.listOfPlayers.filter(x => x.userEmail == this.userEmail);
  }

  performFilter(filter: string): Player[] {
    let tempListOfPlayer: Player[];

    tempListOfPlayer = this.listOfPlayers.filter((player: Player) => player.userEmail.indexOf(filter) != -1)

    return tempListOfPlayer;
  }

  //***Will need to be changed to a filtered listOfPlayers where user email = the one that was provided***
  loadPlayerInfo(): void {

    this.playerName = this.listOfPlayers[0].playerName;

    this.playerHealth = this.listOfPlayers[0].playerHP;

    // this.playerSpriteUrl = this.listOfPlayers[0].SpriteURL;
    this.enemyCurrentlyFighting = this.listOfPlayers[0].enemyCurrentlyFighting;
    this.userVictories = this.listOfPlayers[0].userVictories;

  }

  setSessionStorageUserEmail() {
    sessionStorage.setItem("userEmail", "decimater@email.com");
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

  getSessionStoragePlayerHP() {
    this.playerHealth = Number(sessionStorage.getItem("playerHP"));
  }

  getSessionStorageEnemyCurrentlyFighting() {
    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
  }






}




