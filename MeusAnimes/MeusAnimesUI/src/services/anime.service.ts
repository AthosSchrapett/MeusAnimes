import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})

export class AnimeService {

  httpClient = inject(HttpClient);

  endpoint: string = `${environment.meusAnimesApi}/Animes`;

  animesGet(): Observable<any> {
    return this.httpClient.get<any>(`${this.endpoint}`);
  }
}
