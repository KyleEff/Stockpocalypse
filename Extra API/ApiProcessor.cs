using System;
using System.Net.Http;
using System.Net.Http.Json;
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

        // OBSOLETE
        /*
        public static async Task<StockListModel> LoadStockList(bool SignatureTrigger,
            string Ticker,
            string Exchange,
            string Mic,
            string Type
        ) {

            MessageBox.Show($"Ticker: {Ticker}\nExchange: { Exchange}\nMIC: {Mic}\nType: {Type}");

            var URL = $"https://api.twelvedata.com/stocks?";

            if (!Ticker.Equals(String.Empty)) {

                MessageBox.Show("TICKKEEERRRRR");
                URL += ($"symbol={Ticker}&");
            }

            if (!Exchange.Equals(String.Empty))
                URL += $"exchange={Exchange}&";

            if (!Mic.Equals(String.Empty))
                URL += $"mic_code={Mic}&";

            if (Type != String.Empty)
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
        */

        // CURRENT
        public static async Task<StockListModel> LoadStockList(Stock searchStock) {

            MessageBox.Show(
                $"Ticker: {searchStock.Symbol}\n" +
                $"Exchange: {searchStock.Exchange}\n" +
                $"MIC: {searchStock.Mic_code}\n" +
                $"Type: {searchStock.Type}");

            var URL = $"https://api.twelvedata.com/stocks?";

            if (!searchStock.Symbol.Equals(String.Empty))
            {
                MessageBox.Show("TICKKEEERRRRR");
                URL += ($"symbol={searchStock.Symbol}&");
            }

            if (!searchStock.Exchange.Equals(String.Empty))
                URL += $"exchange={searchStock.Exchange}&";

            if (!searchStock.Mic_code.Equals(String.Empty))
                URL += $"mic_code={searchStock.Mic_code}&";

            if (!searchStock.Type.Equals(String.Empty))
                URL += $"type={searchStock.Type}";

            var request = new HttpRequestMessage(HttpMethod.Get, URL);

            ApiHelper.initClient();

            MessageBox.Show(URL);

            using (HttpResponseMessage response = await ApiHelper.ApiClient.SendAsync(request))
            {

                if (response.IsSuccessStatusCode)
                {

                    var Stocks = await response.Content.ReadFromJsonAsync<StockListModel>();

                    return Stocks;
                }
                else { MessageBox.Show("What what"); return null; }
            }
        }
        

    }
}
