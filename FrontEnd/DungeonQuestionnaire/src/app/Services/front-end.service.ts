import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
<<<<<<< Updated upstream

=======
import { Player } from '../models/player.models';
>>>>>>> Stashed changes

@Injectable({
  providedIn: 'root'
})
export class FrontEndService {

<<<<<<< Updated upstream
  constructor(private http:HttpClient) { }

  getAllQuestions(): Observable<any[]>
  {
    return this.http.get<any[]>("https://dungeonapi.azurewebsites.net/api/Question/GetAllQuestions");
  }
  
=======
  constructor(private http: HttpClient) { }

  getAllPlayers(): Observable<Player[]> {


    return this.http.get<Player[]>("https://dungeonapi.azurewebsites.net/api/Player/GetAllPlayers");
  }
>>>>>>> Stashed changes
}
