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
using Newtonsoft.Json.Linq;
using SIBENTO.Class.Utility;
using System.Net.Http;

namespace SIBENTO
{
    public partial class UCProfile : UserControl
    {
        static HttpClient client = new HttpClient();
        private static UCProfile _instance;
        public int loggedID;

        public static UCProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCProfile();
                return _instance;
            }
        }
        public UCProfile()
        {
            InitializeComponent();

            
        }
        public UCProfile(int ID)
        {
            InitializeComponent();
            loggedID = ID;
            Debug.WriteLine(loggedID);
            client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
        }
        private async Task EditPasswowrdAsync(Dictionary<string, string> body, int id)
        {
<<<<<<< HEAD
            Debug.WriteLine("http://sibento.yafetrakan.com/api/employee/" + id);
            JObject json = await ApiClient.SendPutRequest(body, "http://sibento.yafetrakan.com/api/user/putchangepassword/" + id);
=======
            Debug.WriteLine("https://sibento.yafetrakan.com/api/employee/" + id);
            JObject json = await ApiClient.SendPutRequest(body, "https://sibento.yafetrakan.com/api/user/putchangepassword/" + id);
>>>>>>> 26982cd0da3826b7f826cc7426f55485af472e94
           // HttpResponseMessage response = await client.PutAsJsonAsync($"user/changepassword/" +id, body);
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            values.Add("newPassword", txtNewPassword.Text);
            EditPasswowrdAsync(values, loggedID);
            txtNewPassword.Text = "";
        }
    }
}
