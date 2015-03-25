using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_hotdog.Models;
using System.Net;

namespace mvc_hotdog.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            ProfileService profiles = new ProfileService();
            List<Profile> profileList = profiles.getProfiles();
            return View(profileList);
        }

        // GET: Profile/Details/5
        public ActionResult Details(string user)
        {
            ProfileService profiles = new ProfileService();
            Profile theProfile = profiles.getProfile(user);
            if( theProfile.Username == null){
                return new HttpNotFoundResult("There was no profile!");
            }
            return View(theProfile);
        }

        // GET: Profile/Create
        //public ActionResult Create()
        //{
        //    Profile newpm = new Profile();
        //    return View(newpm);
        //}

        //// POST: Profile/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here
        //        ProfileService service = new ProfileService();

        //       // service.addProfile(p);

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Profile/Edit/5
        public ActionResult Edit(string user)
        {
            ProfileService profiles = new ProfileService();
            Profile theProfile = profiles.getProfile(user);
            return View(theProfile);
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(string user, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Profile/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Profile/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
