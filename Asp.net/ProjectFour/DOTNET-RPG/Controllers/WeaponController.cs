using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Dtos.Character;
using Models.Dtos.Weapon;

using Models.Services.WeaponService;
using Microsoft.AspNetCore.Mvc;
using ProjectModels.Models;

namespace Models.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
    }
}