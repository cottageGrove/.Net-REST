using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AvailableEquipment() 
        {
            return View();
        }

        public IActionResult AllEquipment() {
            return View();
        }

        public IActionResult RequestForm() {
            return View();
        }

        public IActionResult Requests() {
            return View(Repository.Listings);
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page. ";
            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";
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


        [HttpPost]
        public ViewResult ListingForm(Listing listing) {
            // TODO: store response from guest

            Repository.AddListing(listing);

            return View("Confirmation");

            // return View("AllEquipment"); 
            // return View("Thanks", listing);


            // Console.WriteLine(listing.Email);
            // Console.ReadKey(true);
            // // Debug.WriteLine(listing.Email);
            // return View();
        }

        // public ViewResult Listings () {
        //     return View(Repository.Listings);
        // }


    }
}

