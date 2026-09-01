import { Injectable, Service } from '@angular/core';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root'
})
export class Alert {
  success(message: string) {
    Swal.fire('Success', message, 'success');
  }
  error(message: string) {
    Swal.fire('Error', message, 'error');
  }

  warning(message: string) {
    Swal.fire('Warning', message, 'warning');
  }

  info(message: string) {
    Swal.fire('Info', message, 'info');
  }
  confirm(title: string, message: string) {
    return Swal.fire({
      title,
      text: message,
      icon: 'question',
      showCancelButton: true,
      confirmButtonText: 'Yes',
      cancelButtonText: 'No'
    });
  }
  logout() {
    return Swal.fire({
      title: 'Logout',
      text: 'Are you sure you want to logout?',
      icon: 'question',
      showCancelButton: true,
      confirmButtonText: 'Yes, Logout',
      cancelButtonText: 'Cancel',
      reverseButtons: true
    });
  }
}
