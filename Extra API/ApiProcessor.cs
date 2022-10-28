using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockForms.ResultModels;

namespace StockForms.Extra_API
{
    public static class ApiProcessor
    {
        public static async Task<StockListModel> LoadStockList(string Exchange = "NYSE")
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

        public static async Task<StockListModel> LoadStockList(bool SignatureTrigger,
            string Ticker,
            string Exchange,
            string Mic,
            string Type
        ) {

            MessageBox.Show($"Ticker: {Ticker}\nExchange: { Exchange}\nMIC: {Mic}\nType: {Type}");

            var URL = $"https://api.twelvedata.com/stocks?";

            if (Ticker != default) {

                MessageBox.Show("TICKKEEERRRRR");
                URL += ($"symbol={Ticker}&");
            }

            if (Exchange != default)
                URL += $"exchange={Exchange}&";

            if (Mic != default)
                URL += $"mic_code={Mic}&";

            if (Type != default)
                URL += $"type={Type}";

            var request = new HttpRequestMessage(HttpMethod.Get, URL);

            ApiHelper.initClient();

            MessageBox.Show(URL);

            using (HttpResponseMessage response = await ApiHelper.ApiClient.SendAsync(request)) { 
            
                if (response.IsSuccessStatusCode) {

                    var Stocks = await response.Content.ReadFromJsonAsync<StockListModel>();

                    return Stocks;
                }
                else { MessageBox.Show("What what"); return null; }
            }

        }
    }
}
