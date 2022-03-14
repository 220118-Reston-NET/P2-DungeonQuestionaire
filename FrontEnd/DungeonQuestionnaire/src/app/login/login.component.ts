import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { delay } from 'rxjs';
import { Player } from '../models/player.models';
import { FrontEndService } from '../Services/front-end.service';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  menuLabel = "";
  playerEmail: string = "test@email.com";
  playerPassword: string = "default";
  listOfPlayers: Player[];

  constructor(private router: Router, private frontEndServ: FrontEndService) {

    this.listOfPlayers = [];
  }

  @Input()
  email: string = "";
  @Input()
  password: string = "";


  ngOnInit(): void {

    // this.setSessionStoragePlayerEmail();
  }

  loginValidation() {
    this.playerEmail = this.email;
    this.playerPassword = this.password;
    this.frontEndServ.getAllPlayers().subscribe(result => {
      this.listOfPlayers = result;

      if (this.listOfPlayers.find(x => x.userEmail == this.playerEmail && x.userPassword == this.playerPassword)) {

        this.setSessionStoragePlayerEmail();
        this.router.navigate(["/fight"]);
  
      } else {
  
        alert("Email or Password was invalid");
      }
  
    })
    
    
  }


  goToSignUp() {
    this.router.navigate(["/signup"]);
    this.menuLabel = "Sign up(Main Menu)";
  }

  setSessionStoragePlayerEmail() {

    sessionStorage.setItem("userEmail", this.playerEmail);
  }

}
