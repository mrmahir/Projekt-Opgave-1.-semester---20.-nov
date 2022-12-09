namespace Projekt_Opgave.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public double TotalPrice { get; set; }


        public Order(int id, double totalPrice)
        {
            OrderId = id;
            TotalPrice = totalPrice;
        }

        public Order()
        {

        }
    }
}
