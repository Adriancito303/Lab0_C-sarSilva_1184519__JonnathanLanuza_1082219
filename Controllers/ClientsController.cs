using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab0_CésarSilva_1184519__JonnathanLanuza_1082219.Models.Data;

namespace Lab0_CésarSilva_1184519__JonnathanLanuza_1082219.Controllers
{
    public class ClientsController : Controller
    {
        void bubble (List<String> A, int n)
        {
            int i, j;
            String aux;
            for (i = 0; i < n-1; i++)
            {
                for (j = i+1; j < n; j++)
                {
                    if (A[i] != A[j])
                    {
                        aux = A[i];
                        A[i] = A[j];
                        A[j] = aux;
                    }
                }
            }
        }
        List<String> Clistt = new List<string>();
        int cont = 0;
        // GET: ClientsController
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClientsList);
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(string Name)
        {
            var lukeClients = Singleton.Instance.ClientsList.Find(x => x.Name == Name);
            return View(lukeClients);
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
                var newClients = new Models.Clients
                {
                    Name = Dclients["Name"],
                    Lastname = Dclients["Lastname"],
                    PhoneNumber = Convert.ToInt32(Dclients["PhoneNumber"]),
                    Description = Dclients["Description"]
                };
                Singleton.Instance.ClientsList.Add(newClients);
                Clistt.Add(newClients.Name);
                IOrderedEnumerable<String> ListFC = Clistt.OrderBy(x => x.Length);
                //Singleton.Instance.ClientsList.Add(newClients);
                //cont++;
                //bubble(Clistt, cont);
                //if (Nm > cont)
                //{
                //    //Sort
                //}
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(string Name)
        {
            return View();
        }

        // POST: ClientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string Name, IFormCollection collection)
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
        public ActionResult Delete(string Name)
        {
            return View();
        }

        // POST: ClientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string Name, IFormCollection collection)
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
