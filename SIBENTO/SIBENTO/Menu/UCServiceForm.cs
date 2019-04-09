using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using SIBENTO.Class.Utility;
using SIBENTO.Class.Model;

namespace SIBENTO
{
    public partial class UCServiceForm : UserControl
    {
        private static UCServiceForm _instance;
        static HttpClient client = new HttpClient();
        
        public static UCServiceForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCServiceForm();
                return _instance;
            }
        }

        public UCServiceForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://sibento.yafetrakan.com/");
        }

        private async Task AddServiceAsync(Dictionary<string, string> body)
        {
            JObject json = await ApiClient.SendPostRequest(body, "https://sibento.yafetrakan.com/api/service");

            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();

            }
            else
            {
                JToken respond = json.GetValue("success").Value<JToken>("data");
                string info = json.GetValue("success").Value<string>("info");
                Service service = (Service)respond.ToObject(typeof(Service));
                //MessageBox.Show(info, "Info ..", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }



        public void disableInput()
        {
            txtService.Enabled = false;
            txtHarga.Enabled = false;
        }

        public void enableInput()
        {
            txtService.Enabled = true;
            txtHarga.Enabled = true;
        }

        public void clearInput()
        {
            txtService.Text = "";
            txtHarga.Text = "";
        }
        
        private void btnSaveService_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Dictionary<string, string> values = new Dictionary<string, string>();
            
            values.Add("name_service", txtService.Text);
            values.Add("price_service", txtHarga.Text);
            AddServiceAsync(values);
            clearInput();
        }
    }
}
