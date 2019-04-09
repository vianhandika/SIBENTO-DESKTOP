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
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = false;

            _obj = this;
            //btnPegawai.Hide();

            //UCPegawai pegawai=new UCPegawai();
            //UCDashboard dashboard = new UCDashboard();
            UCDashboard.Instance.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(UCDashboard.Instance);
            //PanelContainer.Controls.Add(UCPegawaiAdd.Instance);
            

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
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = false;
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
            ActiveSparepart.Visible = false;
            ActiveUser.Visible = false;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (!PanelContainer.Controls.Contains(UCJasaService.Instance))
            {
                PanelContainer.Controls.Add(UCJasaService.Instance);
                PanelContainer.Controls.Add(UCServiceForm.Instance);
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
    }
}
