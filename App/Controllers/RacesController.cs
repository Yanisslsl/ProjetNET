using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers
{
    public class RacesController : Controller
    {
        // GET: Races
        public ActionResult Index()
        {
            var races = new List<Race>()
            {
                new Race()
                {
                    Id= 1,
                    Name="MA course"

                },
                new Race()
                {
                    Id=2,
                    Name="MA course 2"
                },
                new Race()
                {
                    Id=3,
                    Name="MA course 3"
                },
                new Race()
                {
                    Id=4,
                    Name="MA course 4"
                },

            };
            return View(races);
        }

        // GET: Races/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Races/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Races/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Races/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Races/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Races/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Races/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}