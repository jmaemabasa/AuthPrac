using AuthPrac.Shared.Models.User;

namespace AuthPrac.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(RegistrationDto request);
        Task<ServiceResponse<string>> Login(UserMasterT request);
        Task<ServiceResponse<bool>> ChangePassword(UserMasterT request);
        Task<bool> IsUserAuthenticated();
    }
}
