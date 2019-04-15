using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SIBENTO.Class.Utility;
using SIBENTO.Class.Model;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SIBENTO
{
  
    public partial class UCPegawaiForm : UserControl
    {
        int ID;
        private static UCPegawaiForm _instance;
        static HttpClient client = new HttpClient();
        public DataTable role = new DataTable();

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible && !Disposing)
            {
                Debug.WriteLine("FORM PEGAWAI LOADED");
            }; //<-- your population logic
        }

        protected override void OnLoad(EventArgs e)
        {
           
            ///More code here...
            base.OnLoad(e);
        }
        public static UCPegawaiForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCPegawaiForm();
                return _instance;
            }
        }

        public void transactionData(Dictionary<string, string> data)
        {
            ID = Int32.Parse(data["id"]);
            txtNameEmploye.Text = data["name"];
            txtNoTelpEmployee.Text = data["phone_number"];
            txtSalaryEmployee.Text = data["salary"];
            txtAddressEmployee.Text = data["address"];
            cmbBranchEmployee.Text = data["branch"];
            cmbRoleEmployee.Text = data["role"];


        }

        public UCPegawaiForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
            dropdownLoad();
           


        }

        private void UCPegawaiForm_Load(Object sender, EventArgs e)
        {
            Debug.WriteLine("Loaded");

            MessageBox.Show("You are in the UserControl.Load event.");

        }

        private async void dropdownLoad()
        {
 

           
          
            cmbBranchEmployee.DataSource = await GetCabang();
            cmbBranchEmployee.ValueMember = "id";
            cmbBranchEmployee.DisplayMember = "name";

            cmbRoleEmployee.DataSource = await GetJabatan();
            cmbRoleEmployee.ValueMember = "id";
            cmbRoleEmployee.DisplayMember = "name";
        }

        static async Task<DataTable> GetCabang()
        {
      

            HttpResponseMessage response = await client.GetAsync("api/branch");

            var arr = await response.Content.ReadAsStringAsync();
            DataTable DT = new DataTable();
            DT = json_convert(arr);
         


            return DT;

        }

        static async Task<DataTable> GetJabatan()
        {
          

            HttpResponseMessage response = await client.GetAsync("api/role");

            var arr = await response.Content.ReadAsStringAsync();
            DataTable DT = new DataTable();
            DT = json_convert(arr);
          


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

        private async Task AddEmployeeAsync(Dictionary<string, string> body)
        {
            JObject json = await ApiClient.SendPostRequest(body, "http://sibento.yafetrakan.com/api/employee");

            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();

            }
            else
            {
                JToken respond = json.GetValue("data");
   
                Employee employee = (Employee)respond.ToObject(typeof(Employee));
                UCPegawai.Instance.loadEmployee();

            }
        }

        private async Task EditEmployeeAsync(Dictionary<string, string> body, int id)
        {
            Debug.WriteLine("http://sibento.yafetrakan.com/api/employee/" + id);
            JObject json = await ApiClient.SendPutRequest(body, "http://sibento.yafetrakan.com/api/employee/"+id);


            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                Debug.WriteLine(" contain eror");
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();
               
            }
            else
            {
                Debug.WriteLine("not contain eror");
                JToken dataEmployee = json.GetValue("data");
                Employee employee = (Employee)dataEmployee.ToObject(typeof(Employee));
                //Debug.WriteLine(employee);

                UCPegawai.Instance.loadEmployee();

            }
        }



        public void disableInput()
        {
            txtNameEmploye.Enabled = false;
            txtSalaryEmployee.Enabled = false;
            txtNoTelpEmployee.Enabled = false;
            txtAddressEmployee.Enabled = false;
            cmbBranchEmployee.Enabled = false;
            cmbRoleEmployee.Enabled = false;
        }

        public void enableInput()
        {
            txtNameEmploye.Enabled = true;
            txtSalaryEmployee.Enabled = true;
            txtNoTelpEmployee.Enabled = true;
            txtAddressEmployee.Enabled = true;
            cmbBranchEmployee.Enabled = true;
            cmbRoleEmployee.Enabled = true;
        }

        public void clearInput()
        {
            txtNameEmploye.Text = "";
            txtSalaryEmployee.Text = "";
            txtNoTelpEmployee.Text = "";
            txtAddressEmployee.Text = "";

        }


        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Dictionary<string, string> values = new Dictionary<string, string>();

            values.Add("name_employee", txtNameEmploye.Text);
            values.Add("salary", txtSalaryEmployee.Text);
            values.Add("phone_number", txtNoTelpEmployee.Text);
            values.Add("address", txtAddressEmployee.Text);
            values.Add("branch", cmbBranchEmployee.SelectedValue.ToString());
            values.Add("role", cmbRoleEmployee.SelectedValue.ToString());

            if (ID != 0)
            {
                Debug.WriteLine("edit");
                EditEmployeeAsync(values, ID);
            }
            else
            {
                Debug.WriteLine("tambah");

                String usernameGenerate = txtNameEmploye.Text.ToLower();
                usernameGenerate = usernameGenerate.Split(' ').FirstOrDefault();
                usernameGenerate = usernameGenerate + random.Next(100).ToString();
                values.Add("username", usernameGenerate);
                AddEmployeeAsync(values);
            }
           
            clearInput();
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
            UCPegawai.Instance.loadEmployee();
            UCPegawai.Instance.BringToFront();
            //UCPegawaiForm.Instance.Hide();
           
        }
    }
}
