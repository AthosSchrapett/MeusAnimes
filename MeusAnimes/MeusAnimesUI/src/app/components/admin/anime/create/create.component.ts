import { Component, inject } from '@angular/core';
import { AnimeService } from '../../../../../services/anime.service';
import { Anime } from '../../../../models/anime.model';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-create',
  standalone: true,
  imports: [
    FormsModule
  ],
  templateUrl: './create.component.html',
  styleUrl: './create.component.scss'
})

export class CreateComponent {

  animeService = inject(AnimeService);
  anime: Anime = new Anime();

  createAnime(): void {
    this.animeService.animePost(this.anime).subscribe({
      next: (res) => {
      },
      error: (e) => {
        console.error(e);
      },
      complete: () => {
      }
    });
  }

}
