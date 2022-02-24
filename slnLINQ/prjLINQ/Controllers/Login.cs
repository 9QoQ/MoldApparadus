using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjLINQ.Models;

namespace prjLINQ.Controllers
{
    public class LoginController:Controller
    {
        public string LoginCertification(string uid, string pwd)
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