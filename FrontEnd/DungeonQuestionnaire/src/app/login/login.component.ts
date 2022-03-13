import { Component, Input, OnInit } from '@angular/core';
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
  playerPassword:string = "default";

  constructor(private router: Router) { }

  @Input()
  email:string="";
  @Input()
  password:string="";
  

  ngOnInit(): void {

    this.setSessionStoragePlayerEmail();
  }

  test(){
    this.playerEmail = this.email;
    this.playerPassword = this.password;

    // Compare to database to see if useremail and password exist
    // If match, grab in useremail and set to session storage & reroute to fight page
    // else clear form if no match and give message that it didn't exist


  }

  
  goToSignUp() {
    this.router.navigate(["/signup"]);
    this.menuLabel = "Sign up(Main Menu)";
  }

  setSessionStoragePlayerEmail() {

    sessionStorage.setItem("playerEmail", this.playerEmail);
  }
}
