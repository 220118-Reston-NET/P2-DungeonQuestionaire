import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Player } from '../models/player.models';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  menuLabel = "";
  playerEmail: string = "test@email.com";
  constructor(private router: Router) { }

  ngOnInit(): void {

    this.setSessionStoragePlayerEmail();
  }

  
  goToSignUp() {
    this.router.navigate(["/signup"]);
    this.menuLabel = "Sign up(Main Menu)";
  }

  setSessionStoragePlayerEmail() {

    sessionStorage.setItem("playerEmail", this.playerEmail);
  }
}
