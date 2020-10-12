using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.Controllers;
using TestTask_2.DataBaseAccess;
using TestTask_2.Infrastructure;
using TestTask_2.Models;

namespace TestTask_2.Repositories
{
    public class UserRepository : IUser
    {
        private readonly ApplicationContext_2 context;

        public UserRepository(ApplicationContext_2 context)
        {
            this.context = context;
        }

        public IEnumerable<User> Users
        {
            get
            {
                return context.Users.ToList();
            }
        }


        public void SaveUsers(User user)
        {
            User user1 = new User();

            context.Add(user);
            context.SaveChanges();
        }
    }
}
