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

        public static int id = 0;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AvailableEquipment() 
        {

            var availableEquipment = from e in Repository.GetEquipmentListings()
                                        where e.Availability == true
                                        orderby e.Id ascending 
                                        select(e);

            return View(availableEquipment);
        }

        public IActionResult AllEquipment() {
            return View(Repository.GetEquipmentListings());
        }

        // public IActionResult RequestForm() {
        //     return View();
        // }

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

        public IActionResult RequestDetails(int id)
        {

            var listing = Repository.Listings.SingleOrDefault(li => li.Id == id);

            if (listing == null)
            {
                return View("ListingNotFound");
            }
            return View(listing);
        }


        [HttpGet]
        public ViewResult RequestForm() {
            return View();
        }


        [HttpPost]
        public ViewResult RequestForm(Listing listing) {
            // TODO: store response from guest


            if (ModelState.IsValid) {
                Repository.AddListing(listing);
                return View("Confirmation");
            } else {
                // there is a validation error
                return View();
            }


            // Repository.AddListing(listing);

            // return View("Confirmation");

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

