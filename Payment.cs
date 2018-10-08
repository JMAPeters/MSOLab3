using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    abstract class Payment
    {
        public abstract void Pay(float price);
    }
    class PaymentCash : Payment
    {
        public override void Pay(float price) {
            IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
            coin.starta();
            coin.betala((int)Math.Round(price * 100));
            coin.stoppa();
        }
    }
    class PaymentCredit : Payment
    {
        public override void Pay(float price) {
            // Add 50 cent if paying with credit card
            price += 0.50f;
            CreditCard c = new CreditCard();
            c.Connect();
            int ccid = c.BeginTransaction(price);
            c.EndTransaction(ccid);
        }
    }
    class PaymentDebit : Payment
    {
        public override void Pay(float price) {
            DebitCard d = new DebitCard();
            d.Connect();
            int dcid = d.BeginTransaction(price);
            d.EndTransaction(dcid);
        }
    }
}
