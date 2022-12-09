namespace Projekt_Opgave.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }


        public Item(int id, string name, double price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;    
           
        }

        public Item()
        {

        }
    }
}
