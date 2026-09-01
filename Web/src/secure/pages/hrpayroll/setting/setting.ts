import { ChangeDetectorRef, Component } from '@angular/core';
import { Alert } from '../../../../app/commonservices/alert';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-setting',
  imports: [RouterLink],
  templateUrl: './setting.html',
  styleUrl: './setting.css',
})
export class Setting {
  isform: boolean = false;
  btnname: string = "Add New Record";
  isButtonDisabled: boolean = false;
  constructor(private alert: Alert, private cdr: ChangeDetectorRef) { }

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
