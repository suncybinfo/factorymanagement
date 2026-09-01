import { Routes } from '@angular/router';
import { Login } from '../public/login/login';
import { Forgotpassword } from '../public/forgotpassword/forgotpassword';
import { Resetpassword } from '../public/resetpassword/resetpassword';
import { Securelayout } from '../secure/layout/securelayout/securelayout';
import { Dashboard } from '../secure/pages/dashboard/dashboard';
import { AuthGuard } from '../secure/services/auth-guard';
import { Companymaster } from '../secure/pages/master/companymaster/companymaster';
import { Branchmaster } from '../secure/pages/master/branchmaster/branchmaster';
import { Plantmaster } from '../secure/pages/master/plantmaster/plantmaster';
import { Unitmaster } from '../secure/pages/master/unitmaster/unitmaster';
import { Warehousemaster } from '../secure/pages/master/warehousemaster/warehousemaster';
import { Departmentmaster } from '../secure/pages/master/departmentmaster/departmentmaster';
import { Countrymaster } from '../secure/pages/master/countrymaster/countrymaster';
import { Statemaster } from '../secure/pages/master/statemaster/statemaster';
import { Districtmaster } from '../secure/pages/master/districtmaster/districtmaster';
import { Purchaserequest } from '../secure/pages/Procurement/purchaserequest/purchaserequest';
import { Purchaseorder } from '../secure/pages/Procurement/purchaseorder/purchaseorder';
import { Materialreceived } from '../secure/pages/Procurement/materialreceived/materialreceived';
import { Purchasereturn } from '../secure/pages/Procurement/purchasereturn/purchasereturn';
import { Stockin } from '../secure/pages/inventory/stockin/stockin';
import { Currentstock } from '../secure/pages/inventory/currentstock/currentstock';
import { Production } from '../secure/pages/inventory/production/production';
import { Currentstockupdate } from '../secure/pages/inventory/currentstockupdate/currentstockupdate';
import { Manageexit } from '../secure/pages/hrpayroll/manageexit/manageexit';
import { Setting } from '../secure/pages/hrpayroll/setting/setting';
import { Manageemployee } from '../secure/pages/hrpayroll/manageemployee/manageemployee';
import { Attendance } from '../secure/pages/hrpayroll/attendance/attendance';
import { Employeeappraisal } from '../secure/pages/hrpayroll/employeeappraisal/employeeappraisal';
import { Employeeonboard } from '../secure/pages/hrpayroll/employeeonboard/employeeonboard';

export const routes: Routes = [
     { path: '', redirectTo: 'login', pathMatch: 'full' },
     { path: 'login', component: Login },
     { path: 'forgotpassword', component: Forgotpassword },
     { path: 'resetpassword', component: Resetpassword },
     {
        path: 'secure',
        component: Securelayout,
        canActivate: [AuthGuard],
        children: [
            //Master
            { path: 'dashboard', component: Dashboard },
            { path: 'companymaster', component: Companymaster },
            { path: 'branchmaster', component: Branchmaster },
            { path: 'plantmaster', component: Plantmaster },
            { path: 'warehousemaster', component: Warehousemaster },
            { path: 'unitmaster', component: Unitmaster },
            { path: 'departmentmaster', component: Departmentmaster },
            { path: 'countrymaster', component: Countrymaster },
            { path: 'statemaster', component: Statemaster },
            { path: 'districtmaster', component: Districtmaster },
            //Procurement (Return)
            {path:'purchaserequest',component:Purchaserequest},
            {path:'Purchaseorder',component:Purchaseorder},
            {path:'Materialreceived',component:Materialreceived},
            {path:'Purchasereturn',component:Purchasereturn},
            //Inventory / Stores
            {path:'stockin',component:Stockin},
            {path:'currentstock',component:Currentstock},
            {path:'production',component:Production},
            {path:'currentstockupdate',component:Currentstockupdate},
            //HR & Payroll
            {path:'setting',component:Setting},
            {path:'manageemployee',component:Manageemployee},
            {path:'attendance',component:Attendance},
            {path:'employeeappraisal',component:Employeeappraisal},
            {path:'manageexit',component:Manageexit},
            {path:'employeeonboard',component:Employeeonboard},
        ]
     },
     { path: '**', redirectTo: 'login' }
];
