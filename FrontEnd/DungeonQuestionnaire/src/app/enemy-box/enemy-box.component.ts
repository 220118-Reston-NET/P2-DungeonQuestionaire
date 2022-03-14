import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
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
  currentEnemyHP:number= this.enemyHealth;
  @Output()
  ECFEmitter = new EventEmitter<number>();


  
  

  ngOnInit(): void {

    this.enemyServ.getAllEnemies().subscribe(result =>{
      this.listofEnemies = result;
      this.getEnemyCurrentlyFighting();
      this.loadEnemyInfo(this.enemyCurrentlyFighting);
      this.setSessionAttack();
      this.setSessionEnemyName();
      this.setSessionHealth();
      })
      this.getSessionEnemyHealth();
    
  }

  ngOnChanges(changes: SimpleChanges): void {
  this.enemyHealth = this.currentEnemyHP;
  if (this.enemyHealth <= 0) {
    this.enemyServ.getAllEnemies().subscribe(result =>{
    this.listofEnemies = result;
    this.getEnemyCurrentlyFighting();
    this.loadEnemyInfo(this.enemyCurrentlyFighting);
    this.setSessionHealth();
    this.setSessionEnemyName();
    this.setSessionAttack();
    this.ECFEmitter.emit(this.enemyCurrentlyFighting);
    })
  }

  }

  loadEnemyInfo(ecf:number): void {
    this.enemyName = this.listofEnemies[ecf-1].enemyName;
    this.enemyHealth = this.listofEnemies[ecf-1].enemyStartingHP;
    this.enemyAttack = this.listofEnemies[ecf-1].enemyAttack;
    this.enemySpriteImgUrl = this.listofEnemies[ecf-1].enemySpriteURL;
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
    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));
  }

  getSessionEnemyHealth()
  {
    this.enemyHealth = Number(sessionStorage.getItem("enemyHealth"));
  }

}
