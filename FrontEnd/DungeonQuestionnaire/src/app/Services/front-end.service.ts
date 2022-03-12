import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class FrontEndService {

  constructor(private http:HttpClient) { }

  getAllQuestions(): Observable<any[]>
  {
    return this.http.get<any[]>("https://dungeonapi.azurewebsites.net/api/Question/GetAllQuestions");
  }
  
}
