import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.sass']
})
export class NavBarComponent implements OnInit {
  
  
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
  }
}
