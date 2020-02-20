using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Handlers;
using System.Net.Http;
using System.Xml;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace HartLeeCE03
{

    public partial class Form1 : Form
    {
        HttpClient invoiceHttp = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            AccessToken();


        }
        /* public async void getPostString()

          {

              HttpClient http = new HttpClient();

              string orgNumber = "679273514";
              string oauth = "c175f8f37837b2b345059de18f2fc207";
              string clientId = "1000.DDEI2SY4E2WNKL4XYX2H6O97P0EWBH";
              string cSecret = "9a98f4678898a8746afc2285ce5e799ae0ddca2731";
              string refresh;
              http.DefaultRequestHeaders.Add("oauthtoken", oauth);
              http.DefaultRequestHeaders.Add("organization_id", orgNumber);
              http.BaseAddress = new Uri("https://accounts.zoho.com/oauth/v2/auth");
              string contentType = "application/json";
              http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(contentType));
              string scope = @"ZohoInvoice.invoices.CREATE,ZohoInvoice.invoices.READ,ZohoInvoice.invoices.UPDATE,ZohoInvoice.invoices.DELETE";


              http.BaseAddress = new Uri(http.BaseAddress, $@"?scope={scope}&client_id={clientId}&response_type=code&redirect_uri=http://www.zoho.com/invoice&access_type=offline");
              string call = http.BaseAddress.ToString();

                  MessageBox.Show(call);
              string headers = http.DefaultRequestHeaders.ToString();
              HttpResponseMessage message = await http.GetAsync(call);
              MessageBox.Show(headers);
              string mess = await message.Content.ReadAsStringAsync();
              MessageBox.Show(message.ReasonPhrase.ToString());
              MessageBox.Show(mess);



          }

      
        public async void GetRefresh()
        {
            string orgNumber = "679273514";
            string oauth = "c175f8f37837b2b345059de18f2fc207";
            string clientId = "1000.DDEI2SY4E2WNKL4XYX2H6O97P0EWBH";
            string cSecret = "9a98f4678898a8746afc2285ce5e799ae0ddca2731";
            string refresh;

            invoiceHttp = new HttpClient();
            HttpContent content = new HttpContent1();
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            
            invoiceHttp.DefaultRequestHeaders.Add("oauthtoken", oauth);
            invoiceHttp.DefaultRequestHeaders.Add("organization_id", orgNumber);
            string call = "https://accounts.zoho.com/oauth/v2/token?code=1000.c63ff7f7ef3cc453f7eeb5d2525190c0.9162753ac1dead2b945fba4057d448dc&client_id=1000.DDEI2SY4E2WNKL4XYX2H6O97P0EWBH&client_secret=9a98f4678898a8746afc2285ce5e799ae0ddca2731&redirect_uri=http://www.zoho.com/invoice&grant_type=authorization_code";
            HttpResponseMessage message;
            string mess;
            try
            {
                message = await invoiceHttp.PostAsync(call, content);
                mess = await message.Content.ReadAsStringAsync();
                MessageBox.Show(message.ReasonPhrase.ToString());
                MessageBox.Show(mess);
            } catch(Exception e) { MessageBox.Show(e.ToString());}
           
           
        }

    
    */

        void  AccessToken()
        {
            
            
            
            string refreshToken = "https://accounts.zoho.com/oauth/v2/token?refresh_token=1000.1ca2de41e469c5bfaefea673026d940a.802373a88487f1dee1acdd12902227bd&client_id=1000.DDEI2SY4E2WNKL4XYX2H6O97P0EWBH&client_secret=9a98f4678898a8746afc2285ce5e799ae0ddca2731&redirect_uri=http://www.zoho.com/invoice&grant_type=refresh_token";
            HttpClient apiCall = new HttpClient();
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(refreshToken);
            
            httpRequest.Headers.Add("oauthtoken", "c175f8f37837b2b345059de18f2fc207");
            httpRequest.Headers.Add("organization_id", "679273514");
            //  apiCall.DefaultRequestHeaders.Add("oauthtoken", "c175f8f37837b2b345059de18f2fc207");
            // apiCall.DefaultRequestHeaders.Add("organization_id", "679273514" );
            httpRequest.Method = "POST";
            
            try
            {
                HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {

                    string whatisThis = reader.ReadToEnd().ToString();
                    MessageBox.Show(whatisThis);

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
              
            }
            
            
        }
    }
}
