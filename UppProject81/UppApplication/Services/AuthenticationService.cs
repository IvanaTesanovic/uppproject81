using Data.DataProviders;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UppApplication.Services
{
    public static class AuthenticationService
    {
        public static User CurrentUser { get; set; }
        private static readonly UserDataProvider UserDataProvider = new UserDataProvider();

        public static bool ValidateUser(string username, string password)
        {
            var user = UserDataProvider.GetByUsername(username);
            if (user == null || user.Password != password)
            {
                return false;
            }
            CurrentUser = user;
            return true;

            //return user != null && user.Password == password;
        }
    }

        
}
