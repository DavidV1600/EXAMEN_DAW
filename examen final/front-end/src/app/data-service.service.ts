import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private baseUrl = 'https://localhost:7070/api/School';//ruta controlere

  constructor(private http: HttpClient) { }

  getProfesori(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/profesori`);
  }

  getMaterii(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/materii`);
  }
}
