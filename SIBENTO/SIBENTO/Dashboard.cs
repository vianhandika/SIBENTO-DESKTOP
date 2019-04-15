using SIBENTO.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIBENTO
{
    public partial class Dashboard : Form
    {
        static Dashboard _obj;
        SessionClass loggedUser = new SessionClass();
        public int ID;

        public class SessionClass
        {
            public int id { get; set; }
            public string username { get; set; }
            public string name { get; set; }   
            public string password { get; set; }
            public string role { get; set; }
        }

        public static Dashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }
        public Panel PNLContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(Dictionary<string, string> data)
        {
            InitializeComponent();
            loggedUser.id = Int32.Parse(data["id"]);
            loggedUser.username = data["username"];
            loggedUser.name = data["name"];
            loggedUser.role = data["role"];
            ID = loggedUser.id;
            txtLogged.Text = loggedUser.name;
            txtPanel.Text = "SIBENTO " + loggedUser.role + " Panel";
            if(loggedUser.role != "Admin")
            {
                btnPegawai.Hide();
                btnService.Hide();
                btnSparepart.Hide();
                btnUser.Hide();
            }
            //txtLogged.Text = data["name"];


        }

        //public void OnCancelUserControlOne(object sender, EventArgs e)
        //{
        //    MessageBox.Show("oops!");
        //    PanelContainer.Controls.Clear();
        //    UCDashboard dashboard = new UCDashboard();
        //    PanelContainer.Controls.Add(dashboard);
        //}

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //UCDashboard dashboard = new UCDashboard();
            //dashboard.Click += new EventHandler(OnCancelUserControlOne);

            ActiveDashboard.Visible = true;
            ActivePegawai.Visible = false;
            ActiveService.Visible = false;
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = false;

            _obj = this;
            //btnPegawai.Hide();
            PanelContainer.Controls.Add(UCDashboard.Instance);

            //UCPegawai pegawai=new UCPegawai();
            //UCDashboard dashboard = new UCDashboard();
            Dictionary<string, string> values = new Dictionary<string, string>();
            //int i = DGService.CurrentCell.RowIndex;
            //int id = Int32.Parse(DGService[0, i].Value.ToString());

            //Employee dataSelected = ListService.Where(obj => obj.id_service == id).First();
            values.Add("name", loggedUser.name);
            values.Add("role", loggedUser.role);

            UCDashboard.Instance.transactionData(values);
            UCDashboard.Instance.Dock = DockStyle.Fill;
<<<<<<< HEAD
            UCDashboard.Instance.BringToFront();
=======
            PanelContainer.Controls.Add(UCDashboard.Instance);
>>>>>>> 26982cd0da3826b7f826cc7426f55485af472e94

            //PanelContainer.Controls.Add(UCPegawaiAdd.Instance);


        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCDashboard.Instance))
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                //int i = DGService.CurrentCell.RowIndex;
                //int id = Int32.Parse(DGService[0, i].Value.ToString());

                //Employee dataSelected = ListService.Where(obj => obj.id_service == id).First();
                values.Add("name", loggedUser.name);
                values.Add("role", loggedUser.role);

                UCDashboard.Instance.transactionData(values);
                //UCServiceForm.Instance.BringToFront();

                //UCDashboard dashboard = new UCDashboard();
                //PanelContainer.Controls.Add(dashboard);
                //PanelContainer.Controls.Add(UCDashboard.Instance);
                UCDashboard.Instance.Dock = DockStyle.Fill;
                UCDashboard.Instance.BringToFront();
            }
            else
            {
                UCDashboard.Instance.BringToFront();
            }
            //PanelContainer.Controls["UCDashboard"].BringToFront();
            ActiveDashboard.Visible = true;
            ActivePegawai.Visible = false;
            ActiveService.Visible = false;
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = false;
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {

            if (!PanelContainer.Controls.Contains(UCPegawai.Instance))
            {
                PanelContainer.Controls.Add(UCPegawai.Instance);
                PanelContainer.Controls.Add(UCPegawaiForm.Instance);
                UCPegawaiForm.Instance.setEditNull();
                UCPegawai.Instance.Dock = DockStyle.Fill;
                UCPegawai.Instance.BringToFront();
            }
            else
            {
                UCPegawai.Instance.BringToFront();
            }
            //PanelContainer.Controls["UCPegawai"].BringToFront();
            ActiveDashboard.Visible = false;
            ActivePegawai.Visible = true;
            ActiveService.Visible = false;
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = false;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCJasaService.Instance))
            {
                PanelContainer.Controls.Add(UCJasaService.Instance);
                PanelContainer.Controls.Add(UCServiceForm.Instance);
                UCServiceForm.Instance.setEditNull();
                UCJasaService.Instance.Dock = DockStyle.Fill;
                UCJasaService.Instance.BringToFront();
            }
            else
            {
                UCJasaService.Instance.BringToFront();
            }
            //PanelContainer.Controls["UCPegawai"].BringToFront();
            ActiveDashboard.Visible = false;
            ActivePegawai.Visible = false;
            ActiveService.Visible = true;
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = false;
        }

        private void btnSparepart_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCSparepart.Instance))
            {
                PanelContainer.Controls.Add(UCSparepart.Instance);
                PanelContainer.Controls.Add(UCSparepartForm.Instance);
                UCSparepart.Instance.Dock = DockStyle.Fill;
                UCSparepart.Instance.BringToFront();
            }
            else
            {
                UCSparepart.Instance.BringToFront();
            }
            //PanelContainer.Controls["UCPegawai"].BringToFront();
            ActiveDashboard.Visible = false;
            ActivePegawai.Visible = false;
            ActiveService.Visible = false;
            ActiveSparepart.Visible = true;
            ActiveUser.Visible = false;

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCUser.Instance))
            {
                PanelContainer.Controls.Add(UCUser.Instance);
                UCUser.Instance.Dock = DockStyle.Fill;
                UCUser.Instance.BringToFront();
            }
            else
            {
                UCUser.Instance.BringToFront();
            }

            //PanelContainer.Controls["UCPegawai"].BringToFront();
            ActiveDashboard.Visible = false;
            ActivePegawai.Visible = false;
            ActiveService.Visible = false;
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dashboard.ActiveForm.Hide();
            Login login = new Login();
            login.Show();
        }

        private void txtLogged_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCProfile.Instance))
            {
                
                UCProfile profile = new UCProfile(loggedUser.id);
                PanelContainer.Controls.Add(profile);
                profile.Dock = DockStyle.Fill;
                profile.BringToFront();

            }
            else
            {
                UCProfile.Instance.BringToFront();
            }
        }
    }
}
