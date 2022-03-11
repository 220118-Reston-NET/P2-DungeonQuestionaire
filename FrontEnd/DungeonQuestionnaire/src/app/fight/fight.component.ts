import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-fight',
  templateUrl: './fight.component.html',
  styleUrls: ['./fight.component.css']
})
export class FightComponent implements OnInit {

  enemyName:string ="(enemyname)";
  enemyCurrentlyFighting:number = 0;
  enemyMaxId:number = 8;
  
  constructor() { }

  ngOnInit(): void {
  }

}
