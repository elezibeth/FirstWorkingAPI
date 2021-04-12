using BREWCITY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BREWCITY.Services
{
    public interface IGetLocalBreweriesServices
    {
        Task<List<JsonBrewery>> GetLocalBreweries(string state);
    }
}
