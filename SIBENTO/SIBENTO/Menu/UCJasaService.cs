using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIBENTO.Class.Model;
using SIBENTO.Class.Utility;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SIBENTO
{
    public partial class UCJasaService : UserControl
    {

        private List<Service> DefaultListService = new List<Service>();
        private List<DGServiceModel> DefaultDGModel = new List<DGServiceModel>();

        private List<Service> ListService = new List<Service>();
        //private List<Service> DGModel = new List<Service>();
        private List<DGServiceModel> DGModel = new List<DGServiceModel>();
        BindingSource DGBindService = new BindingSource();
        static HttpClient client = new HttpClient();

        private static UCJasaService _instance;

        public static UCJasaService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCJasaService();
                return _instance;
            }
        }

        public UCJasaService()
        {
            InitializeComponent();
            //LoadServiceAsync();
            client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
            loadService();
        }

        class DGServiceModel
        {
            public int id_service { get; set; }
            public string name_service { get; set; }
            public string price_service { get; set; }
        }

        public async void loadService()
        {
            //LoadServiceAsync();
            DataTable t = await GetService();
            DGService.DataSource = t;

            ListService = (from DataRow dr in t.Rows
                            select new Service()
                            {
                                id_service = Convert.ToInt32(dr["id_service"]),
                                name_service = dr["name_service"].ToString(),
                                price_service = dr["price_service"].ToString(),
                            }).ToList();

            DGService.Columns[0].HeaderText = "ID";
            DGService.Columns[0].Width = 50;
            DGService.Columns[1].HeaderText = "Nama Jasa";
            DGService.Columns[2].HeaderText = "Harga";

        }

        static async Task<DataTable> GetService()
        {
            //Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/service");

            var a = await response.Content.ReadAsStringAsync();

            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        public static DataTable json_convert(string json)
        {
            JObject json_object = JObject.Parse(json);


            DataTable dt = new DataTable();

            JArray json_array = JArray.Parse(json_object["data"].ToString());

            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            UCServiceForm.Instance.setEditNull();
            UCServiceForm.Instance.BringToFront();

        }

        private void btnEdtService_Click(object sender, EventArgs e)
        {


            Dictionary<string, string> values = new Dictionary<string, string>();
            int i = DGService.CurrentCell.RowIndex;

            int id = Int32.Parse(DGService[0, i].Value.ToString());

            Service dataSelected = ListService.Where(obj => obj.id_service == id).First();
            values.Add("id_service", dataSelected.id_service.ToString());
            values.Add("name_service", dataSelected.name_service.ToString());
            values.Add("price_service", dataSelected.price_service.ToString());

            UCServiceForm.Instance.transactionData(values);
            UCServiceForm.Instance.BringToFront();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //LoadServiceAsync();
            loadService();

        }

        private async Task DelServiceAsync(int id)
        {
            JObject json = await ApiClient.SendDelRequest("http://sibento.yafetrakan.com/api/service/" + id);
            Debug.WriteLine(json);
        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            int i = DGService.CurrentCell.RowIndex;

            int id = Int32.Parse(DGService[0, i].Value.ToString());
            DelServiceAsync(id);
            loadService();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //this code is used to search Name on the basis of txttxtSearchItem.text
                ((DataTable)DGService.DataSource).DefaultView.RowFilter = string.Format("Name_Service like '%{0}%'", txtSearch.Text.Trim().Replace("'", "''"));
            }
            catch (Exception) { }
        }

    }
}
