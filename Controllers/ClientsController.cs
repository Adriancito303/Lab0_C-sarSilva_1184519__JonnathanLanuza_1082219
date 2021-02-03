using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0_CésarSilva_1184519__JonnathanLanuza_1082219.Models;
namespace Lab0_CésarSilva_1184519__JonnathanLanuza_1082219.Controllers
{
    public class ClientsController : Controller
    {

        // GET: ClientsController
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClientsList);
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection Dclients)
        {
            try
            {
                var Clientnew = new Models.Clients
                {
                    Name = Dclients["Name"],
                    Lastname = Dclients["Lastname"],
                    PhoneNumber = Convert.ToInt32(Dclients["PhoneNumber"]),
                    Description = Dclients["Description"]
                };
                Singleton.Instance.ClientsList.Add(Clientnew);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientsController/Edit/5
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

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientsController/Delete/5
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
