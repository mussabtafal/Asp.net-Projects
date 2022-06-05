using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Models.Data;
using Models.Dtos.Character;
using Models.Dtos.Weapon;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProjectModels.Models;

namespace Models.Services.WeaponService
{
    public class WeaponService : IWeaponService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = new ServiceResponse<GetCharacterDto>();
            try 
            {
                var character= await _context.Characters.FirstOrDefaultAsync(c => c.Id == newWeapon.CharacterId && c.User.Id == 3);
                if(character == null)
                    {
                        response.Success = false;
                        response.Message = "Character not found";
                        return response;
                    }
                    var weapon = new Weapon {
                        Name = newWeapon.Name,
                        Damage = newWeapon.Damage,
                        character = character
                    };

                    _context.Weapons.Add(weapon);
                    await _context.SaveChangesAsync();

                    response.Data = _mapper.Map<GetCharacterDto>(character);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}

 