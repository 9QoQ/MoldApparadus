using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using slnErp.Models;
using System.Data.Entity;

namespace slnErp.Controllers
{
    public class MoldTransactionController : Controller
    {
        /*show apparadusconfig*/
        public string ShowApparadus()

        {
            MoldEntities db = new MoldEntities();


            var result = db.ApparadusConfig;
            string show = "";
            foreach (var m in result)
            {
                show += $"配件編號:{m.ApparadusNo}<br/>";
                show += $"配件名稱:{m.ApparadusName}<br/>";
                show += $"配件說明:{m.ApparadusDescription} <br/>";
                show += $"配件建立日期:{m.ApparadusMfgDate}<hr>";
            }
            return show;
        }


        public string ShowTransactionByMoldID(string  keyword)
        {
            MoldEntities db = new MoldEntities();
            var result = db.MoldTransaction.Where(m => m.ApparadusID.ToString().Contains(keyword));
            string show = "";
            foreach (var m in result)
            {
                show += $"模具ID:{m.MoldID}<br/>";
                show += $"數量:{m.Quantity}<br/>";
                show += $"用途:{m.Usage} <br/>";
                show += $"使用說明:{m.UsingDescription}<hr>";
            }

            return show;
        }
        public string ShowStockByApparadus(string keyword)
        {
            MoldEntities db = new MoldEntities();
            var result = db.MoldTransaction.Where(m => m.ApparadusID.ToString().Contains(keyword));
            string show = "";
            foreach (var m in result)
            {
                show += $"配件ID:{m.ApparadusID}<br/>";
                show += $"庫存數量:{result.Count()}<br/>";
                show += $"用途:{m.Usage} <br/>";
                show += $"使用說明:{m.UsingDescription}<hr>";
            }

            return show;
        }




        

        // GET: MoldTransaction
        public ActionResult Index()
        {
            return View();
        }
    }
}
