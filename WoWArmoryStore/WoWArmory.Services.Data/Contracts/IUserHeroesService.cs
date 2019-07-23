using System.Collections.Generic;
using WoWArmory.Data;
using WoWArmory.Models.Common;

namespace WoWArmory.Services.Data.Contracts
{
    public interface IUserHeroesService
    {

        List<UsersHeroCardModel> ShowHeroCard(string currUser);

    }
}
