import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterOutlet } from '@angular/router';
import { Sidemenu } from '../sidemenu/sidemenu';
import { Alert } from '../../../app/commonservices/alert';

@Component({
  selector: 'app-securelayout',
  standalone: true,
  imports: [
    CommonModule,
    RouterOutlet,
    Sidemenu
  ],
  templateUrl: './securelayout.html',
  styleUrl: './securelayout.css',
})
export class Securelayout {
  isPopupOpen=false;
  popupType='';
  popupTitle='';
  constructor(
    private alert: Alert,
    private router: Router
  ) {}
  logout() {
    this.alert.logout().then((result) => {
      if (result.isConfirmed) {
        localStorage.removeItem('token');
        this.router.navigate(['/login']);
        this.alert.success('You are logout successfully.');
      }
    });
  }
  openPopup(type:string){
    this.popupType=type;
    this.isPopupOpen=true;
    document.body.style.overflow='hidden';
    switch(type){
        case 'help':
            this.popupTitle='Help';
            break;
        case 'terms':
            this.popupTitle='Terms & Conditions';
            break;
        case 'privacy':
            this.popupTitle='Privacy Policy';
            break;
    }
  }
  closePopup(){
    this.isPopupOpen=false;
    document.body.style.overflow='auto';
  }
}