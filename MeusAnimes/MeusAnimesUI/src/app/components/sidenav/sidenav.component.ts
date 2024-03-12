import { CommonModule } from '@angular/common';
import { AfterViewInit, Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-sidenav',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule
  ],
  templateUrl: './sidenav.component.html',
  styleUrl: './sidenav.component.scss'
})
export class SidenavComponent {

  showNavbar: boolean = true;
  activeLink = 0;

  toggleNavbar() {
    this.showNavbar = !this.showNavbar;
  }

  setActiveLink(index: number) {
    this.activeLink = index;
  }

}
