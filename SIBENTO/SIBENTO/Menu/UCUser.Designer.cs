namespace SIBENTO
{
    partial class UCUser
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
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnEdtUser = new System.Windows.Forms.Button();
            this.DGUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelUser
            // 
            this.btnDelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUser.Location = new System.Drawing.Point(909, 118);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(100, 50);
            this.btnDelUser.TabIndex = 15;
            this.btnDelUser.Text = "DELETE";
            this.btnDelUser.UseVisualStyleBackColor = true;
            // 
            // btnEdtUser
            // 
            this.btnEdtUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdtUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdtUser.Location = new System.Drawing.Point(803, 118);
            this.btnEdtUser.Name = "btnEdtUser";
            this.btnEdtUser.Size = new System.Drawing.Size(100, 50);
            this.btnEdtUser.TabIndex = 14;
            this.btnEdtUser.Text = "EDIT";
            this.btnEdtUser.UseVisualStyleBackColor = true;
            // 
            // DGUser
            // 
            this.DGUser.AllowUserToAddRows = false;
            this.DGUser.AllowUserToDeleteRows = false;
            this.DGUser.AllowUserToResizeColumns = false;
            this.DGUser.AllowUserToResizeRows = false;
            this.DGUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUser.Location = new System.Drawing.Point(51, 182);
            this.DGUser.Name = "DGUser";
            this.DGUser.ReadOnly = true;
            this.DGUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGUser.Size = new System.Drawing.Size(969, 371);
            this.DGUser.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "User";
            // 
            // UCUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnEdtUser);
            this.Controls.Add(this.DGUser);
            this.Controls.Add(this.label1);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1070, 603);
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnEdtUser;
        private System.Windows.Forms.DataGridView DGUser;
        private System.Windows.Forms.Label label1;
    }
}
