using DatingApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExist(string username);
    }

    public class A
    {
        public A(int a)
        {

        }
    }
    public class B : A
    {
        public B(int a) : base(a)
        {

        }
    }
}
