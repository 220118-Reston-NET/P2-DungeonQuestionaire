import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-player-box',
  templateUrl: './player-box.component.html',
  styleUrls: ['./player-box.component.css']
})
export class PlayerBoxComponent implements OnInit {

  playerName:string = "(name)";
  playerHealth:number = 40;
  playerSpriteUrl:string = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUqZyg896rd_E6YEm-Ghk4FnON2imS2PbHPg&usqp=CAU"

  constructor() { }

  ngOnInit(): void {
  }

}
