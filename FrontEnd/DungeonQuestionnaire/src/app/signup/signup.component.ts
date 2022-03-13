import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
// import { endianness } from 'os';
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
    email: new FormControl("someone@here.com"),
    password: new FormControl(""),
  });

  constructor(private router:Router, private playerServ:FrontEndService) { }

  menuLabel = "";
  ngOnInit(): void {
  
  }

  addPlayer(playerGroup:FormGroup)
  {
      let player:Player = 
      {
        PlayerName: playerGroup.get("name")?.value,
        UserEmail: playerGroup.get("emial")?.value,
        UserPassword: playerGroup.get("password")?.value
      }

      this.playerServ.addPlayer(player).subscribe(result => console.log(result));
  }


  goToLogin()
  {
    this.router.navigate(["/login"]);
    this.menuLabel = "Sign up(Main Menu)";
  }
}
