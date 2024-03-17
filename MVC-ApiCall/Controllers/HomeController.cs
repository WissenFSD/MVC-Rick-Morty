using Microsoft.AspNetCore.Mvc;
using MVC_ApiCall.Models;
using MVC_ApiCall.Service;
using System.Diagnostics;

namespace MVC_ApiCall.Controllers
{
    
    public class HomeController : Controller
    {
        public IRickAndMortyService _rickandmortyservice;
        public HomeController(IRickAndMortyService service)
        {
            _rickandmortyservice = service;
        }

        public IActionResult Index()
        {
            var characterResult = _rickandmortyservice.GetCharacters();
            return View(characterResult);
        }

 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
