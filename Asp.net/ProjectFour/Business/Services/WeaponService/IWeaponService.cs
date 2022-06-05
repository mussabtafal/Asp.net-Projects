using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Dtos.Character;
using Models.Dtos.Weapon;
using ProjectModels.Models;

namespace Models.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}