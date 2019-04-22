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
using System.Diagnostics;

namespace SIBENTO
{
    public partial class UCServiceForm : UserControl
    {
        private static UCServiceForm _instance;
        static HttpClient client = new HttpClient();
        int ID;
        public static UCServiceForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCServiceForm();
                return _instance;
            }
        }

        public void transactionData(Dictionary<string, string> data)
        {
            ID = Int32.Parse(data["id_service"]);
            txtService.Text = data["name_service"];
            txtHarga.Text = data["price_service"];


        }

        public UCServiceForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
        }

        private async Task AddServiceAsync(Dictionary<string, string> body)
        {
            JObject json = await ApiClient.SendPostRequest(body, "http://sibento.yafetrakan.com/api/service");

            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();

            }
            else
            {
                JToken respond = json.GetValue("success").Value<JToken>("data");
                //string info = json.GetValue("success").Value<string>("info");
                Service service = (Service)respond.ToObject(typeof(Service));
                UCJasaService.Instance.loadService();
                //MessageBox.Show(info, "Info ..", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private async Task EditServiceAsync(Dictionary<string, string> body, int id)
        {
            Debug.WriteLine("http://sibento.yafetrakan.com/api/service/" + id);
            JObject json = await ApiClient.SendPutRequest(body, "http://sibento.yafetrakan.com/api/service/" + id);


            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                Debug.WriteLine(" contain eror");
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                //int count = jError.Children().Count<JToken>();

            }
            else
            {
                Debug.WriteLine("not contain eror");
                JToken dataService = json.GetValue("data");
                Service service = (Service)dataService.ToObject(typeof(Service));
                //Debug.WriteLine(service);

                UCJasaService.Instance.loadService();

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
            //Random random = new Random();
            Dictionary<string, string> values = new Dictionary<string, string>();

            values.Add("name_service", txtService.Text);
            values.Add("price_service", txtHarga.Text);

            if (!string.IsNullOrWhiteSpace(txtHarga.Text) && !string.IsNullOrWhiteSpace(txtService.Text))
            {
                if (ID != 0)
                {
                    Debug.WriteLine("edit");
                    EditServiceAsync(values, ID);
                    MessageBox.Show("Data Telah Diedit");
                }
                else
                {
                    Debug.WriteLine("tambah");
                    AddServiceAsync(values);
                    MessageBox.Show("Data Telah Ditambahkan");
                }

                clearInput();
            }
            else
            {
                MessageBox.Show("Masih Ada Inputan Yang Kosong Silahkan Cek Kembali");
            }
        }
        public void setEditNull()
        {
            ID = 0;
            clearInput();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //((Form)this.TopLevelControl).Close();
            //UCPegawaiForm someForm = (UCPegawaiForm)this.Parent;
            //someForm.Close();
            ID = 0;
            clearInput();
            UCJasaService.Instance.loadService();
            UCJasaService.Instance.BringToFront();
            //UCPegawaiForm.Instance.Hide();

        }
    }
}
