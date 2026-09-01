import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-sidemenu',
  imports: [CommonModule,RouterLink],
  templateUrl: './sidemenu.html',
  styleUrl: './sidemenu.css',
})
export class Sidemenu {
  activeMenu: string | null = null;
  toggleMenu(menu: string) {
    if (this.activeMenu === menu) {
      this.activeMenu = null;
    } else {
      this.activeMenu = menu;
    }
  }
}
