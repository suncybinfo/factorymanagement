import { ChangeDetectorRef, Component } from '@angular/core';
import { Alert } from '../../../../app/commonservices/alert';

@Component({
  selector: 'app-unitmaster',
  imports: [],
  templateUrl: './unitmaster.html',
  styleUrl: './unitmaster.css',
})
export class Unitmaster {
  isform: boolean = false;
  btnname: string = "Add New Record";
  isButtonDisabled: boolean = false;
  constructor(private alert: Alert,private cdr: ChangeDetectorRef) { }

  addRecord(): void {
    this.isform = true;
    this.isButtonDisabled = true;
  }
  closedForm(): void {
    this.alert.confirm('Closed', 'Are You Sure You Want to Close the Form?').then((result) => {
      if (result.isConfirmed) {
        this.isform = false;
        this.isButtonDisabled = false;
        this.cdr.detectChanges();
      }
    });
  }
}
