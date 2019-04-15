namespace SIBENTO
{
    partial class UCJasaService
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
            this.btnDelService = new System.Windows.Forms.Button();
            this.btnEdtService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.DGService = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelService
            // 
            this.btnDelService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelService.Location = new System.Drawing.Point(909, 118);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.Size = new System.Drawing.Size(100, 50);
            this.btnDelService.TabIndex = 10;
            this.btnDelService.Text = "DELETE";
            this.btnDelService.UseVisualStyleBackColor = true;
            this.btnDelService.Click += new System.EventHandler(this.btnDelService_Click);
            // 
            // btnEdtService
            // 
            this.btnEdtService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdtService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdtService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdtService.Location = new System.Drawing.Point(803, 118);
            this.btnEdtService.Name = "btnEdtService";
            this.btnEdtService.Size = new System.Drawing.Size(100, 50);
            this.btnEdtService.TabIndex = 9;
            this.btnEdtService.Text = "EDIT";
            this.btnEdtService.UseVisualStyleBackColor = true;
            this.btnEdtService.Click += new System.EventHandler(this.btnEdtService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.Transparent;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(697, 118);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(100, 50);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "TAMBAH";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // DGService
            // 
            this.DGService.AllowUserToAddRows = false;
            this.DGService.AllowUserToDeleteRows = false;
            this.DGService.AllowUserToResizeColumns = false;
            this.DGService.AllowUserToResizeRows = false;
            this.DGService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGService.Location = new System.Drawing.Point(53, 183);
            this.DGService.Name = "DGService";
            this.DGService.ReadOnly = true;
            this.DGService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGService.Size = new System.Drawing.Size(969, 371);
            this.DGService.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jasa Service";
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
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(53, 141);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 27);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // UCJasaService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelService);
            this.Controls.Add(this.btnEdtService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.DGService);
            this.Controls.Add(this.label1);
            this.Name = "UCJasaService";
            this.Size = new System.Drawing.Size(1070, 603);
            ((System.ComponentModel.ISupportInitialize)(this.DGService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelService;
        private System.Windows.Forms.Button btnEdtService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.DataGridView DGService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
