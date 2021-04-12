using BREWCITY.Models;
using BREWCITY.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BREWCITY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetLocalBreweriesServices _getLocalBreweriesServices;


        public HomeController(ILogger<HomeController> logger, IGetLocalBreweriesServices getLocalBreweriesServices)
        {
            _logger = logger;
            _getLocalBreweriesServices = getLocalBreweriesServices;
        }

        public IActionResult Index()
        {
            return View();
        }
     
        public async Task<IActionResult> GetList(string state)
        {
            state = "Texas";
           var actionResult = await _getLocalBreweriesServices.GetLocalBreweries(state);
            JsonBrewery[] actionResultArray = actionResult.ToArray();
            return View(actionResultArray);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
