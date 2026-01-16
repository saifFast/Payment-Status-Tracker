import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';
import { PaymentService } from '../services/payment.service';

@Component({
  selector: 'app-payments',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './payments.component.html'
})
export class PaymentsComponent {

  payments$!: Observable<any[]>;

  constructor(private paymentService: PaymentService) {
    this.payments$ = this.paymentService.getPayments();
  }
}
