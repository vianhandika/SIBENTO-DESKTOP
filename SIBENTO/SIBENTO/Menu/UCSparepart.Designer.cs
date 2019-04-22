namespace SIBENTO
{
    partial class UCSparepart
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
            this.btnDelSparepart = new System.Windows.Forms.Button();
            this.btnEdtSpareaprt = new System.Windows.Forms.Button();
            this.btnAddSparepart = new System.Windows.Forms.Button();
            this.DGSparepart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelSparepart
            // 
            this.btnDelSparepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelSparepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSparepart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSparepart.Location = new System.Drawing.Point(909, 118);
            this.btnDelSparepart.Name = "btnDelSparepart";
            this.btnDelSparepart.Size = new System.Drawing.Size(100, 50);
            this.btnDelSparepart.TabIndex = 15;
            this.btnDelSparepart.Text = "DELETE";
            this.btnDelSparepart.UseVisualStyleBackColor = true;
            this.btnDelSparepart.Click += new System.EventHandler(this.btnDelSparepart_Click);
            // 
            // btnEdtSpareaprt
            // 
            this.btnEdtSpareaprt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdtSpareaprt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdtSpareaprt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdtSpareaprt.Location = new System.Drawing.Point(803, 118);
            this.btnEdtSpareaprt.Name = "btnEdtSpareaprt";
            this.btnEdtSpareaprt.Size = new System.Drawing.Size(100, 50);
            this.btnEdtSpareaprt.TabIndex = 14;
            this.btnEdtSpareaprt.Text = "EDIT";
            this.btnEdtSpareaprt.UseVisualStyleBackColor = true;
            this.btnEdtSpareaprt.Click += new System.EventHandler(this.btnEdtSpareaprt_Click);
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSparepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSparepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSparepart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSparepart.Location = new System.Drawing.Point(697, 118);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(100, 50);
            this.btnAddSparepart.TabIndex = 13;
            this.btnAddSparepart.Text = "TAMBAH";
            this.btnAddSparepart.UseVisualStyleBackColor = false;
            this.btnAddSparepart.Click += new System.EventHandler(this.btnAddSparepart_Click);
            // 
            // DGSparepart
            // 
            this.DGSparepart.AllowUserToAddRows = false;
            this.DGSparepart.AllowUserToDeleteRows = false;
            this.DGSparepart.AllowUserToResizeColumns = false;
            this.DGSparepart.AllowUserToResizeRows = false;
            this.DGSparepart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSparepart.Location = new System.Drawing.Point(53, 183);
            this.DGSparepart.Name = "DGSparepart";
            this.DGSparepart.ReadOnly = true;
            this.DGSparepart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGSparepart.Size = new System.Drawing.Size(969, 371);
            this.DGSparepart.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sparepart";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(591, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 50);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(53, 130);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 27);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // UCSparepart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelSparepart);
            this.Controls.Add(this.btnEdtSpareaprt);
            this.Controls.Add(this.btnAddSparepart);
            this.Controls.Add(this.DGSparepart);
            this.Controls.Add(this.label1);
            this.Name = "UCSparepart";
            this.Size = new System.Drawing.Size(1070, 603);
            ((System.ComponentModel.ISupportInitialize)(this.DGSparepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelSparepart;
        private System.Windows.Forms.Button btnEdtSpareaprt;
        private System.Windows.Forms.Button btnAddSparepart;
        private System.Windows.Forms.DataGridView DGSparepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
