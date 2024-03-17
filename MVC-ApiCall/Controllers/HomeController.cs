using Microsoft.AspNetCore.Mvc;
using MVC_ApiCall.Models;
using MVC_ApiCall.Service;
using System.Diagnostics;

namespace MVC_ApiCall.Controllers
{
    
    public class HomeController : Controller
    {

        static int Min = 0;
        static int Max = 10;


        public IRickAndMortyService _rickandmortyservice;
        public HomeController(IRickAndMortyService service)
        {
            _rickandmortyservice = service;
        }

        public IActionResult Index(int page=1,int next=0)   
        {

            var characterResult = _rickandmortyservice.GetCharacters(page);
            if (page >1 && next==0) {


                Min = 1;
                Max = 10;
                characterResult.Min = Min;
                characterResult.Max = Max;
                return View(characterResult);

            }
            else
            {
                Max += 10;
                Min = Max - 10;
                characterResult.Max = Max;
                characterResult.Min = Min;
                return View(characterResult);
            }
          

           
        }

 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
