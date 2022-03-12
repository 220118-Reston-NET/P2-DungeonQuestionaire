import { Component, OnInit } from '@angular/core';
import { Enemy } from '../models/enemy.model';
import { FrontEndService } from '../Services/front-end.service';

@Component({
  selector: 'app-enemy-box',
  templateUrl: './enemy-box.component.html',
  styleUrls: ['./enemy-box.component.css']
})
export class EnemyBoxComponent implements OnInit {
  enemyName:string = "(enemyname)";
  enemyHealth:number = 5;
  enemyAttack:number = 1;
  enemySpriteImgUrl:string = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUqZyg896rd_E6YEm-Ghk4FnON2imS2PbHPg&usqp=CAU";
  enemyCurrentlyFighting:number = 0;

  listofEnemies:Enemy[];
  constructor(private enemyServ:FrontEndService) { 

    this.listofEnemies = [];
  }

  ngOnInit(): void {

    this.enemyServ.getAllEnemies().subscribe(result =>{
      
      this.listofEnemies = result;
    
      this.loadEnemyInfo();
      this.setSessionAttack();
      this.setSessionEnemyName();
      this.setSessionHealth();

    })
  }

  loadEnemyInfo(): void {

    this.enemyName = this.listofEnemies[0].enemyName;
    this.enemyHealth = this.listofEnemies[0].enemyStartingHP;
    this.enemyAttack = this.listofEnemies[0].enemyAttack;
    // this.enemySpriteImgUrl = this.listofEnemies[0].enemySpriteImgUrl;
    

  }

  
  setSessionAttack()
  {
    sessionStorage.setItem("enemyAttack", this.enemyAttack.toString() );
  }

  setSessionHealth()
  {
    sessionStorage.setItem("enemyHealth", this.enemyHealth.toString() );
  }

  setSessionEnemyName()
  {
    sessionStorage.setItem("enemyName", this.enemyName.toString() );
  }

  getEnemyCurrentlyFighting()
  {
    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"))
  }


}
