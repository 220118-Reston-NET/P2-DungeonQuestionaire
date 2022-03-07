import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.sass']
})
export class NavBarComponent implements OnInit {
  
  
  isLogin:boolean = true;
  constructor() { }

  ngOnInit(): void {
  }

  changeVisile(){
    this.isLogin = !this.isLogin;
  }
}
