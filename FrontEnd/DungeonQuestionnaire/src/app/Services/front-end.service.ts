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

  getAllEnemies(): Observable<Enemy[]>
  {
      return this.http.get<Enemy[]>("https://dungeonapi.azurewebsites.net/api/Enemy/GetAllEnemies");

  }

}
