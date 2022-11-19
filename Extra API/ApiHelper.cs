using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.Extra_API
{
    /*
     * This class is to open up a HTTP connection using a public static client variable;
     *  Either the connection is being messed up, or I have simply replaced this class
     *  with a simple new keyword statement. This class is obsolete.
     */

    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void initClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
           ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
