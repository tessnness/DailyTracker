import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class TrackerService {

  private baseUrl = 'http://localhost:4200/api/tracker'; // Update the port if needed

  constructor(private http: HttpClient) { }

  getTracker(): Observable<any> {
    return this.http.get(this.baseUrl);
  }
}
