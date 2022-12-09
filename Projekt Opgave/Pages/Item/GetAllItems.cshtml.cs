using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_Opgave.Service.Item_Service;

namespace Projekt_Opgave.Pages.Item
{
    public class GetAllItemsModel : PageModel
    {
        private ItemService _itemService;

        public GetAllItemsModel(ItemService itemService)
        {
            _itemService = itemService;
        }

        public void OnGet()
        {
            Items = _itemService.GetItems();
        }
        public List<Models.Item> Items { get; private set; }
    }
}
