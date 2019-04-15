namespace SIBENTO
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.txtPanel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.txtLogged = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ActiveDashboard = new System.Windows.Forms.Panel();
            this.btnPegawai = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ActivePegawai = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnService = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ActiveService = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSparepart = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ActiveSparepart = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ActiveUser = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.PanelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.PanelLeft.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.btnDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.btnPegawai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btnService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.btnSparepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.btnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPanel
            // 
            this.txtPanel.AutoSize = true;
            this.txtPanel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanel.ForeColor = System.Drawing.Color.White;
            this.txtPanel.Location = new System.Drawing.Point(144, 24);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(201, 32);
            this.txtPanel.TabIndex = 1;
            this.txtPanel.Text = "SIBENTO Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.PanelTop.Controls.Add(this.btnLogout);
            this.PanelTop.Controls.Add(this.txtLogged);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Controls.Add(this.txtPanel);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1264, 78);
            this.PanelTop.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1187, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 50);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 4;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtLogged
            // 
            this.txtLogged.AutoSize = true;
            this.txtLogged.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogged.ForeColor = System.Drawing.Color.White;
            this.txtLogged.Location = new System.Drawing.Point(881, 24);
            this.txtLogged.Name = "txtLogged";
            this.txtLogged.Size = new System.Drawing.Size(233, 32);
            this.txtLogged.TabIndex = 3;
            this.txtLogged.Text = "Name Employee";
            this.txtLogged.Click += new System.EventHandler(this.txtLogged_Click);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.White;
            this.PanelLeft.Controls.Add(this.label3);
            this.PanelLeft.Controls.Add(this.flowLayoutPanel1);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 78);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(197, 603);
            this.PanelLeft.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Menu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnPegawai);
            this.flowLayoutPanel1.Controls.Add(this.btnService);
            this.flowLayoutPanel1.Controls.Add(this.btnSparepart);
            this.flowLayoutPanel1.Controls.Add(this.btnUser);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 353);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Controls.Add(this.label5);
            this.btnDashboard.Controls.Add(this.pictureBox4);
            this.btnDashboard.Controls.Add(this.ActiveDashboard);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(194, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dashboard";
            this.label5.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // ActiveDashboard
            // 
            this.ActiveDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.ActiveDashboard.Location = new System.Drawing.Point(1, 0);
            this.ActiveDashboard.Name = "ActiveDashboard";
            this.ActiveDashboard.Size = new System.Drawing.Size(10, 47);
            this.ActiveDashboard.TabIndex = 5;
            // 
            // btnPegawai
            // 
            this.btnPegawai.Controls.Add(this.label2);
            this.btnPegawai.Controls.Add(this.ActivePegawai);
            this.btnPegawai.Controls.Add(this.pictureBox2);
            this.btnPegawai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPegawai.Location = new System.Drawing.Point(3, 57);
            this.btnPegawai.Name = "btnPegawai";
            this.btnPegawai.Size = new System.Drawing.Size(194, 48);
            this.btnPegawai.TabIndex = 3;
            this.btnPegawai.Click += new System.EventHandler(this.btnPegawai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pegawai";
            this.label2.Click += new System.EventHandler(this.btnPegawai_Click);
            // 
            // ActivePegawai
            // 
            this.ActivePegawai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.ActivePegawai.Location = new System.Drawing.Point(1, 0);
            this.ActivePegawai.Name = "ActivePegawai";
            this.ActivePegawai.Size = new System.Drawing.Size(10, 47);
            this.ActivePegawai.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnPegawai_Click);
            // 
            // btnService
            // 
            this.btnService.Controls.Add(this.label4);
            this.btnService.Controls.Add(this.ActiveService);
            this.btnService.Controls.Add(this.pictureBox3);
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnService.Location = new System.Drawing.Point(3, 111);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(194, 48);
            this.btnService.TabIndex = 6;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jasa Service";
            this.label4.Click += new System.EventHandler(this.btnService_Click);
            // 
            // ActiveService
            // 
            this.ActiveService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.ActiveService.Location = new System.Drawing.Point(1, 0);
            this.ActiveService.Name = "ActiveService";
            this.ActiveService.Size = new System.Drawing.Size(10, 47);
            this.ActiveService.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnSparepart
            // 
            this.btnSparepart.Controls.Add(this.label6);
            this.btnSparepart.Controls.Add(this.ActiveSparepart);
            this.btnSparepart.Controls.Add(this.pictureBox5);
            this.btnSparepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSparepart.Location = new System.Drawing.Point(3, 165);
            this.btnSparepart.Name = "btnSparepart";
            this.btnSparepart.Size = new System.Drawing.Size(194, 48);
            this.btnSparepart.TabIndex = 7;
            this.btnSparepart.Click += new System.EventHandler(this.btnSparepart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sparepart";
            this.label6.Click += new System.EventHandler(this.btnSparepart_Click);
            // 
            // ActiveSparepart
            // 
            this.ActiveSparepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.ActiveSparepart.Location = new System.Drawing.Point(1, 0);
            this.ActiveSparepart.Name = "ActiveSparepart";
            this.ActiveSparepart.Size = new System.Drawing.Size(10, 47);
            this.ActiveSparepart.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnSparepart_Click);
            // 
            // btnUser
            // 
            this.btnUser.Controls.Add(this.label7);
            this.btnUser.Controls.Add(this.ActiveUser);
            this.btnUser.Controls.Add(this.pictureBox6);
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Location = new System.Drawing.Point(3, 219);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(194, 48);
            this.btnUser.TabIndex = 8;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "User";
            this.label7.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // ActiveUser
            // 
            this.ActiveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.ActiveUser.Location = new System.Drawing.Point(1, 0);
            this.ActiveUser.Name = "ActiveUser";
            this.ActiveUser.Size = new System.Drawing.Size(10, 47);
            this.ActiveUser.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(197, 78);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1067, 603);
            this.PanelContainer.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.btnDashboard.ResumeLayout(false);
            this.btnDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.btnPegawai.ResumeLayout(false);
            this.btnPegawai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btnService.ResumeLayout(false);
            this.btnService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.btnSparepart.ResumeLayout(false);
            this.btnSparepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.btnUser.ResumeLayout(false);
            this.btnUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel btnDashboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel ActiveDashboard;
        private System.Windows.Forms.Panel btnPegawai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ActivePegawai;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel btnService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel ActiveService;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel btnSparepart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel ActiveSparepart;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel btnUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ActiveUser;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label txtLogged;
        private System.Windows.Forms.PictureBox btnLogout;
    }
}