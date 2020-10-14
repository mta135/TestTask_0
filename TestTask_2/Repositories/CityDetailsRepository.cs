using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.DataBaseAccess;
using TestTask_2.Infrastructure;
using TestTask_2.Models;
using TestTask_2.ViewModels;

namespace TestTask_2.Repositories
{
    public class CityDetailsRepository : ICityDetails
    {
        private readonly ApplicationContext_2 context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CityDetailsRepository(ApplicationContext_2 context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<City> Cities
        {
            get
            {
                return context.Cities.ToList();
            }
        }
        public IEnumerable<Street> Streets
        {
            get
            {
                return context.Streets.ToList();
            }
        }

        public IEnumerable<CityDetail> CityDetails
        {
            get
            {
                return context.CityDetails;
            }
        }

        public IEnumerable<StreetCityDetail> StreetCityDetails
        {
            get
            {
                return context.StreetCityDetails;
            }
        }

        public void SaveCityDetails(CityDetailsViewModel cityDetailsViewModel)
        {
            try
            {
                //string uniqueFileName = null;
                if (cityDetailsViewModel.Photo != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Files");
                    //uniqueFileName = Guid.NewGuid().ToString() + "_" + cityDetailsViewModel.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, Guid.NewGuid().ToString() + "_" + cityDetailsViewModel.Photo.FileName);
                    cityDetailsViewModel.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                if (cityDetailsViewModel.StreetsId.Count != 0)
                {
                    foreach (var streetId in cityDetailsViewModel.StreetsId)
                    {
                        StreetCityDetail streetCityDetail = new StreetCityDetail
                        {
                            CityDetailId = cityDetailsViewModel.CityId,
                            StreetId = streetId
                        };
                        context.StreetCityDetails.Add(streetCityDetail);
                    }
                }
                CityDetail cityDetail = new CityDetail
                {
                    FullName = cityDetailsViewModel.UserFulName,
                    HomeNumber = cityDetailsViewModel.HomeNumber,
                    FileName = cityDetailsViewModel.Photo.FileName,
                    BirthDate = cityDetailsViewModel.UserBirthDate,
                    CityId = cityDetailsViewModel.CityId
                };
                context.CityDetails.Add(cityDetail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
            }
        }
    }
}
