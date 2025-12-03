using System.Net;
using Newtonsoft.Json;

namespace MyEpicBTCCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getRate_Click(object sender, EventArgs e)
        {
            try
            {
                if (currencySelector.SelectedItem.ToString() != "USD" &&
                    currencySelector.SelectedItem.ToString() != "EUR" ||
                    currencySelector.SelectedItem == null
                    )
                {
                    MessageBox.Show("Error", "VALUUTA ON VALIMATA");
                }
                else if (currencySelector.SelectedItem.ToString() == "USD")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoingAmountInput.Text) * newRate.Data.BTCUSD.VALUE);
                    bitcoinResultLabel.Text = result.ToString();
                }
                else if (currencySelector.SelectedItem.ToString() == "EUR")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoingAmountInput.Text) * newRate.Data.BTCEUR.VALUE);
                    bitcoinResultLabel.Text = result.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tekkis viga, veadetailid: {ex.Message}", $"{ex}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static BitcoinRates BitcoinRates()
        {
            string URL = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR&apply_mapping=true&api_key=121694019ded9aec6e3cf81b7f5d5587abda0a35590b9b19e18eca3490fe05f3";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            var webRespose = request.GetResponse();
            var webStream = webRespose.GetResponseStream();

            BitcoinRates newbitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                newbitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return newbitcoin;
        }



    }
}
