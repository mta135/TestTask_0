using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.Models;
using TestTask_2.ViewModels;

namespace TestTask_2.Infrastructure
{
    public interface ICityDetails
    {
        void SaveCityDetails(CityDetailsViewModel cityDetailsViewModel);
        IEnumerable<City> Cities { get; }
        IEnumerable<Street> Streets { get; }
        IEnumerable<CityDetail> CityDetails { get; }
        IEnumerable<StreetCityDetail> StreetCityDetails { get; }
    }
}
