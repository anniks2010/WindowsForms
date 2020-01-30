using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private async void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Amount_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Conv_btn_Click(object sender, EventArgs e)
        {


            
            double insertedAmount = double.Parse(amount_txt.Text);
            double conver;
            

            string url = "http://data.fixer.io/api/latest?access_key=1240e630c73884ecda1ba3a7d19dfc80";


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();


            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd(); ////panen valmis koha, kuhu maha lugeda, mis on olemas vastuses
                CurrencyData currencyData = JsonConvert.DeserializeObject<CurrencyData>(response);
                

                display_date.Text = ($"Date: {currencyData.Date}");
                

                if (fromcombo1.SelectedItem == "USD" && tocombo2.SelectedItem == "EUR")
                {
                    conver = Math.Round((insertedAmount / currencyData.rates.USD), 2);
                    display_txt.Text = ($"Converted Amount: {conver} €");
                }
                else if (fromcombo1.SelectedItem == "SEK" && tocombo2.SelectedItem == "EUR")
                {
                    conver = Math.Round((insertedAmount / currencyData.rates.SEK), 2);
                    display_txt.Text = ($"Converted Amount: {conver} €");
                }
                else if (fromcombo1.SelectedItem == "AUD" && tocombo2.SelectedItem == "EUR")
                {
                    conver = Math.Round((insertedAmount / currencyData.rates.AUD),2);
                    display_txt.Text = ($"Converted Amount: {conver} €");
                }
                else if (fromcombo1.SelectedItem == "RUB" && tocombo2.SelectedItem == "EUR")
                {
                    conver = Math.Round( (insertedAmount / currencyData.rates.RUB),2);
                    display_txt.Text = ($"Converted Amount: {conver} €");
                }
                else if (fromcombo1.SelectedItem == "PLN" && tocombo2.SelectedItem == "EUR")
                {
                    conver = Math.Round((insertedAmount / currencyData.rates.PLN), 2);
                    display_txt.Text = ($"Converted Amount: {conver} €");
                }

            }
            
        }


    }
}


    





