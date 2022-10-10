using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinDispenserAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void submitBTN_ClickAsync(object sender, EventArgs e)
        {
            //calling submitBTN method for button click event
            _ = submitBTNAsync();
        }
        //setting global variable to be updated along the flow of executions
        string amountPaid;
        private async Task submitBTNAsync()
        {
            //Ensuring that we reset labels message
            
            msgLBL.Text = "";
            rsltLBL.Text = "";
           //defining variabe for amount input
            amountPaid = amntTXT.Text;

            //checking if the amount is a valid input for money
            if (!CheckValidAmount(amountPaid) || amntTXT.Text == "")
            {
                //assign label text a message to user when amount entered is invalid
                msgLBL.Text = "Please enter Valid Amount! ";
                //Getting input for valid amount until user provide correct input
                amountPaid = amntTXT.Text;

            }
            else
            {
                amountPaid = amntTXT.Text;
                //defining url for Rest Service, with a parameter for CoinDenmination ID(getting denominations saved on database)
                //second parameter is amountPaid for Amount to be changed into coins
                var url = "https://localhost:5001/api/CoinDenomination/1/" + amountPaid;




                //HttpClient for sending HTTP requests and receiving HTTP responses from a url.
                HttpClient httpClient = new HttpClient();
                //HttpRequestMessage representing http request(allowing us to add parameters e.g header, method, RequestUri
                HttpRequestMessage request = new HttpRequestMessage();
                request.RequestUri = new Uri(url);
                request.Method = HttpMethod.Get;
                request.Headers.Add("ApiKey", "C1o2i3n4D5i6s7p8e9n10s11e12r");
                //Getting response from request
                HttpResponseMessage response = await httpClient.SendAsync(request);

                //if request is successful
                if (response.IsSuccessStatusCode)
                {
                    // Getting the value of the response
                    var responseString = await response.Content.ReadAsStringAsync();
                    //assigning the value to display on win Form
                    rsltLBL.Text = responseString;

                }
                else
                {
                    // for the failed request, we assign error message to msgLBL to display for user on winForm
                    msgLBL.Text = "Error occured calling service " + (int)response.StatusCode + " " + response.ReasonPhrase;
                }
            }

        }

        // CheckValidAmount method validating input
        static bool CheckValidAmount(string amount)
        {
            //defining variable to tryparse to from the input
            double amountParsed;
            //validating
            bool parsed = double.TryParse(amount, out amountParsed);
            if (parsed && amountParsed >= 0.0)
            {
                // return true if input is valid
                return true;
            }
            //returning false if input is not valid
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clearing form onload
            amntTXT.Text = "";
            msgLBL.Text = "";
            rsltLBL.Text = "";
        }

        private void clrBTN_Click(object sender, EventArgs e)
        {
            //clearing form by button click
            amntTXT.Text = "";
            msgLBL.Text = "";
            rsltLBL.Text = "";
        }
    }
}
