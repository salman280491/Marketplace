using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace MarketPlace.Controllers
{
    public class GoodsController : Controller
    {
        MarketPlaceDBEntities1 db = new MarketPlaceDBEntities1();
        // GET: Trader
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GoodsList()
        {
            return View(db.GoodsMasters.ToList());
        }

        // GET: Trader/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trader/Create
        public ActionResult CreateGoods()
        {
            ViewData["GoodsTypeID"] = new SelectList(db.GoodsTypeMasters.ToList(), "TypeID", "TypeName");
            return View();
        }

        // POST: Trader/Create
        [HttpPost]
        public ActionResult CreateGoods(GoodsMaster goodsMaster)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    goodsMaster.CreateDate = DateTime.Now;
                    goodsMaster.UpdatedDate = DateTime.Now;
                    goodsMaster.Createdby = 1;
                    db.GoodsMasters.Add(goodsMaster);
                    db.SaveChanges();
                    return RedirectToAction("GoodsList");
                }

                ViewData["GoodsTypeID"] = new SelectList(db.GoodsTypeMasters.ToList(), "TypeID", "TypeName");
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: Trader/Edit/5
        public ActionResult EditGoods(int id)
        {
            ViewData["GoodsTypeID"] = new SelectList(db.GoodsTypeMasters.ToList(), "TypeID", "TypeName");
            return View(db.GoodsMasters.Find(id));
        }

        // POST: Trader/Edit/5
        [HttpPost]
        public ActionResult EditGoods(int id, GoodsMaster goodsMaster)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(goodsMaster).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("GoodsList");
                }
                ViewData["GoodsTypeID"] = new SelectList(db.GoodsTypeMasters.ToList(), "TypeID", "TypeName");
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
        public ActionResult DeleteGoods(int id)
        {
            try
            {
                if (id != null)
                {
                    GoodsMaster goodsMaster = db.GoodsMasters.Find(id);
                    db.GoodsMasters.Remove(goodsMaster);
                    db.SaveChanges();
                    return RedirectToAction("Index");
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

        public ActionResult CreateGoodsType()
        {
            return View();
        }

        // POST: Trader/Create
        [HttpPost]
        public ActionResult CreateGoodsType(GoodsTypeMaster goodsTypeMaster)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    goodsTypeMaster.CreateDate = DateTime.Now;
                    goodsTypeMaster.UpdateDate = DateTime.Now;
                    goodsTypeMaster.CreatedBy = 1;
                    db.GoodsTypeMasters.Add(goodsTypeMaster);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();

            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult GoodsTypeList()
        {
            return View(db.GoodsTypeMasters.ToList());
        }
    }
}