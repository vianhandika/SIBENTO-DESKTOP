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

namespace SIBENTO
{
    public partial class UCSparepart : UserControl
    {
        private List<Sparepart> ListSparepart = new List<Sparepart>();
        //private List<Employee> DGModel = new List<Employee>();
        private List<DGSparepartModel> DGModel = new List<DGSparepartModel>();
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
            LoadSparepartAsync();
        }

        class DGSparepartModel
        {
            public string id { get; set; }
            public string name { get; set; }
            public string brand { get; set; }
            public string min_stock { get; set; }
            public string stock { get; set; }
            
        }

        private async Task LoadSparepartAsync()
        {
            JObject json = await ApiClient.SendGetRequest("https://sibento.yafetrakan.com/api/sparepart");

            JToken arrSparepart = json.GetValue("data");
            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();

                //MessageBox.Show(jError.ToString(), "Error ..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (JToken dataSparepart in arrSparepart.AsEnumerable<JToken>())
                {
                    //Employee employee = (Employee) dataEmloyee.ToObject(typeof(Employee));

                    ListSparepart.Add((Sparepart)dataSparepart.ToObject(typeof(Sparepart)));

                }
                foreach (Sparepart data in ListSparepart)
                {
                    DGModel.Add(
                        (new DGSparepartModel
                        {
                            id = data.id,
                            name = data.name,
                            brand = data.brand,
                            min_stock = data.min_stock,
                            stock = data.stock,
                            
     
                        }));
                }

                //DGModel = ListEmployee;
                Console.WriteLine($"ListEmployee");
                //DGEmployee.DataSource = ListEmployee;
                DGSparepart.DataSource = DGModel;
                DGSparepart.Columns[0].HeaderText = "ID";
                DGSparepart.Columns[0].Width = 150;

                DGSparepart.Columns[1].HeaderText = "Nama Sparepart";
                DGSparepart.Columns[2].HeaderText = "Merk";
                DGSparepart.Columns[3].HeaderText = "Minimal Stok";
                DGSparepart.Columns[4].HeaderText = "Stok";
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            UCSparepartForm.Instance.BringToFront();
        }
    }
}
