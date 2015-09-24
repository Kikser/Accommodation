using Accommodation.Models;
using Accommodation.Models.Enums;
using Accommodation.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Accommodation.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
         
                AccomodationsViewModel Accomodations = new AccomodationsViewModel();
                Accomodations.Accomodations = db.Accommodations.ToList();
                return View(Accomodations);
          
        }

        //This is for uploading image 
        //[HttpPost]
        //public ActionResult Index(HttpPostedFileBase image)
        //{
        //    if (image != null && image.ContentLength > 0) {
        //        var fileName = Path.GetFileName(image.FileName);
        //        var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);

        //        image.SaveAs(path);
        //    }
        //    return RedirectToAction("Index");
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Rent(string searchBy, string search)
        {
            if (searchBy == "City")
            {
                return View(db.Accommodations.Where(x => x.City == search || search == null).ToList());
            }
            else if(searchBy == "Street Address")
            {
                return View(db.Accommodations.Where(a => a.StreetAddress == search || search == null).ToList());
            }
           
            else if (searchBy == "Appartment")
            {
                return View(db.Accommodations.Where(a => a.Types == AccommodationType.Appartment || search == null).ToList());
            }
            else if (searchBy == "Villa")
            {
                return View(db.Accommodations.Where(a => a.Types == AccommodationType.Villa || search == null).ToList());
            }
            else if (searchBy == "House")
            {
                return View(db.Accommodations.Where(a => a.Types == AccommodationType.House || search == null).ToList());
            }
            var Accomodations = db.Accommodations.Where(t => t.RentSale == RentOrSale.Rent).ToList();
            ViewBag.Message = "Your contact page.";
            return View(Accomodations);
        }
        public ActionResult Sale()
        {
            
           var Accomodations = db.Accommodations.Where(t => t.RentSale == RentOrSale.Sale).ToList();
            ViewBag.Message = "Your contact page.";
            return View(Accomodations);
            

           
        }
    }
}