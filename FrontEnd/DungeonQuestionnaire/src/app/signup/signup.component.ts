import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  constructor(private router:Router) { }

  menuLabel = "";
  ngOnInit(): void {
  }
  goToLogin()
  {
    this.router.navigate(["/login"]);
    this.menuLabel = "Sign up(Main Menu)";
  }
}
