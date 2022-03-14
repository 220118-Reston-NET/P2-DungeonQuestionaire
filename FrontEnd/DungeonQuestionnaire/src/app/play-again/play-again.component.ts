import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-play-again',
  templateUrl: './play-again.component.html',
  styleUrls: ['./play-again.component.css']
})
export class PlayAgainComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  changeToPlayAgain(){
    this.router.navigate(["/fight"]);
    // this can take us to a reset stats and update player, then back to fight page.

  }

  goBackToLoginPage(){
    sessionStorage.clear();
    this.router.navigate(["/login"]);

  }

}
