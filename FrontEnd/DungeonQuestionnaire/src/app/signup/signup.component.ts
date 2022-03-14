import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Player } from '../models/player.models';
import { FrontEndService } from '../Services/front-end.service';


@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']

})
export class SignupComponent implements OnInit {
//only add to the form group if you updated the signup page
  playerGroup = new FormGroup ({
    name: new FormControl(""),
    playerHp: new FormControl(40),
    enemyFight: new FormControl(1),
    email: new FormControl("someone@here.com"),
    password: new FormControl(""),
    userVictories: new FormControl(0),
    spriteURL: new FormControl("testurl")
  });

  constructor(private router:Router, private playerServ:FrontEndService) { }

  menuLabel = "";

 
  ngOnInit(): void {
  
  }

  addPlayer(p_playerGroup:FormGroup)
  {
      let player:Player = 
      {
        
        playerName:p_playerGroup.get("name")?.value,
        spriteURL: p_playerGroup.get("spriteURL")?.value,
        playerHP: p_playerGroup.get("playerHp")?.value,
        userEmail: p_playerGroup.get("email")?.value,
        userPassword: p_playerGroup.get("password")?.value,
        userVictories: p_playerGroup.get("userVictories")?.value,
        enemyCurrentlyFighting: p_playerGroup.get("enemyFight")?.value,
      }
      console.log(player);

      this.playerServ.addPlayer(player).subscribe(result => console.log(result));

      
  }


  goToLogin()
  {
    this.router.navigate(["/login"]);
    this.menuLabel = "Sign up(Main Menu)";
  }
}
