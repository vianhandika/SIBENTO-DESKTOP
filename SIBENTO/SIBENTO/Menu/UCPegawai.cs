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

namespace SIBENTO
{
    public partial class UCPegawai : UserControl
    {
        private List<Employee> ListEmployee = new List<Employee>();
        //private List<Employee> DGModel = new List<Employee>();
        private List<DGEmployeeModel> DGModel = new List<DGEmployeeModel>();
        private static UCPegawai _instance;

        //public void DGRefresh()
        //{
          //  DGEmployee.DataSource.IsLiveSorting = true;
           // DGEmployee.DataSource.Refresh();
           // DGEmployee.DataSource.IsLiveSorting = false;
       // }

        public static UCPegawai Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCPegawai();
                return _instance;
            }
        }
        public UCPegawai()
        {
            InitializeComponent();
            LoadEmployeeAsync();
        }

        class DGEmployeeModel
        {
            public int id_employee { get; set; }
            public string name_employee { get; set; }
            public string phone_number_employee { get; set; }
            public string role_employee { get; set; }
            public string branch_employee { get; set; }
        }



        private async Task LoadEmployeeAsync()
        {
            JObject json = await ApiClient.SendGetRequest("https://sibento.yafetrakan.com/api/employee");
            
            JToken arrEmployee = json.GetValue("data");
            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();
              
                //MessageBox.Show(jError.ToString(), "Error ..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (JToken dataEmloyee in arrEmployee.AsEnumerable<JToken>())
                {
                    //Employee employee = (Employee) dataEmloyee.ToObject(typeof(Employee));

                    ListEmployee.Add((Employee) dataEmloyee.ToObject(typeof(Employee)));
                    
                }
                foreach (Employee data in ListEmployee)
                {
                    DGModel.Add(
                        (new DGEmployeeModel{
                            id_employee = data.id,
                            name_employee = data.name,
                            phone_number_employee = data.phone_number,
                            role_employee = data.role,
                            branch_employee = data.branch,


                        }));
                }

                //DGModel = ListEmployee;
                Console.WriteLine($"ListEmployee");
                //DGEmployee.DataSource = ListEmployee;
                DGEmployee.DataSource = DGModel;
                DGEmployee.Columns[0].HeaderText = "ID";
                DGEmployee.Columns[0].Width = 50;

                DGEmployee.Columns[1].HeaderText = "Nama";
                DGEmployee.Columns[2].HeaderText = "Nomor Telepon";
                DGEmployee.Columns[3].HeaderText = "Jabatan";
                DGEmployee.Columns[4].HeaderText = "Cabang";

            }
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            UCPegawaiAdd.Instance.transactionData("Wow");
            UCPegawaiAdd.Instance.BringToFront();
          
        }
    }
}
