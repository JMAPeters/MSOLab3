using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticket
    {
        SeatClass seatClass;
        Discount discount;
        UIWay way;
        string from, to;
        public Ticket(UIClass seatClass, UIDiscount discount, UIWay way, string from, string to) {
            this.seatClass = ClassAssigner.GetClass(seatClass);
            this.discount = DiscountAssigner.GetDiscount(discount);
            this.way = way;
            this.from = from;
            this.to = to;
        }

        public float GetCost() {
            // Get number of tariefeenheden
            int tariefeenheden = Tariefeenheden.getTariefeenheden(from, to);

            // Compute the column in the table based on choices
            int tableColumn;
            // First based on class
            tableColumn = seatClass.GetColumn();
            // Then, on the discount
            tableColumn = discount.AddDiscount(tableColumn);

            // Get price
            float price = PricingTable.getPrice(tariefeenheden, tableColumn);
            if (way == UIWay.Return)
            {
                price *= 2;
            }
            return price;
        }
    }
}
