import { Routes } from '@angular/router';
import { AnimeComponent } from './components/admin/anime/anime.component';
import { CreateComponent } from './components/admin/anime/create/create.component';

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
  {
    path: 'animes/create',
    component: CreateComponent
  }
];
