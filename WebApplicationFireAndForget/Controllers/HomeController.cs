using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationFireAndForget.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            await Task.Delay(100);

            Task t = StartAsyncStuffAndDontWaitForIt();

            return View();
        }

        async Task StartAsyncStuffAndDontWaitForIt()
        {
            await Task.Delay(5000);
            await Task.Delay(5000);
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
    }
}