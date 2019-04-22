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
using Newtonsoft.Json.Linq;
using SIBENTO.Class.Utility;

namespace SIBENTO
{
    public partial class UCUser : UserControl
    {
        private List<User> ListUser = new List<User>();
        private List<DGUserModel> DGModel = new List<DGUserModel>();
        private static UCUser _instance;

        public static UCUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCUser();
                return _instance;
            }
        }

        public UCUser()
        {
            InitializeComponent();
            LoadUserAsync();
        }

        class DGUserModel
        {
            public int id { get; set; }
            public string username { get; set; }
            public string name { get; set; }
            public string role { get; set; }
            public string branch { get; set; }
        }

        private async Task LoadUserAsync()
        {
            JObject json = await ApiClient.SendGetRequest("http://sibento.yafetrakan.com/api/user");

            JToken arrUser = json.GetValue("data");
            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();

                //MessageBox.Show(jError.ToString(), "Error ..", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (JToken dataUser in arrUser.AsEnumerable<JToken>())
                {
                    //Employee employee = (Employee) dataEmloyee.ToObject(typeof(Employee));

                    ListUser.Add((User)dataUser.ToObject(typeof(User)));

                }
                foreach (User data in ListUser)
                {
                    DGModel.Add(
                        (new DGUserModel
                        {
                            id = data.id,
                            username = data.username,
                            name = data.name,
                            role = data.role,
                            branch = data.branch,
                        }));
                }

                //DGModel = ListEmployee;
                Console.WriteLine($"ListEmployee");
                //DGEmployee.DataSource = ListEmployee;
                DGUser.DataSource = DGModel;
                DGUser.Columns[0].HeaderText = "ID";
                DGUser.Columns[0].Width = 50;

                DGUser.Columns[1].HeaderText = "Username";
                DGUser.Columns[2].HeaderText = "Nama";
                DGUser.Columns[3].HeaderText = "Role";
                DGUser.Columns[4].HeaderText = "Branch";
            }
        }
    }
}
