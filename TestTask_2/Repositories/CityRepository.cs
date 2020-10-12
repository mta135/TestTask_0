using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.DataBaseAccess;
using TestTask_2.Infrastructure;
using TestTask_2.Models;

namespace TestTask_2.Repositories
{
    public class CityRepository : ICity
    {
        private readonly ApplicationContext_2 context;
        public CityRepository(ApplicationContext_2 context)
        {
            this.context = context;
        }
        public IEnumerable<City> Cities
        {
            get
            {
                return context.Cities.ToList();
            }
        }
    }
}
