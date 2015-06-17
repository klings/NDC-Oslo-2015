using System.Web.Mvc;
using NdcOsloDemo2015.ViewModels;
using NWebsec.Mvc.HttpHeaders;
using NWebsec.Mvc.HttpHeaders.Csp;

namespace NdcOsloDemo2015.Controllers
{
    public class FrameController : Controller
    {
        public ActionResult Index()
        {
            var message = new FrameMessage { Message = "No frame protection enabled." };
            return View("Frame", message);
        }

        [XFrameOptions]
        public ActionResult Xfo()
        {
            var message = new FrameMessage { Message = "X-Frame-Options enabled." };

            return View("Frame", message);
        }

        [Csp, CspFrameAncestors(None = true)]
        public ActionResult Csp()
        {
            var message = new FrameMessage { Message = "CSP frame-ancestors directive enabled." };

            return View("Frame", message);
        }
    }
}