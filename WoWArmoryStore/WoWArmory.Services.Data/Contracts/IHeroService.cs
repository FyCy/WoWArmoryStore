using WoWArmory.Data.Models;
using WoWArmory.Models.InputModels;

namespace WoWArmory.Services.Data.Contracts
{
    public interface IHeroService
    {
        Hero Create(CreateHeroInputModel heroModel , string currUser);

        
    }
}
