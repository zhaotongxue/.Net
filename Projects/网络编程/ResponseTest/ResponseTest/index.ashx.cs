using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ResponseTest
{
    /// <summary>
    /// index1 的摘要说明
    /// </summary>
    public class index1 : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string t2 = context.Request.QueryString["t"].ToString();
            //StreamWriter s = new StreamWriter(@"E:\a.txt",true);
            //s.WriteLine("reequest.querystring:" + t2);
            //s.Close();
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = System.Text.Encoding.Default;
            context.Response.Write(t2.ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}