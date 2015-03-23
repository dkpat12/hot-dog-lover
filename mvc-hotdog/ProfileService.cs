using System;
using mvc_hotdog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace mvc_hotdog
{
    public class ProfileService
    {
        private static List<Profile> people;

        public ProfileService()
        {
            people = createPeople();
        }

        //Method to reset profile list to default
        public void defaultProfiles()
        {
            people = createPeople();
        }

        //Returns list of people
        public List<Profile> getProfiles()
        {
            return people;
        }
        public Profile getProfile(string user)
        {
            Profile foundProfile = new Profile();
            foreach (Profile p in people)
            {
                if (p.Username == user)
                {
                    foundProfile = p;
                }
            }
            return foundProfile;
        }

        //Add new profile
        public void addProfile(Profile p)
        {
            //Add Validation Here
            people.Add(p);
        }
        //PLEASE REVIEW
        public void removeProfile(Profile p)
        {
            Profile sp = getProfile(p.Username);
            people.Remove(sp);
        }
        //Populates list on first run
        private static List<Profile> createPeople()
        {
            List<Profile> builtProfiles = new List<Profile>();

            Profile p1 = new Profile()
            {
                Username = "dkpat",
                Name = "Dillion Patt",
                ProfileBio = "You think water moves fast? You should see ice. It moves like it has a mind. Like it knows it killed the world once and got a taste for murder. After the avalanche, it took us a week to climb out. Now, I don't know exactly when we turned on each other, but I know that seven of us survived the slide... and only five made it out. Now we took an oath, that I'm breaking now. We said we'd say it was the snow that killed the other two, but it wasn't. Nature is lethal but it doesn't hold a candle to man." + System.Environment.NewLine + "Now that we know who you are, I know who I am. I'm not a mistake! It all makes sense! In a comic, you know how you can tell who the arch-villain's going to be? He's the exact opposite of the hero. And most times they're friends, like you and me! I should've known way back when... You know why, David? Because of the kids. They called me Mr Glass.",
                ImageURL = "Pretty Colors",
                FavDog = "Half-foot long",
                Rating = 5,
                PastDogs = new List<string> { "Orange Dog", "Beef Frank" }
            };
            builtProfiles.Add(p1);

            Profile p2 = new Profile()
            {
                Username = "jsmith",
                Name = "John Smith",
                ProfileBio = "You think water moves fast? You should see ice. It moves like it has a mind. Like it knows it killed the world once and got a taste for murder. After the avalanche, it took us a week to climb out. Now, I don't know exactly when we turned on each other, but I know that seven of us survived the slide... and only five made it out. Now we took an oath, that I'm breaking now. We said we'd say it was the snow that killed the other two, but it wasn't. Nature is lethal but it doesn't hold a candle to man." + System.Environment.NewLine + "Now that we know who you are, I know who I am. I'm not a mistake! It all makes sense! In a comic, you know how you can tell who the arch-villain's going to be? He's the exact opposite of the hero. And most times they're friends, like you and me! I should've known way back when... You know why, David? Because of the kids. They called me Mr Glass.",
                ImageURL = "Pretty Colors",
                FavDog = "All Beef",
                Rating = 1,
                PastDogs = new List<string> { "All Beef", "Vegan Delight", "Purple People Eater" }
            };
            builtProfiles.Add(p2);

            Profile p3 = new Profile()
            {
                Username = "codeorange",
                Name = "Elizabeth Frankfurter",
                ProfileBio = "You think water moves fast? You should see ice. It moves like it has a mind. Like it knows it killed the world once and got a taste for murder. After the avalanche, it took us a week to climb out. Now, I don't know exactly when we turned on each other, but I know that seven of us survived the slide... and only five made it out. Now we took an oath, that I'm breaking now. We said we'd say it was the snow that killed the other two, but it wasn't. Nature is lethal but it doesn't hold a candle to man." + System.Environment.NewLine + "Now that we know who you are, I know who I am. I'm not a mistake! It all makes sense! In a comic, you know how you can tell who the arch-villain's going to be? He's the exact opposite of the hero. And most times they're friends, like you and me! I should've known way back when... You know why, David? Because of the kids. They called me Mr Glass.",
                ImageURL = "Pretty Colors",
                FavDog = "Royale Hot",
                Rating = 3,
                PastDogs = new List<string> { "Royale Hot", "Beef Frank", "Plebian's Dog" }
            };
            builtProfiles.Add(p3);


            return builtProfiles;
        }
    }
}