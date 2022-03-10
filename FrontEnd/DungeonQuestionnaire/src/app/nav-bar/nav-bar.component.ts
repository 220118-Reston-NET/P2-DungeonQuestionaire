import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.sass']
})
export class NavBarComponent implements OnInit {
  
  menuLabel = "";
  isLogin:boolean = true;
  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  changeVisile(){
    this.isLogin = !this.isLogin;
  }

  goToSignIn()
  {
    this.router.navigate(["/login"]);
    this.menuLabel = "Login(Main Menu)";
  }
  goToSignUp()
  {
    this.router.navigate(["/signup"]);
    this.menuLabel = "Sign up(Main Menu)";
  }

  goToHome()
  {
    this.menuLabel = "Main Menu"
  }
}
