using Microsoft.Owin;
using NdcOsloDemo2015;
using NWebsec.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace NdcOsloDemo2015
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseHpkp(options =>
            //{
            //    options.MaxAge(1);
            //    options.PinCertificate("ca 44 ec 87 d0 99 63 0d 39 09 0a 3b 15 26 95 ff 1d 62 36 86");
            //    options.Sha256Pins("254OgZiLmw4AfWfKqMZ+rgLE+hTJDdxeNiWQ0syr21k="); //Mandatory backup pin

            //});
        }
    }
}
