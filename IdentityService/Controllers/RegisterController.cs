using IdentityService.DTOs;
using IdentityService.Service.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public RegisterController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterDTO registerDTO)
        {
            await _appUserService.RegisternAsync(registerDTO);
            return Ok("Kullanıcı Kaydedildi");
        }

    }
}
