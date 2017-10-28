using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketPlace.Controllers
{
    public class CheckInController : Controller
    {

        MarketPlaceDBEntities1 db = new MarketPlaceDBEntities1();
        // GET: CheckIn
        public ActionResult CheckInList()
        {
            return View(db.CheckIns.ToList());
        }

        // GET: CheckIn/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CheckIn/Create
        public ActionResult CreateCheckIn()
        {

            ViewData["TraderID"] = new SelectList(db.TraderMasters.ToList(), "TraderID", "TraderName");
            ViewData["GoodsID"] = new SelectList(db.GoodsMasters.ToList(), "GoodsID", "GoodsName");
            return View();
        }

        // POST: CheckIn/Create
        [HttpPost]
        public ActionResult CreateCheckIn(CheckIn checkIn)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    checkIn.CheckInDate = DateTime.Now;
                    checkIn.UpdateDate = DateTime.Now;
                    checkIn.CheckInBy = 1;
                    db.CheckIns.Add(checkIn);
                    db.SaveChanges();
                    return RedirectToAction("CheckInList");
                }

                ViewData["TraderID"] = new SelectList(db.TraderMasters.ToList(), "TraderID", "TraderName");
                ViewData["GoodsID"] = new SelectList(db.GoodsMasters.ToList(), "GoodsID", "GoodsName");
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: CheckIn/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckIn/Edit/5
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

        // GET: CheckIn/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckIn/Delete/5
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
    }
}
