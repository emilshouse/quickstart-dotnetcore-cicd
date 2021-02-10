using Earnventory.Domain.Requests;
using Earnventory.Domain.Responses;

namespace Earnventory.Services.IRepository
{
    public interface IAuthRepository
    {
        LoginResponse Login(LoginRequest request);
        void Logout();
    }
}