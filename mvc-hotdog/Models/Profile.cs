using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_hotdog.Models
{
    public class Profile
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string ProfileBio { get; set; }
        public string ImageURL { get; set; }
        public string FavDog { get; set; }
        public int Rating { get; set; }
        public List<string> PastDogs { get; set; }
    }
}