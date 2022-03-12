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
  playerSpriteUrl: string = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUqZyg896rd_E6YEm-Ghk4FnON2imS2PbHPg&usqp=CAU"

  listOfPlayers: Player[];

  constructor(private frontEndServ: FrontEndService) {
    //getAllPlayers() method gives an observable that has a subscibe method to start the http request and then handle x amount of responses
    this.listOfPlayers = [];
  };


  ngOnInit(): void {

    this.frontEndServ.getAllPlayers().subscribe(result => {
      //the result of a response is then stored in our listOfPlayers Property
      this.listOfPlayers = result;
      console.log(this.listOfPlayers);
    })
  }

  loadPlayerInfo(): void { }

}


