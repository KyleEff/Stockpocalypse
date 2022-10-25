using Stock_Program;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace StockForms.Extra_API
{
    public static class ApiProcessor
    {
        public static async Task<StockListModel> LoadStockList(string Exchange)
        {
            var URL = $"https://api.twelvedata.com/stocks/?exchange={ Exchange }";
            var request = new HttpRequestMessage(HttpMethod.Get, URL);

            ApiHelper.initClient();

            using (HttpResponseMessage response = await ApiHelper.ApiClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var Stocks = await response.Content.ReadFromJsonAsync<StockListModel>();

                    return Stocks;
                }
                else { MessageBox.Show("OOOOOOOOOOOOOOOOOPS"); return null; }
            }   
        }
    }
}
