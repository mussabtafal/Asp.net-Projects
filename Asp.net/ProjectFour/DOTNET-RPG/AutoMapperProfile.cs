using AutoMapper;
using Models.Dtos.Character;
using Models.Dtos.Weapon;
using ProjectModels.Models;

namespace Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
    }
}