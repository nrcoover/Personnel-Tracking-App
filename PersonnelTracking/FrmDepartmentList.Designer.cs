
namespace PersonnelTracking
{
    partial class FrmDepartmentList
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
            this.dgvDepartmentList = new System.Windows.Forms.DataGridView();
            this.pnlDepartmentList = new System.Windows.Forms.Panel();
            this.btnDeleteDepartmentList = new System.Windows.Forms.Button();
            this.btnCloseDepartmentList = new System.Windows.Forms.Button();
            this.btnUpdateDepartmentList = new System.Windows.Forms.Button();
            this.btnNewDepartmentList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).BeginInit();
            this.pnlDepartmentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDepartmentList
            // 
            this.dgvDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDepartmentList.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartmentList.Name = "dgvDepartmentList";
            this.dgvDepartmentList.Size = new System.Drawing.Size(672, 354);
            this.dgvDepartmentList.TabIndex = 0;
            // 
            // pnlDepartmentList
            // 
            this.pnlDepartmentList.BackColor = System.Drawing.Color.LightGray;
            this.pnlDepartmentList.Controls.Add(this.btnDeleteDepartmentList);
            this.pnlDepartmentList.Controls.Add(this.btnCloseDepartmentList);
            this.pnlDepartmentList.Controls.Add(this.btnUpdateDepartmentList);
            this.pnlDepartmentList.Controls.Add(this.btnNewDepartmentList);
            this.pnlDepartmentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDepartmentList.Location = new System.Drawing.Point(0, 353);
            this.pnlDepartmentList.Name = "pnlDepartmentList";
            this.pnlDepartmentList.Size = new System.Drawing.Size(672, 121);
            this.pnlDepartmentList.TabIndex = 1;
            // 
            // btnDeleteDepartmentList
            // 
            this.btnDeleteDepartmentList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteDepartmentList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDepartmentList.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteDepartmentList.Location = new System.Drawing.Point(324, 27);
            this.btnDeleteDepartmentList.Name = "btnDeleteDepartmentList";
            this.btnDeleteDepartmentList.Size = new System.Drawing.Size(150, 70);
            this.btnDeleteDepartmentList.TabIndex = 2;
            this.btnDeleteDepartmentList.Text = "DELETE";
            this.btnDeleteDepartmentList.UseVisualStyleBackColor = false;
            // 
            // btnCloseDepartmentList
            // 
            this.btnCloseDepartmentList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCloseDepartmentList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDepartmentList.ForeColor = System.Drawing.Color.DimGray;
            this.btnCloseDepartmentList.Location = new System.Drawing.Point(510, 27);
            this.btnCloseDepartmentList.Name = "btnCloseDepartmentList";
            this.btnCloseDepartmentList.Size = new System.Drawing.Size(150, 70);
            this.btnCloseDepartmentList.TabIndex = 3;
            this.btnCloseDepartmentList.Text = "Close";
            this.btnCloseDepartmentList.UseVisualStyleBackColor = false;
            this.btnCloseDepartmentList.Click += new System.EventHandler(this.btnCloseDepartmentList_Click);
            // 
            // btnUpdateDepartmentList
            // 
            this.btnUpdateDepartmentList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateDepartmentList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDepartmentList.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateDepartmentList.Location = new System.Drawing.Point(168, 27);
            this.btnUpdateDepartmentList.Name = "btnUpdateDepartmentList";
            this.btnUpdateDepartmentList.Size = new System.Drawing.Size(150, 70);
            this.btnUpdateDepartmentList.TabIndex = 1;
            this.btnUpdateDepartmentList.Text = "Update";
            this.btnUpdateDepartmentList.UseVisualStyleBackColor = false;
            this.btnUpdateDepartmentList.Click += new System.EventHandler(this.btnUpdateDepartmentList_Click);
            // 
            // btnNewDepartmentList
            // 
            this.btnNewDepartmentList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewDepartmentList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDepartmentList.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewDepartmentList.Location = new System.Drawing.Point(12, 27);
            this.btnNewDepartmentList.Name = "btnNewDepartmentList";
            this.btnNewDepartmentList.Size = new System.Drawing.Size(150, 70);
            this.btnNewDepartmentList.TabIndex = 0;
            this.btnNewDepartmentList.Text = "New";
            this.btnNewDepartmentList.UseVisualStyleBackColor = false;
            this.btnNewDepartmentList.Click += new System.EventHandler(this.btnNewDepartmentList_Click);
            // 
            // FrmDepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(672, 474);
            this.Controls.Add(this.pnlDepartmentList);
            this.Controls.Add(this.dgvDepartmentList);
            this.Name = "FrmDepartmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).EndInit();
            this.pnlDepartmentList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartmentList;
        private System.Windows.Forms.Panel pnlDepartmentList;
        private System.Windows.Forms.Button btnNewDepartmentList;
        private System.Windows.Forms.Button btnCloseDepartmentList;
        private System.Windows.Forms.Button btnUpdateDepartmentList;
        private System.Windows.Forms.Button btnDeleteDepartmentList;
    }
}