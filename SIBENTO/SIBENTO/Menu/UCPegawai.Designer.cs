using SIBENTO.Class.Model;
using System.Collections.Generic;

namespace SIBENTO
{
    partial class UCPegawai
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
            this.DGEmployee = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEdtEmployee = new System.Windows.Forms.Button();
            this.btnDelEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pegawai";
            // 
            // DGEmployee
            // 
            this.DGEmployee.AllowUserToAddRows = false;
            this.DGEmployee.AllowUserToDeleteRows = false;
            this.DGEmployee.AllowUserToResizeColumns = false;
            this.DGEmployee.AllowUserToResizeRows = false;
            this.DGEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEmployee.Location = new System.Drawing.Point(53, 183);
            this.DGEmployee.Name = "DGEmployee";
            this.DGEmployee.ReadOnly = true;
            this.DGEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGEmployee.Size = new System.Drawing.Size(969, 371);
            this.DGEmployee.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(699, 119);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 50);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "TAMBAH";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEdtEmployee
            // 
            this.btnEdtEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdtEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdtEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdtEmployee.Location = new System.Drawing.Point(805, 119);
            this.btnEdtEmployee.Name = "btnEdtEmployee";
            this.btnEdtEmployee.Size = new System.Drawing.Size(100, 50);
            this.btnEdtEmployee.TabIndex = 4;
            this.btnEdtEmployee.Text = "EDIT";
            this.btnEdtEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDelEmployee
            // 
            this.btnDelEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmployee.Location = new System.Drawing.Point(911, 119);
            this.btnDelEmployee.Name = "btnDelEmployee";
            this.btnDelEmployee.Size = new System.Drawing.Size(100, 50);
            this.btnDelEmployee.TabIndex = 5;
            this.btnDelEmployee.Text = "DELETE";
            this.btnDelEmployee.UseVisualStyleBackColor = true;
            // 
            // UCPegawai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btnDelEmployee);
            this.Controls.Add(this.btnEdtEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.DGEmployee);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCPegawai";
            this.Size = new System.Drawing.Size(1070, 603);
            ((System.ComponentModel.ISupportInitialize)(this.DGEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEdtEmployee;
        private System.Windows.Forms.Button btnDelEmployee;
    }
}
