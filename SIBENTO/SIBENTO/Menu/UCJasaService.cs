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

namespace SIBENTO
{
    public partial class UCJasaService : UserControl
    {
        private List<Service> ListService = new List<Service>();
        //private List<Employee> DGModel = new List<Employee>();
        private List<DGServiceModel> DGModel = new List<DGServiceModel>();
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
            LoadServiceAsync();
        }

        class DGServiceModel
        {
            public int id_service { get; set; }
            public string name_service { get; set; }
            public string price_service { get; set; }
        }

        private async Task LoadServiceAsync()
        {
            JObject json = await ApiClient.SendGetRequest("https://sibento.yafetrakan.com/api/service");

            JToken arrService = json.GetValue("data");
            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();

                //MessageBox.Show(jError.ToString(), "Error ..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (JToken dataService in arrService.AsEnumerable<JToken>())
                {
                    //Employee employee = (Employee) dataEmloyee.ToObject(typeof(Employee));

                    ListService.Add((Service)dataService.ToObject(typeof(Service)));

                }
                foreach (Service data in ListService)
                {
                    DGModel.Add(
                        (new DGServiceModel
                        {
                            id_service = data.id_service,
                            name_service = data.name_service,
                            price_service = data.price_service,


                        }));
                }

                //DGModel = ListEmployee;
                Console.WriteLine($"ListEmployee");
                //DGEmployee.DataSource = ListEmployee;
                DGService.DataSource = DGModel;
                DGService.Columns[0].HeaderText = "ID";
                DGService.Columns[0].Width = 50;

                DGService.Columns[1].HeaderText = "Nama Jasa";
                DGService.Columns[2].HeaderText = "Harga";

            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            UCServiceForm.Instance.BringToFront();
        }
    }
}
