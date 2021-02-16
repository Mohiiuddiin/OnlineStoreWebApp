using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Core.Contracts;
using OnlineStore.Core.Models;

namespace OnlineStore.Mvc.Web.Controllers
{
    public class BusketController : Controller
    {
        public IBusketManager BusketManager { get; set; }
        public BusketController(IBusketManager busketManager)
        {
            this.BusketManager = busketManager;
        }

        public ActionResult Index()
        {
            var busketItems = BusketManager.GetBusketItems(this.HttpContext);
            return View(busketItems);
        }

        public ActionResult AddToBusket(string id)
        {
            BusketManager.AddBusket(this.HttpContext, id);
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromBusket(string id)
        {
            BusketManager.RemoveBusket(this.HttpContext, id);
            return RedirectToAction("Index");
        }

        public PartialViewResult BusketSummary()
        {
            var busketSummary = BusketManager.GetBusketSummary(this.HttpContext);
            return PartialView(busketSummary);
        }
    }
}