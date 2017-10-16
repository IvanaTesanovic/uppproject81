using Data.Entities;
using NPoco;
using System;

namespace Data.DataProviders
{
    public class UserDataProvider
    {
        public User GetUserByUsername(string username)
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
    }
}