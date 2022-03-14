import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-upgradetext',
  templateUrl: './upgradetext.component.html',
  styleUrls: ['./upgradetext.component.css']
})
export class UpgradetextComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  redeem(){
    this.router.navigate(["/reward"])
  }

  logout(){
    sessionStorage.clear();
    this.router.navigate(["/login"]);

  }
  }

