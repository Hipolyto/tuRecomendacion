using tuRecomendacion.Interfaces;
using tuRecomendacion.Model;

namespace tuRecomendacion.Services
{
    public class AppleAuthService : IAppleAuthService
    {
        public async Task<User> SignInAsync()
        {
            // TODO: Use the Apple SDK to authenticate the user.
            // If successful, return a User object.
            return User.Default;
        }

        public async Task SignOutAsync()
        {
            // TODO: Use the Apple SDK to sign out the user.
        }
    }

}

