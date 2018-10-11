using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    //Chooses the correct Discount
    static class DiscountAssigner{
        public static Discount GetDiscount(UIDiscount info) {
            Discount discount = null;
            switch (info) {
                case UIDiscount.NoDiscount: discount = new Discount0(); break;
                case UIDiscount.TwentyDiscount: discount = new Discount20(); break;
                case UIDiscount.FortyDiscount: discount = new Discount40(); break;
            }
            return discount;
        }
    }
    public abstract class Discount
    {
        public abstract int AddDiscount(int col);
    }
    public  class Discount0 : Discount
    {
        public override int AddDiscount(int col) {
            return col;
        }
    }
    public class Discount20 : Discount
    {
        public override int AddDiscount(int col) {
            return col + 1;
        }
    }
    public class Discount40 : Discount
    {
        public override int AddDiscount(int col) {
            return col + 2;
        }
    }
}
