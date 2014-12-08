using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LoaderIOVerifier
{
    public class Responder : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["LoaderIOKey"]))
            {
                if (context.Request.Url.AbsolutePath == "/loaderio-" + ConfigurationManager.AppSettings["LoaderIOKey"] + ".txt")
                {
                    context.Response.ContentType = "text/plain";
                    context.Response.Write("loaderio-" + ConfigurationManager.AppSettings["LoaderIOKey"]);
                    context.Response.End();
                }
            }

            context.Response.Status = "404 Not Found";
            context.Response.End();
            
        }
    }
}
