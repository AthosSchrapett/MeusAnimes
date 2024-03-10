import { Routes } from '@angular/router';
import { AnimeComponent } from './components/admin/anime/anime.component';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'animes',
    pathMatch: 'full'
  },
  {
    path: 'animes',
    component: AnimeComponent
  },
];
