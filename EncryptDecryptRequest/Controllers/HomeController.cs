using EncryptDecryptRequest.EncryptionHelper;
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


        [HttpPost]
        public string Message(Models.MessageModel msg)
        {
            var objEncryptDecrypt = EncryptinDecryptionHelperFile.DecryptStringAES(msg.Message);
            
            return objEncryptDecrypt;
        }
    }
}