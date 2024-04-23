using IdentityService.DTOs;

namespace IdentityService.Service.Abstracts
{
    public interface IAppUserService
    {
        public Task<string> RegisternAsync(RegisterDTO registerDTO);
    }
}
