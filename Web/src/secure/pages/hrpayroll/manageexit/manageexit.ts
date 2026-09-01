import { ChangeDetectorRef, Component } from '@angular/core';
import { Alert } from '../../../../app/commonservices/alert';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-manageexit',
  imports: [RouterLink],
  templateUrl: './manageexit.html',
  styleUrl: './manageexit.css',
})
export class Manageexit {
  isform: boolean = false;
  isdisplayemployeegrid: boolean = false;
  isdisplayemployeedetails: boolean = false;
  monthlyleave: number = 0;
  grosssalary: number = 0;
  totaldeductions: number = 0;
  cashinhand: number = 0;
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
  Search(): void {
    this.isdisplayemployeegrid = true;
  }
  markexists(): void {
    this.isdisplayemployeedetails = true;
  }
}
