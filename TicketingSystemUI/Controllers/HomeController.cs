using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TicketingSystemUI.Models;

namespace TicketingSystemUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public  IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> TicketsList()
        {
            List<Tickets> ticketsList = new List<Tickets>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44304/api/Tickets/GetTickets"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ticketsList = JsonConvert.DeserializeObject<List<Tickets>>(apiResponse);
                }
            }
            return View(ticketsList);
        }  
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        } 
        public IActionResult RaisedTickets()
        {
            return View();
        }
        public IActionResult TicketPriorities()
        {
            return View();
        }
        public IActionResult TicketStatus()
        {
            return View();
        }
         public IActionResult RaiseTicket()
        {
            return View();
        }   
      
        public IActionResult UserCategories()
        {
            return View();
        }
         public IActionResult Faq()
        {
            return View();
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
