using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {

        private static List<Listing> listings = new List<Listing>();

        public static IEnumerable<Listing> Listings {
            get {
                return listings;
            }
        }

        public static void AddListing(Listing listing) {
            listings.Add(listing);
        }
        
    }
}

