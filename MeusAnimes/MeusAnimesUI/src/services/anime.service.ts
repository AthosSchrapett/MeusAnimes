import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { Anime } from '../app/models/anime.model';

@Injectable({
  providedIn: 'root'
})

export class AnimeService {

  httpClient = inject(HttpClient);

  endpoint: string = `${environment.meusAnimesApi}/Animes`;

  animesGet(): Observable<Anime[]> {
    return this.httpClient.get<Anime[]>(`${this.endpoint}`);
  }

  animePost(anime: Anime): Observable<Anime> {
    return this.httpClient.post<Anime>(`${this.endpoint}`, anime);
  }
}
