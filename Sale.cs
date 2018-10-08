using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Sale
    {
        Payment payment;

        public void Pay(float price) {
            payment.Pay(price);
        }

        public Sale(UIPayment paymentMethod) {
            switch (paymentMethod)
            {
                case UIPayment.CreditCard:
                    payment = new PaymentCredit();
                    break;
                case UIPayment.DebitCard:
                    payment = new PaymentDebit();
                    break;
                case UIPayment.Cash:
                    payment = new PaymentCash();
                    break;
            }
        }
    }
}
