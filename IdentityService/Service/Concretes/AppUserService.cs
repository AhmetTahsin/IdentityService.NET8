using AutoMapper;
using IdentityService.DTOs;
using IdentityService.Models.Entities;
using IdentityService.Service.Abstracts;
using Microsoft.AspNetCore.Identity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IdentityService.Service.Concretes
{
    public class AppUserService : IAppUserService
    {
        IMapper _mapper;
        readonly UserManager<AppUser> _userManager;

        public AppUserService(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<string> RegisternAsync(RegisterDTO registerDTO)
        {

            IdentityResult result = await _userManager.CreateAsync(
                _mapper.Map<AppUser>(registerDTO), registerDTO.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(_mapper.Map<AppUser>(registerDTO),registerDTO.RolName);
                return "success";
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    if (error.Description.Contains("Email"))
                    {
                        return "Email";
                    }
                    else if (error.Description.Contains("UserName"))
                    {
                        return "UserName";
                    }
                }
            }
            return "Fail";

        }

    }
}
