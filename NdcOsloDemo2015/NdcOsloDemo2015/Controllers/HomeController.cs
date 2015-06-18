using System.Web.Mvc;
using NdcOsloDemo2015.ViewModels;
using NWebsec.Mvc.HttpHeaders.Csp;

namespace NdcOsloDemo2015.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Xfo()
        {
            return View();
        }

        public ActionResult XfoMvc()
        {
            return View();
        }

        //[Csp, CspDefaultSrc(None = true)]
        //[Csp, CspDefaultSrc(Self = true)]
        //[CspStyleSrc(Self = true, UnsafeInline = true)]
        //[CspScriptSrc(Self = true, UnsafeInline = true)]
        public ActionResult Csp()
        {
            return View();
        }

        [Csp, CspDefaultSrc(Self = true), CspScriptSrc(Self = true), CspStyleSrc(Self = true, UnsafeInline = true)]
        [CspBaseUri(None = true)]
        [CspChildSrc(None = true)]
        [CspFormAction(None = true)]
        [CspFrameAncestors(None = true)]
        [CspPluginTypes(MediaTypes = "application/pdf")]
        [CspSandbox]
        public ActionResult Csp2()
        {
            return View();
        }

        public ActionResult Tls()
        {
            var details = new ConnectionDetails
            {
                SecureConnection = Request.IsSecureConnection
            };

            return View(details);
        }

        [RequireHttps]
        public ActionResult TlsRequireHttps()
        {
            var details = new ConnectionDetails
            {
                RequireHttps = true,
                SecureConnection = Request.IsSecureConnection
            };

            return View("Tls", details);
        }
    }
}