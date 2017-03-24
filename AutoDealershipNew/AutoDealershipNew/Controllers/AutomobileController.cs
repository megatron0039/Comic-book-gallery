using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoDealershipNew;
using AutomobileDealershipNew;

namespace AutomobileDealershipNew.Controllers
{
    public class AutomobileController : Controller
    {    //out
        //public object Make, Model, ID, Year, Color { get; private set; }

        // GET: Automobile
        public ActionResult Index()
        {
            {
                //var automobile = from a in GetAutomobileControllerList()
                //orderby a.ID
                //select a;
                return View();
            }

        }

        // GET: Automobile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Automobile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automobile/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Automobile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Automobile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Automobile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Automobile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(); 
            } 
        }
        public  List <Automobile> GetAutomobileList()
        {
            return new List<Automobile>
            {

                 new Automobile
                 {
                 ID = 1,
                 Make = "Audi",
                 Model = "A8 Quattro",
                 Year = 2017,
                 Color = "Blue"
                 },


                 new Automobile
                 {
                 ID = 2,
                 Make = "Mercedes-Maybach S600 Sedan",
                 Model = "CL 350",
                 Year = 2017,
                Color = "Black"
                },

                 new Automobile
                {

                ID = 3,
                Make = "Cadillac",
                Model = "CT6",
                year = 2017,
                Color = "Pearl White"
                },

                new Automobile
                {
                ID = 4,
                Make = "Porche",
                Model = "Caynne",
                Year = 2017,
                Color = "Green"
                },
            };
        }
    }
}