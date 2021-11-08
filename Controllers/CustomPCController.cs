using ASP.Net_project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Controllers
{
    public class CustomPCController : Controller
    {
        IList<CustomPC> customPCs = new List<CustomPC> { };
        // GET: CustomPCController
        public ActionResult Index()
        {
            //return View();
            ViewBag.Action = "Index";
            return View(customPCs);
        }

        // GET: CustomPCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomPCController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomPCController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomPCController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomPCController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomPCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomPCController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
