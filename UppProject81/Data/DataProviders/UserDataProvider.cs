using Data.Entities;
using NPoco;
using System;
using System.Collections.Generic;

namespace Data.DataProviders
{
    public class UserDataProvider
    {
        public User GetByUsername(string username)
        {
            using (var database = new Database("UppDb"))
            {
                try
                {
                    var user = database.Query<User>().FirstOrDefault(u => u.Username == username);
                    return user;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public List<User> GetUserByRole(string role)
        {
            using (var database = new Database("UppDb"))
            {
                try
                {
                    var users = database.Fetch<User>($"where Role = '{role}'");
                    return users;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}