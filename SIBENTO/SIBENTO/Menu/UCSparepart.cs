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
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;

namespace SIBENTO
{
    public partial class UCSparepart : UserControl
    {
        private List<Sparepart> DefaultListSparepart = new List<Sparepart>();
        private List<DGSparepartModel> DefaultDGModel = new List<DGSparepartModel>();
        private List<Sparepart> ListSparepart = new List<Sparepart>();
        //private List<Employee> DGModel = new List<Employee>();
        private List<DGSparepartModel> DGModel = new List<DGSparepartModel>();
        static HttpClient client = new HttpClient();
        private static UCSparepart _instance;

        public static UCSparepart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCSparepart();
                return _instance;
            }
        }

        public UCSparepart()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
            loadSparepart();
        }

        class DGSparepartModel
        {
            public string id { get; set; }
            public string name { get; set; }
            public string brand { get; set; }
            public string min_stock { get; set; }
            public string stock { get; set; }            
        }

        static async Task<DataTable> GetSparepart()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/sparepart");

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

        public async void loadSparepart()
        {
            //LoadEmployeeAsync();
            DataTable t = await GetSparepart();
            DGSparepart.DataSource = t;

            ListSparepart = (from DataRow dr in t.Rows
                             select new Sparepart()
                             {
                                 id = dr["id"].ToString(),
                                 name = dr["name"].ToString(),
                                 brand = dr["brand"].ToString(),
                                 type = dr["type"].ToString(),
                                 stock = dr["stock"].ToString(),
                                 min_stock = dr["min_stock"].ToString(),
                                 buy_price = dr["buy_price"].ToString(),
                                 sell_price = dr["sell_price"].ToString(),
                                 placement = dr["placement"].ToString(),
                                 placement_position = dr["placement_position"].ToString(),
                                 placement_place = dr["placement_place"].ToString(),
                                 placement_number = dr["placement_number"].ToString(),
                                 image = dr["image"].ToString()
                            }).ToList();

            t.Columns.Remove("type");
            t.Columns.Remove("buy_price");
            t.Columns.Remove("sell_price");
            t.Columns.Remove("placement");
            t.Columns.Remove("placement_position");
            t.Columns.Remove("placement_place");
            t.Columns.Remove("placement_number");
            t.Columns.Remove("image");

            DGSparepart.Columns[0].HeaderText = "ID";
            DGSparepart.Columns[0].Width = 150;
            DGSparepart.Columns[1].HeaderText = "Nama";
            DGSparepart.Columns[2].HeaderText = "Brand";
            DGSparepart.Columns[3].HeaderText = "Minimal Stock";
            DGSparepart.Columns[4].HeaderText = "Stock";
        }

        private async Task LoadSparepartAsync()
        {
            JObject json = await ApiClient.SendGetRequest("http://sibento.yafetrakan.com/api/sparepart");

            JToken arrSparepart = json.GetValue("data");
            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();
            }
            else
            {
                ListSparepart = DefaultListSparepart;
                foreach (JToken dataSparepart in arrSparepart.AsEnumerable<JToken>())
                {
                    ListSparepart.Add((Sparepart)dataSparepart.ToObject(typeof(Sparepart)));
                }
            }
        }

        private async Task DelSparepartAsync(string id)
        {
            JObject json = await ApiClient.SendDelRequest("http://sibento.yafetrakan.com/api/sparepart/" + id);
            Debug.WriteLine(json);
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            UCSparepartForm.Instance.BringToFront();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadSparepart();
        }

        private void btnDelSparepart_Click(object sender, EventArgs e)
        {
            int i = DGSparepart.CurrentCell.RowIndex;

            string id = DGSparepart[0, i].Value.ToString();
            DelSparepartAsync(id);
            loadSparepart();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)DGSparepart.DataSource).DefaultView.RowFilter = string.Format("Name like '%{0}%'", txtSearch.Text.Trim().Replace("'", "''"));
        }

        private void btnEdtSpareaprt_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            int i = DGSparepart.CurrentCell.RowIndex;

            string id = DGSparepart[0, i].Value.ToString();

            Sparepart dataSelected = ListSparepart.Where(obj => obj.id == id).First();
            values.Add("id", dataSelected.id.ToString());
            values.Add("name", dataSelected.name.ToString());
            values.Add("brand", dataSelected.brand.ToString());
            values.Add("type", dataSelected.type.ToString());
            values.Add("stock", dataSelected.stock.ToString());
            values.Add("min_stock", dataSelected.min_stock.ToString());
            values.Add("buy_price", dataSelected.buy_price.ToString());
            values.Add("sell_price", dataSelected.sell_price.ToString());
            values.Add("placement_number", dataSelected.placement_number.ToString());
            values.Add("image", dataSelected.image.ToString());
            values.Add("placement_position", dataSelected.placement_position.ToString());
            values.Add("placement_place", dataSelected.placement_place.ToString());

            UCSparepartForm.Instance.transactionData(values);
            UCSparepartForm.Instance.BringToFront();
        }
    }
}
