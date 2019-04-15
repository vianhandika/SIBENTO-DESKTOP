namespace SIBENTO
{
    partial class UCDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome To SIBENTO Panel";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.AutoSize = true;
            this.txtNama.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(497, 300);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(76, 25);
            this.txtNama.TabIndex = 2;
            this.txtNama.Text = "Nama";
            this.txtNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRole
            // 
            this.txtRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRole.AutoSize = true;
            this.txtRole.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(507, 364);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(55, 25);
            this.txtRole.TabIndex = 3;
            this.txtRole.Text = "Role";
            this.txtRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(1070, 603);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNama;
        private System.Windows.Forms.Label txtRole;
    }
}
