import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-enemy-box',
  templateUrl: './enemy-box.component.html',
  styleUrls: ['./enemy-box.component.css']
})
export class EnemyBoxComponent implements OnInit {
  enemyName:string = "(enemyname)";
  enemyHealth:number = 5;
  enemyAttack:number = 1;
  enemySpriteUrl:string = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUqZyg896rd_E6YEm-Ghk4FnON2imS2PbHPg&usqp=CAU";

  constructor() { }

  ngOnInit(): void {
  }

}
