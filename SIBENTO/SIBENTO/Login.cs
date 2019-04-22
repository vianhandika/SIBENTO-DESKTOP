using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIBENTO
{
    public partial class Login : Form
    {
        static HttpClient client = new HttpClient();


        

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToString().Trim() != "" && txtPassword.Text.ToString().Trim() != "")
            {
                GetLogin(txtUsername.Text.ToString(), txtPassword.Text.ToString());
            }
           // Login.ActiveForm.Hide();
           // Dashboard dashboard = new Dashboard();
            //dashboard.ShowDialog();

        }

        static async void GetLogin(string user, string pass)
        {
            if(client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");

            }
            //Console.WriteLine($"{client.BaseAddress}");
            LoginClass login = new LoginClass { username = user, password = pass };
            var response = client.PostAsJsonAsync("api/mobileauthenticate", login).Result;
            if (response.IsSuccessStatusCode)
            {
                var a = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"{a}");
                Data data = new Data(a);
                Console.WriteLine($"{data.id}");
                //var b = JsonConvert.DeserializeObject<Data>(a);
                //Console.WriteLine($"{b.username}");
                Dictionary<string, string> values = new Dictionary<string, string>();

                values.Add("id", data.id.ToString());
                values.Add("username", data.username);
                values.Add("name", data.name);
                values.Add("role", data.role);

                Login.ActiveForm.Hide();
                Dashboard dashboard = new Dashboard(values);
                dashboard.ShowDialog();
            }
            else
            {
                Console.WriteLine("Gagal");
                MessageBox.Show("Gagal Login, Silahkan Coba Lagi");
            }
        }

        public class LoginClass
        {
            public int id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string role { get; set; }
        }

        public class Data
        {
            public Data(string json)
            {
                JObject jObject = JObject.Parse(json);
                JToken jUser = jObject["data"];
                name = (string)jUser["name"];
                username = (string)jUser["username"];
                id = (int)jUser["id"];
                role = (string)jUser["role"];
            }
            public int id { get; set; }
            public string username { get; set; }
            public string name { get; set; }
            public string role { get; set; }
        }

        public static class LoginInfo
        {
            public static int id;
            public static string username;
            public static string name;
            public static string role;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
