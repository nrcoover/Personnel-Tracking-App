
namespace PersonnelTracking
{
    partial class FrmPositionList
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
            this.pnlPositionList = new System.Windows.Forms.Panel();
            this.btnDeletePositionList = new System.Windows.Forms.Button();
            this.btnCloseDepartmentList = new System.Windows.Forms.Button();
            this.btnUpdatePositionList = new System.Windows.Forms.Button();
            this.btnAddPositionList = new System.Windows.Forms.Button();
            this.dgvPositionList = new System.Windows.Forms.DataGridView();
            this.pnlPositionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPositionList
            // 
            this.pnlPositionList.BackColor = System.Drawing.Color.LightGray;
            this.pnlPositionList.Controls.Add(this.btnDeletePositionList);
            this.pnlPositionList.Controls.Add(this.btnCloseDepartmentList);
            this.pnlPositionList.Controls.Add(this.btnUpdatePositionList);
            this.pnlPositionList.Controls.Add(this.btnAddPositionList);
            this.pnlPositionList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPositionList.Location = new System.Drawing.Point(0, 353);
            this.pnlPositionList.Name = "pnlPositionList";
            this.pnlPositionList.Size = new System.Drawing.Size(672, 121);
            this.pnlPositionList.TabIndex = 1;
            // 
            // btnDeletePositionList
            // 
            this.btnDeletePositionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeletePositionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePositionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeletePositionList.Location = new System.Drawing.Point(324, 27);
            this.btnDeletePositionList.Name = "btnDeletePositionList";
            this.btnDeletePositionList.Size = new System.Drawing.Size(150, 70);
            this.btnDeletePositionList.TabIndex = 2;
            this.btnDeletePositionList.Text = "DELETE";
            this.btnDeletePositionList.UseVisualStyleBackColor = false;
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
            // btnUpdatePositionList
            // 
            this.btnUpdatePositionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdatePositionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePositionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdatePositionList.Location = new System.Drawing.Point(168, 27);
            this.btnUpdatePositionList.Name = "btnUpdatePositionList";
            this.btnUpdatePositionList.Size = new System.Drawing.Size(150, 70);
            this.btnUpdatePositionList.TabIndex = 1;
            this.btnUpdatePositionList.Text = "Update";
            this.btnUpdatePositionList.UseVisualStyleBackColor = false;
            // 
            // btnAddPositionList
            // 
            this.btnAddPositionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddPositionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPositionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddPositionList.Location = new System.Drawing.Point(12, 27);
            this.btnAddPositionList.Name = "btnAddPositionList";
            this.btnAddPositionList.Size = new System.Drawing.Size(150, 70);
            this.btnAddPositionList.TabIndex = 0;
            this.btnAddPositionList.Text = "Add";
            this.btnAddPositionList.UseVisualStyleBackColor = false;
            // 
            // dgvPositionList
            // 
            this.dgvPositionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPositionList.Location = new System.Drawing.Point(0, 0);
            this.dgvPositionList.Name = "dgvPositionList";
            this.dgvPositionList.Size = new System.Drawing.Size(672, 354);
            this.dgvPositionList.TabIndex = 0;
            // 
            // FrmPositionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(672, 474);
            this.Controls.Add(this.pnlPositionList);
            this.Controls.Add(this.dgvPositionList);
            this.Name = "FrmPositionList";
            this.Text = "Position List";
            this.pnlPositionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPositionList;
        private System.Windows.Forms.Button btnDeletePositionList;
        private System.Windows.Forms.Button btnCloseDepartmentList;
        private System.Windows.Forms.Button btnUpdatePositionList;
        private System.Windows.Forms.Button btnAddPositionList;
        private System.Windows.Forms.DataGridView dgvPositionList;
    }
}