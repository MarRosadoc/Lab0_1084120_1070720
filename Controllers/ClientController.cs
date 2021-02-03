using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0_1084120_1070720.Models;

namespace Lab0_1084120_1070720.Controllers
{
    public class ClientController : Controller
    {
        
        // GET: ClientController
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClientList);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            var ViewClient = Singleton.Instance.ClientList.Find(x => x.Id == id);
            return View(ViewClient);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var newClient = new Models.Client
                {
                    Id = Convert.ToInt32(Singleton.Instance.ClientList.Count),
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    Phone = Convert.ToInt32(collection["Phone"]),
                    Description = collection["Description"]
                };
                Singleton.Instance.ClientList.Add(newClient);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            var editClient = Singleton.Instance.ClientList.Find(x => x.Id == id);
            
            return View(editClient);
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
