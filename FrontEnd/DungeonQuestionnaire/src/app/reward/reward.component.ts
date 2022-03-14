import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Player } from '../models/player.models';
import { FrontEndService } from '../Services/front-end.service';

@Component({
  selector: 'app-reward',
  templateUrl: './reward.component.html',
  styleUrls: ['./reward.component.css']
})
export class RewardComponent implements OnInit {
  playerName: string  = "";
  playerHP: number = 0;
  enemyCurrentlyFighting: number = 0;
  userEmail: string  = "";
  userPassword: string  = "";
  userVictories: number = 0;
  spriteURL: string  = "";
  listofPlayers: Player[];
  constructor(private router:Router, private frontEndServ:FrontEndService) { }

  ngOnInit(): void {
  }

  getSessionData(){

    this.playerHP = Number(sessionStorage.getItem("playerHP"));
    this.userVictories = Number(sessionStorage.getItem("userVictories"));
    this.userEmail = sessionStorage.getItem("userEmail");
    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
    this.spriteURL = (sessionStorage.getItem("spriteURL"));
  
  }

  setUpdatePlayer()
  {
    this.frontEndServ.updatePlayer(this.spriteURL, this.playerHP, this.enemyCurrentlyFighting, this.userEmail, this.userVictories).subscribe(result => console.log(result));
  }
}
