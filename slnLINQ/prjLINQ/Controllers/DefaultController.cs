using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjLINQ.Models;


namespace prjLINQ.Controllers
{
    public class DefaultController : Controller
    {
        public string ShowArrayDesc()
        {
            int[] score = new int[] { 1, 2, 3, 4, 5 };
            string show = "";
            //LinQ擴充寫法
            var result = score.OrderByDescending(m => m);
            show = "遞減排序";
            foreach (var m in result)

            {
                show += m + ",";

            }

            show += "<br/>";
            show += "總和" + result.Sum();
            return show;

        }
        public string Login(string uid, string pwd)
        {

            YonYuEntities db = new YonYuEntities();

            var result = db.UserData.Where(m => m.UserName == uid && m.Password == pwd).FirstOrDefault();
            string show = "";
            if (result != null)
            {
                show = result.NameCn + "歡迎進入系統";
            }
            else
            {
                show = "帳號密碼錯誤";
            }
            return show;
        }
    }
}


