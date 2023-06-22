using System;
using tuRecomendacion.Interfaces;
using tuRecomendacion.Model;

namespace tuRecomendacion.Services
{
    public class FacebookAuthService : IAuthService
    {
        public async Task<User> SignInAsync()
        {
            // TODO: Use the Facebook SDK to authenticate the user.
            // If successful, return a User object.
            return User.Default;
        }

        public async Task SignOutAsync()
        {
            // TODO: Use the Facebook SDK to sign out the user.
        }
    }
}