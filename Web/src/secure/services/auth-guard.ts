import { Injectable, inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { CanActivate, Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  private platformId = inject(PLATFORM_ID);

  constructor(private router: Router) {}

  canActivate(): boolean {

    if (!isPlatformBrowser(this.platformId)) {
      return false;
    }

    const token = localStorage.getItem('token');

    if (token) {
      return true;
    }

    this.router.navigate(['/login']);
    return false;
  }
}