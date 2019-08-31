namespace WoWArmoryStore.Services
{
    using WoWArmoryStore.Data;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels.InputModels;

    public class ItemService : IItemService
    {
        private readonly ApplicationDbContext contex;

        public ItemService(ApplicationDbContext contex)
        {
            this.contex = contex;
        }

        public void CreateNewItem(CreateItemInputModel model)
        {
            var item = new Product
            {
                ItemName = model.ItemName,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Price = model.Price,
                ArmorMaterial = model.ArmorMaterial,
                ItemSlots = model.ItemSlots,
            };
            this.contex.Products.Add(item);
            this.contex.SaveChangesAsync();
        }
    }
}
