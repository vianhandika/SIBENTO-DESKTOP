using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using SIBENTO.Class.Utility;

namespace SIBENTO
{
    public partial class UCDashboard : UserControl
    {
        static HttpClient client = new HttpClient();
        private static UCDashboard _instance;
        public int loggedId;
        public string loggedName;
        public string loggedRole;

        public static UCDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCDashboard();
                return _instance;
            }
        }

        public void transactionData(Dictionary<string, string> data)
        {
            //ID = Int32.Parse(data["id_service"]);
            txtNama.Text = data["name"];
            txtRole.Text = data["role"];
        }

        //public UCDashboard(int Id, string Name, string Role)
        //{
        //    InitializeComponent();
        //    loggedId = Id;
        //    loggedName = Name;
        //    loggedRole = Role;
        //    txtNama.Text = loggedName;
        //    txtRole.Text = loggedRole;

        //    Debug.WriteLine(loggedName);
        //    Debug.WriteLine(loggedRole);
        //    client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
        //}

        public UCDashboard()
        {
            InitializeComponent();
        }

        //HttpResponseMessage response = await client.GetAsync("api/employee");
        //txtNama.Text = loggedName;
        //    txtRole.Text = loggedRole;
    }
}
