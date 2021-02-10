using Earnventory.Domain.Requests;
using Earnventory.Domain.Responses;
using Earnventory.Services.IRepository;

namespace Earnventory.Services.Repository
{
    public class AuthRepository : IAuthRepository
    {
        public LoginResponse Login(LoginRequest request)
        {
            throw new System.NotImplementedException();
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }
    }
}