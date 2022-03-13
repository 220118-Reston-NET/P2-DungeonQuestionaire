import { Component, Input, OnInit } from '@angular/core';

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


  constructor() { }


  
  ngOnInit(): void {

    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
    this.enemyName = sessionStorage.getItem("enemyName");

  }

  ngonchanges(){
    this.getSessionEnemyCurrentlyFighting;
    this.getSessionEnemyName;
  }

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


  // Add nother emitter to getEnemyCurrentlyFighting and enemyName from session storage

}
