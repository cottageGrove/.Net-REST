using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {

        private static List<Listing> listings = new List<Listing>();

        // private static List<Listing> equipmentListings = new List<Listing>();


        private static int id = 0;

        public static IEnumerable<Listing> Listings {
            get {
                return listings;
            }
        }

        public static IEnumerable<Equipment> GetEquipmentListings() {
            return new List<Equipment> {
                new Equipment () {
                    Id = 0,
                    Name = "Macbook Pro 15 inch 2019",
                    Description = "A very expensive laptop",
                    Availability = true
                },

                new Equipment () {
                    Id = 1,
                    Name = "Macbook Pro 13 inch 2019",
                    Description = "A smaller but still very expensive laptop",
                    Availability = true
                },

                new Equipment () {
                    Id = 2,
                    Name = "Ipad Pro",
                    Description = "A very expensive tablet",
                    Availability = true
                },

                new Equipment () {
                    Id = 3,
                    Name = "Ipod",
                    Description = "what used to be the best mp3 player in the world",
                    Availability = false
                }
                

            };
        }




        public static void updateId() {
            //increment the id by 1 
            id += 1;
        }


        public static void AddListing(Listing listing) {

            //update the id of the listing 
            updateId();
            listing.Id = id;
            listings.Add(listing);
        }
        
    }
}

