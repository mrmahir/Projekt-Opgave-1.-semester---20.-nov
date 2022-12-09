using Projekt_Opgave.MockData;
using Projekt_Opgave.Models;

namespace Projekt_Opgave.Service.Item_Service
{
    public class ItemService
    {
        private List<Item> _items;

        public ItemService()
        {
            _items = MockItems.GetMockItems();
        }

        public List<Item> GetItems()
        {
            return _items;
        }
        public void AddItem(Item item)
        {
            _items.Add(item);
        }

    }
}
