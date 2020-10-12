using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.Models;

namespace TestTask_2.Infrastructure
{
    public interface IUser
    {
        IEnumerable<User> Users { get; }
    }
}
