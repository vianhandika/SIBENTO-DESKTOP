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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ActiveDashboard.Visible = true;
            ActivePegawai.Visible = false;
            ActiveService.Visible = false;

            _obj = this;
            //btnPegawai.Hide();

            //UCPegawai pegawai=new UCPegawai();
            //UCDashboard dashboard = new UCDashboard();
            UCDashboard.Instance.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(UCDashboard.Instance);
            PanelContainer.Controls.Add(UCPegawaiAdd.Instance);
            

        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCDashboard.Instance))
            {
                PanelContainer.Controls.Add(UCDashboard.Instance);
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
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {

            if (!PanelContainer.Controls.Contains(UCPegawai.Instance))
            {
                PanelContainer.Controls.Add(UCPegawai.Instance);
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
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCService.Instance))
            {
                PanelContainer.Controls.Add(UCService.Instance);
                UCService.Instance.Dock = DockStyle.Fill;
                UCService.Instance.BringToFront();
            }
            else
            {
                UCService.Instance.BringToFront();
            }
            //PanelContainer.Controls["UCPegawai"].BringToFront();
            ActiveDashboard.Visible = false;
            ActivePegawai.Visible = false;
            ActiveService.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCService.Instance))
            {
                PanelContainer.Controls.Add(UCService.Instance);
                UCService.Instance.Dock = DockStyle.Fill;
                UCService.Instance.BringToFront();
            }
            else
            {
                UCService.Instance.BringToFront();
            }
            //PanelContainer.Controls["UCPegawai"].BringToFront();
            ActiveDashboard.Visible = false;
            ActivePegawai.Visible = false;
            ActiveService.Visible = true;
        }
    }
}
