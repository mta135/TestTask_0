using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.Models;

namespace TestTask_2.Infrastructure
{
    public interface ICity
    {
        IEnumerable<City> Cities { get; }
    }
}
