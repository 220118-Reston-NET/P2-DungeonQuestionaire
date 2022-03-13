import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Enemy } from '../models/enemy.model';
import { FrontEndService } from '../Services/front-end.service';

@Component({
  selector: 'app-enemy-box',
  templateUrl: './enemy-box.component.html',
  styleUrls: ['./enemy-box.component.css']
})
export class EnemyBoxComponent implements OnInit, OnChanges {
  enemyName:string = "(enemyname)";
  enemyHealth:number = 5;
  enemyAttack:number = 1;
  enemySpriteImgUrl:string = "https://api.open5e.com/static/img/monsters/bulette.png";
  enemyCurrentlyFighting:number = 0;

  listofEnemies:Enemy[];
  constructor(private enemyServ:FrontEndService) { 

    this.listofEnemies = [];
  }

  @Input()
  currentEnemyHP:number= 0;
  

  ngOnInit(): void {

    this.enemyServ.getAllEnemies().subscribe(result =>{
      
      this.listofEnemies = result;
    
      this.loadEnemyInfo();
      this.setSessionAttack();
      this.setSessionEnemyName();
      this.setSessionHealth();

    })
  }

  ngOnChanges(changes: SimpleChanges): void {
    


    
  }

  loadEnemyInfo(): void {

    this.enemyName = this.listofEnemies[0].enemyName;
    this.enemyHealth = this.listofEnemies[0].enemyStartingHP;
    this.enemyAttack = this.listofEnemies[0].enemyAttack;
    this.enemySpriteImgUrl = this.listofEnemies[0].enemySpriteURL;
    
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
