namespace WoWArmoryStore.Services.Contracts
{
    using WoWArmoryStore.Web.ViewModels.InputModels;

    public interface IItemService
    {
        void CreateNewItem(CreateItemInputModel model);
    }
}
