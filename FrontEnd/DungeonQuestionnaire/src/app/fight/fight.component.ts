import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { delay } from 'rxjs';

@Component({
  selector: 'app-fight',
  templateUrl: './fight.component.html',
  styleUrls: ['./fight.component.css']
})
export class FightComponent implements OnInit {

  enemyName:string | null ="(enemyname)";
  enemyCurrentlyFighting:number = 0;
  enemyMaxId:number = 8;
  currentPlayerHP:number = 0;
  currentEnemyHP:number = 0;


  constructor(private router:Router) {
    
   }
   


  // gets the session storage so that interpolation has correct values
  ngOnInit(): void {

    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
    this.enemyName = sessionStorage.getItem("enemyName");
    // first refresh to update the children
    if(!localStorage.getItem("reload"))
    window.location.reload()
    this.router.navigate(["/fight"])
    .then(() => {
      localStorage.setItem("reload", "1")
    });
    // delay needed to fully load the children
    delay(1000);
    //second refresh to update the fight html interpolations
    if(!localStorage.getItem("refresh"))
    window.location.reload()
    this.router.navigate(["/fight"])
    .then(() => {
      localStorage.setItem("refresh", "1")
    });

  }

  ngonchanges(){

  }

// updated by the eventEmitters from the children
  HPEventWasTriggered(hp:number){
    this.currentPlayerHP = hp;

  }

  EnemyEventWasTriggered(hp:number){
    this.currentEnemyHP = hp;

  }

  ChangeStats(){
    this.getSessionEnemyCurrentlyFighting();
    this.getSessionEnemyName();
  }

  getSessionEnemyCurrentlyFighting(){
    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
  }

  getSessionEnemyName(){
    this.enemyName = sessionStorage.getItem("enemyName");
  }

// updated by the eventEmitter from the child
changeECF(ecf:number){
    this.enemyCurrentlyFighting = ecf;
    this.getSessionEnemyName;
  }


}
