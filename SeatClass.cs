using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    static class ClassAssigner
    {
        public static SeatClass GetClass(UIClass info) {
            SeatClass seatclass = null;
            switch (info)
            {
                case UIClass.FirstClass: seatclass = new FirstClass(); break;
                case UIClass.SecondClass: seatclass = new SecondClass(); break;
            }
            return seatclass;
        }
    }
    public abstract class SeatClass
    {
        public abstract int GetColumn();
    }
    public class FirstClass : SeatClass
    {
        public override int GetColumn() {
            return 3;
        }
    }
    public class SecondClass : SeatClass
    {
        public override int GetColumn() {
            return 0;
        }
    }
}
