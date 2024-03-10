import { CommonModule } from '@angular/common';
import { AfterViewInit, Component } from '@angular/core';

@Component({
  selector: 'app-sidenav',
  standalone: true,
  imports: [
    CommonModule
  ],
  templateUrl: './sidenav.component.html',
  styleUrl: './sidenav.component.scss'
})
export class SidenavComponent {

  showNavbar: boolean = false;
  activeLink = 0;

  toggleNavbar() {
    this.showNavbar = !this.showNavbar;
  }

  setActiveLink(index: number) {
    this.activeLink = index;
  }

}
