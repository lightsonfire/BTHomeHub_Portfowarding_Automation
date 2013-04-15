using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Li_Port_Foward.Web
{
    class CookieWebClient : WebClient
    {
        public CookieWebClient()
            : this(new CookieContainer())
        { }
        public CookieWebClient(CookieContainer c)
        {
            this.CookieContainer = c;
        }
        public CookieContainer CookieContainer { get; set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);

            var castRequest = request as HttpWebRequest;
            if (castRequest != null)
            {
                castRequest.CookieContainer = this.CookieContainer;
            }

            return request;
        }
    }
}
