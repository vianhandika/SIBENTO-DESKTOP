namespace SIBENTO
{
    partial class UCServiceForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCServiceForm));
            this.btnSaveService = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveService
            // 
            this.btnSaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveService.Location = new System.Drawing.Point(548, 361);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(97, 37);
            this.btnSaveService.TabIndex = 57;
            this.btnSaveService.Text = "SIMPAN";
            this.btnSaveService.UseVisualStyleBackColor = true;
            this.btnSaveService.Click += new System.EventHandler(this.btnSaveService_Click);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(389, 184);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(256, 20);
            this.txtService.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nama Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 38;
            this.label1.Text = "Service";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(389, 262);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(256, 20);
            this.txtHarga.TabIndex = 58;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(100, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 38);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 59;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UCServiceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.btnSaveService);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCServiceForm";
            this.Size = new System.Drawing.Size(1070, 603);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.PictureBox btnClose;
    }
}
