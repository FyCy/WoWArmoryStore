using AutoMapper;
using WoWArmory.Data.Models;
using WoWArmory.Models.InputModels;

namespace WoWArmoryStore.Helpers
{
    public class MappingConfiguration :Profile
    {
        public MappingConfiguration()
        {
            this.CreateMap<CreateHeroInputModel, Hero>();

        }
    }
}
