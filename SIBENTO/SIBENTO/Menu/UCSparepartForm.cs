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
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SIBENTO
{
    public partial class UCSparepartForm : UserControl
    {
        private static UCSparepartForm _instance;
        static HttpClient client = new HttpClient();

        public static UCSparepartForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCSparepartForm();
                return _instance;
            }
        }

        public UCSparepartForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://sibento.yafetrakan.com/");
            dropdownLoad();
        }

        private async void dropdownLoad()
        {
            //disableInput();
          
            //load combobox jabatan
            cmbTipe.DataSource = await GetTipe();
            cmbTipe.ValueMember = "id";
            cmbTipe.DisplayMember = "name";
        }

        static async Task<DataTable> GetTipe()
        {
            //Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/spareparttype");

            var arr = await response.Content.ReadAsStringAsync();
            DataTable DT = new DataTable();
            DT = json_convert(arr);
            Debug.WriteLine(DT.Rows.Count);
            
            return DT;
        }
        
        public static DataTable json_convert(string json)
        {
            JObject json_object = JObject.Parse(json);

            DataTable dt = new DataTable();

            JArray json_array = JArray.Parse(json_object["data"].ToString());
            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }
    }
}
