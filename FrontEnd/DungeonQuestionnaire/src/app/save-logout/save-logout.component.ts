import { Component, OnInit } from '@angular/core';
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
  FilteredPlayerID:number | undefined = 0;

  listofPlayers: Player[];

  constructor(private savelogout:FrontEndService) { 

    this.listofPlayers = [];
    
  }
  
  ngOnInit(): void {
    
    this.savelogout.getAllPlayers().subscribe(result =>{
      this.listofPlayers = result;
      this.setSessionData(); //Just to hard code properties for Testing
      this.getSessionData();
      this.getPlayerDataDB();
      this.setUpdatePlayer();
      
    })
    
  }

getSessionData(){

  this.playerHP = Number(sessionStorage.getItem("playerHP"));
  this.userVictories = Number(sessionStorage.getItem("userVictories"));
  this.userVictories = 8000;
  this.setSessionData();
  this.userEmail = sessionStorage.getItem("playerEmail");
  this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
  this.spriteURL = (sessionStorage.getItem("spriteURL"));
  this.playerName = (sessionStorage.getItem("playerName"));

}

setSessionData()
{
  sessionStorage.setItem("playerEmail", "someone@here.com")
  sessionStorage.setItem("spriteURL", "someone@here.com")
}


getPlayerDataDB()
{
  
  this.listofPlayers = this.listofPlayers.filter(x => x.userEmail == this.userEmail);
  console.log(this.listofPlayers);
  console.log(this.FilteredPlayerID);
  this.FilteredPlayerID = this.listofPlayers[0].playerID;
  this.userPassword = this.listofPlayers[0].userPassword;
  console.log(this.FilteredPlayerID);
}

setUpdatePlayer()
{
  let PlayerUpdateObject: Player = {

    playerID : this.FilteredPlayerID,
    playerName : this.playerName,
    spriteURL : this.spriteURL,
    playerHP : this.playerHP,
    userEmail : this.userEmail,
    userPassword : this.userPassword,
    userVictories : this.userVictories,
    enemyCurrentlyFighting : this.enemyCurrentlyFighting,
    
  };
  
  this.savelogout.updatePlayer(PlayerUpdateObject).subscribe(result => console.log(result));

}


}
