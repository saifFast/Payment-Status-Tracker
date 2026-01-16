import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    loadComponent: () =>
      import('./payments/payments.component')
        .then(m => m.PaymentsComponent)
  }
];
