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
using System.Diagnostics;
using Newtonsoft.Json;

namespace SIBENTO
{
    public partial class UCPegawai : UserControl
    {
        private List<Employee> DefaultListEmployee = new List<Employee>();
        private List<DGEmployeeModel> DefaultDGModel = new List<DGEmployeeModel>();

        private List<Employee> ListEmployee = new List<Employee>();
        //private List<Employee> DGModel = new List<Employee>();
        private List<DGEmployeeModel> DGModel = new List<DGEmployeeModel>();
        BindingSource DGBindEmployee = new BindingSource();
        static HttpClient client = new HttpClient();


        private static UCPegawai _instance;


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
            client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
            loadEmployee();
            //LoadEmployeeAsync();

        }

        class DGEmployeeModel
        {
            public int id_employee { get; set; }
            public string name_employee { get; set; }
            public string phone_number_employee { get; set; }
            public string role_employee { get; set; }
            public string branch_employee { get; set; }
        }

        public async void loadEmployee()
        {
            //LoadEmployeeAsync();
            DataTable t = await GetPegawai();
            DGEmployee.DataSource = t;

            ListEmployee = (from DataRow dr in t.Rows
                           select new Employee()
                           {
                               id = Convert.ToInt32(dr["id"]),
                               name = dr["name"].ToString(),
                               phone_number = dr["phone_number"].ToString(),
                               address = dr["address"].ToString(),
                               salary = dr["salary"].ToString(),
                               role = dr["role"].ToString(),
                               branch = dr["branch"].ToString(),

                           }).ToList();
            t.Columns.Remove("salary");
            t.Columns.Remove("address");
            DGEmployee.Columns[0].HeaderText = "ID";
            DGEmployee.Columns[0].Width = 50;
            DGEmployee.Columns[1].HeaderText = "Nama";
            DGEmployee.Columns[2].HeaderText = "Nomor Telepon";
            DGEmployee.Columns[3].HeaderText = "Jabatan";
            DGEmployee.Columns[4].HeaderText = "Cabang";
        }

        static async Task<DataTable> GetPegawai()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/employee");

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

        private async Task LoadEmployeeAsync()
        {
            JObject json = await ApiClient.SendGetRequest("http://sibento.yafetrakan.com/api/employee");
            
            JToken arrEmployee = json.GetValue("data");
            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();
              
                //MessageBox.Show(jError.ToString(), "Error ..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ListEmployee = DefaultListEmployee;
                foreach (JToken dataEmloyee in arrEmployee.AsEnumerable<JToken>())
                {
                    //Employee employee = (Employee) dataEmloyee.ToObject(typeof(Employee));

                    ListEmployee.Add((Employee) dataEmloyee.ToObject(typeof(Employee)));
                    
                }
              /*  DGModel = DefaultDGModel;
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

                DGModel = ListEmployee;
                Console.WriteLine($"ListEmployee");
                DGEmployee.DataSource = ListEmployee;
               DGBindEmployee.DataSource = DGModel;
                DGEmployee.DataSource = DGBindEmployee;
                DGEmployee.Columns[0].HeaderText = "ID";
                DGEmployee.Columns[0].Width = 50;
                DGEmployee.Columns[1].HeaderText = "Nama";
                DGEmployee.Columns[2].HeaderText = "Nomor Telepon";
                DGEmployee.Columns[3].HeaderText = "Jabatan";
                DGEmployee.Columns[4].HeaderText = "Cabang";
                */
            }
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            UCPegawaiForm.Instance.BringToFront();

        }

        private void btnEdtEmployee_Click(object sender, EventArgs e)
        {
            
            
            Dictionary<string, string> values = new Dictionary<string, string>();
            int i = DGEmployee.CurrentCell.RowIndex;

            int id = Int32.Parse(DGEmployee[0, i].Value.ToString());

            Employee dataSelected = ListEmployee.Where(obj => obj.id == id).First();
            values.Add("id", dataSelected.id.ToString());
            values.Add("name", dataSelected.name.ToString());
            values.Add("phone_number", dataSelected.phone_number.ToString());
            values.Add("address", dataSelected.address.ToString());
            values.Add("salary", dataSelected.salary.ToString());
            values.Add("branch", dataSelected.branch.ToString());
            values.Add("role", dataSelected.role.ToString());

            UCPegawaiForm.Instance.transactionData(values);
            UCPegawaiForm.Instance.BringToFront();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //LoadEmployeeAsync();
            loadEmployee();
     
        }

        private async Task DelEmployeeAsync(int id)
        {
            JObject json = await ApiClient.SendDelRequest("http://sibento.yafetrakan.com/api/employee/" + id);
            Debug.WriteLine(json);
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            int i = DGEmployee.CurrentCell.RowIndex;

            int id = Int32.Parse(DGEmployee[0, i].Value.ToString());
            DelEmployeeAsync(id);
            loadEmployee();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //this code is used to search Name on the basis of txttxtSearchItem.text
                ((DataTable)DGEmployee.DataSource).DefaultView.RowFilter = string.Format("Name like '%{0}%'", txtSearch.Text.Trim().Replace("'", "''"));
            }
            catch (Exception) { }
        }
    }
}
