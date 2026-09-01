import { ChangeDetectorRef, Component } from '@angular/core';
import { Alert } from '../../../../app/commonservices/alert';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-employeeonboard',
  imports: [RouterLink],
  templateUrl: './employeeonboard.html',
  styleUrl: './employeeonboard.css',
})
export class Employeeonboard {
  isform: boolean = false;
  isdisplayemployeegrid: boolean = false;
  isdisplayemployeedetails: boolean = false;
  btnname: string = "Add New Record";
  isButtonDisabled: boolean = false;
  grosssalary: number = 0;
  totaldeductions: number = 0;
  cashinhand: number = 0;
  monthlyleave: number = 0;
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
  onboardingemployeedetails(): void {
    this.isdisplayemployeedetails = true;
    this.isdisplayemployeegrid = false;
    this.isform = false;
  }
}
