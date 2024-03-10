import { Component, OnInit, inject } from '@angular/core';
import { AnimeService } from '../../../../services/anime.service';

@Component({
  selector: 'app-anime',
  standalone: true,
  imports: [],
  templateUrl: './anime.component.html',
  styleUrl: './anime.component.scss'
})

export class AnimeComponent implements OnInit {

  animeService = inject(AnimeService);

  ngOnInit(): void {
    this.animeService.animesGet().subscribe({
      next: (res) => {
        console.log(res);
      },
      error: (e) => {
        console.error(e);
      },
      complete: () => {

      }
    });
  }

}
