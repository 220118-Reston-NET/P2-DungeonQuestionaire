import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

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

  constructor(private router:Router) { }

  menuLabel = "";
  ngOnInit(): void {
  
  }

  addPlayer(playerGroup:FormGroup)
  {
      
  }


  goToLogin()
  {
    this.router.navigate(["/login"]);
    this.menuLabel = "Sign up(Main Menu)";
  }
}
