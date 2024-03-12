import { Component, OnInit, inject } from '@angular/core';
import { AnimeService } from '../../../../services/anime.service';
import { Anime } from '../../../models/anime.model';

@Component({
  selector: 'app-anime',
  standalone: true,
  imports: [],
  templateUrl: './anime.component.html',
  styleUrl: './anime.component.scss'
})

export class AnimeComponent implements OnInit {

  animeService = inject(AnimeService);
  animes: Anime[] = [];

  ngOnInit(): void {
    this.animeService.animesGet().subscribe({
      next: (res: Anime[]) => {
        this.animes = res;
      },
      error: (e) => {
        console.error(e);
      },
      complete: () => {

      }
    });
  }

}
