using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjMoldApparadus.Model;




namespace prjMoldApparadus.Controllers
{
    public class HomeController : Controller
    {
        dbErp1Entities db = new dbErp1Entities();
        //get home
        public ActionResult Index()
        {
            var Transactions = db.MoldTransaction.ToList();
            return View(Transactions);
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MoldTransaction MTS)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Error = false;
                var result = db.MoldTransaction
                  .Where(m => m.MoldID == MTS.MoldID)
                  .FirstOrDefault();
                if (result != null)
                {
                    ViewBag.Error = true;
                    return View(MTS);
                }
                db.MoldTransaction.Add(MTS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(MTS);
        }

        public ActionResult Edit(string TransactionID)
        {
            var TransactionOne = db.MoldTransaction
                .Where(m => m.TransactionID.ToString() == TransactionID).FirstOrDefault();
            return View(TransactionOne);
        }

        [HttpPost]
        public ActionResult Edit(MoldTransaction MTS)
        {
            if (ModelState.IsValid)
            {
                var result = db.MoldTransaction
                        .Where(m => m.MoldID == MTS.MoldID).FirstOrDefault();
                result.Werk = MTS.Werk;
                result.MoldID = MTS.MoldID;
                result.ApparadusID = MTS.ApparadusID;
                result.Quantity = MTS.Quantity;
                result.Usage = MTS.Usage;
                result.UsingDescription = MTS.UsingDescription;
                result.Comment = MTS.Comment;
                result.TransactionTypeNo = MTS.TransactionTypeNo;
                result.CreateDate = MTS.CreateDate;
                result.CreatedBy = MTS.CreatedBy;
                result.LmDate = MTS.LmDate;
                result.LmBy = MTS.LmBy;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(MTS);
        }
        public ActionResult Delete(string TransactionID)
        {
            var result = db.MoldTransaction
                    .Where(m => m.TransactionID.ToString() == TransactionID).FirstOrDefault();
            db.MoldTransaction.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
        }
