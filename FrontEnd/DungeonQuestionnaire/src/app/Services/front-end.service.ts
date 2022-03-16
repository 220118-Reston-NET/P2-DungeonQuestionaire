import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Player } from '../models/player.models';
import { Enemy } from '../models/enemy.model';


@Injectable({
  providedIn: 'root'
})
export class FrontEndService {

  constructor(private http: HttpClient) { }

  getAllQuestions(): Observable<any[]> {
    return this.http.get<any[]>("https://dungeonapi.azurewebsites.net/api/Question/GetAllQuestions");
  }

  getAllPlayers(): Observable<Player[]> {

    return this.http.get<Player[]>("https://dungeonapi.azurewebsites.net/api/Player/GetAllPlayers");
  }

  addPlayer(player:Player)
  {
    return this.http.post<Player>("https://dungeonapi.azurewebsites.net/api/Player/AddPlayer",player);
  }
  getAllEnemies(): Observable<Enemy[]>
  {
      return this.http.get<Enemy[]>("https://dungeonapi.azurewebsites.net/api/Enemy/GetAllEnemies");

  }

  updatePlayer(SpriteImgurl:string,PlayerHP:number, enemyCurrentlyFighting:number, UserEmail:string, UserVictories:number)
  {
    let body:any = {SpriteImgurl,PlayerHP, enemyCurrentlyFighting, UserEmail, UserVictories};

    // concatenates a url that we can pass to make an API call for update player
    let url:string = ("https://dungeonapi.azurewebsites.net/api/Player/UpdatePlayer?SpriteImgurl=" + SpriteImgurl + "&PlayerHP=" + PlayerHP + "&EnemyCurrentlyFighting=" + enemyCurrentlyFighting + "&UserEmail=" + UserEmail + "&UserVictories=" + UserVictories)
    console.log(url);
    return this.http.put(url, body);
  }
}
