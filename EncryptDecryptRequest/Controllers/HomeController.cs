using EncryptDecryptRequest.EncryptionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EncryptDecryptRequest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public string Message(string msg)
        {
            var objEncryptDecrypt = EncryptinDecryptionHelperFile.DecryptStringAES(msg);
            
            return objEncryptDecrypt;
        }
    }
}