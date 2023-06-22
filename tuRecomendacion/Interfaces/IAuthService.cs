using System;
using tuRecomendacion.Model;

namespace tuRecomendacion.Interfaces
{
    public interface IAuthService
    {
        Task<User> SignInAsync();
        Task SignOutAsync();
    }
    public interface IAppleAuthService
    {
        Task<User> SignInAsync();
        Task SignOutAsync();
    }
}

