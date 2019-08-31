namespace WoWArmoryStore.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using WoWArmoryStore.Data;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels.ViewModels;
    using WoWArmoryStore.Services.Mapping;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Common;

    public class AdministrationService : IAdministrationService
    {
        private readonly ApplicationDbContext db;

        public AdministrationService(ApplicationDbContext contex)
        {
            this.db = contex;
        }

        public void DeleteUser(string id)
        {
            WoWArmoryUser userToDelete = this.db.Users.FirstOrDefault(x => x.Id == id);
            var heroesToDelete = this.db.Heroes.Where(x => x.WoWArmoryUserId == userToDelete.Id);
            this.db.Heroes.RemoveRange(heroesToDelete);
            this.db.Users.Remove(userToDelete);
            this.db.SaveChanges();
        }

        public ICollection<UserViewModel> UserViewModels(string userId)
        {
            var heores = this.db.Heroes.Where(x => x.WoWArmoryUserId == userId)
                .ToList();
            var users = this.db.Users.Where(x => x.Id != GlobalConstants.AdministratorId).Select(user => new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Heroes = heores,

            }).ToList();
            return users;
        }

        public void DeleteItem(int id)
        {
            Product itemToDelete = this.db.Products.FirstOrDefault(x => x.Id == id);
            //TODO Delete items from users inventory
            this.db.Products.Remove(itemToDelete);
            this.db.SaveChanges();
        }

        public ICollection<ItemViewModel> ItemViewModels()
        {
            var items = this.db.Products.Select(item => new ItemViewModel
            {
                Id = item.Id,
                ImageUrl = item.ImageUrl,
                ItemName = item.ItemName,
            }).ToList();

            return items;
        }

        public Product GetItemToUpdate(int itemId)
        {
            Product itemToUpadte = this.db.Products.FirstOrDefault(item => item.Id == itemId);

            return itemToUpadte;
        }

        public void UpdateItem(Product product)
        {
            var productToUpdate = this.db.Products.FirstOrDefault(item => item.Id == product.Id);

            if (productToUpdate != null)
            {
                productToUpdate.ItemName = product.ItemName;
                productToUpdate.Description = product.Description;
                productToUpdate.Price = product.Price;
                productToUpdate.ArmorMaterial = product.ArmorMaterial;
                productToUpdate.ImageUrl = product.ImageUrl;
                productToUpdate.ItemSlots = product.ItemSlots;
                this.db.SaveChanges();
            }

        }
    }
}
