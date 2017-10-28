using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace MarketPlace.Controllers
{
    public class TraderController : Controller
    {

        MarketPlaceDBEntities1 db = new MarketPlaceDBEntities1();
        // GET: Trader
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TraderList()
        {
            return View(db.TraderMasters.ToList());
        }

        // GET: Trader/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trader/Create
        public ActionResult CreateTrader()
        {
            return View();
        }

        // POST: Trader/Create
        [HttpPost]
        public ActionResult CreateTrader(TraderMaster traderMaster)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    traderMaster.CreateDate = DateTime.Now;
                    traderMaster.UpdateDate = DateTime.Now;
                    traderMaster.CreatedBy = 1;
                    db.TraderMasters.Add(traderMaster);
                    db.SaveChanges();
                    return RedirectToAction("TraderList");
                }
                return View();
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Trader/Edit/5
        public ActionResult EditTrader(int id)
        {
            var data = db.TraderMasters.Find(id);
            return View(data);
        }

        // POST: Trader/Edit/5
        [HttpPost]
        public ActionResult EditTrader(int id, TraderMaster traderMaster)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    traderMaster.UpdateDate = DateTime.Now;
                    traderMaster.UpdateBy = 1;
                    db.Entry(traderMaster).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("TraderList");
                }
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: Trader/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trader/Delete/5
        [HttpPost]
        public ActionResult DeleteTrader(int id)
        {
            try
            {
                if (id != null)
                {
                    TraderMaster traderMasters = db.TraderMasters.Find(id);
                    db.TraderMasters.Remove(traderMasters);
                    db.SaveChanges();
                    return RedirectToAction("TraderList");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
