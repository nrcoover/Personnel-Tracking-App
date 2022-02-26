
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
            this.btnClosePositionList = new System.Windows.Forms.Button();
            this.btnUpdatePositionList = new System.Windows.Forms.Button();
            this.btnNewPositionList = new System.Windows.Forms.Button();
            this.dgvPositionList = new System.Windows.Forms.DataGridView();
            this.pnlPositionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPositionList
            // 
            this.pnlPositionList.BackColor = System.Drawing.Color.LightGray;
            this.pnlPositionList.Controls.Add(this.btnDeletePositionList);
            this.pnlPositionList.Controls.Add(this.btnClosePositionList);
            this.pnlPositionList.Controls.Add(this.btnUpdatePositionList);
            this.pnlPositionList.Controls.Add(this.btnNewPositionList);
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
            // btnClosePositionList
            // 
            this.btnClosePositionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClosePositionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePositionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnClosePositionList.Location = new System.Drawing.Point(510, 27);
            this.btnClosePositionList.Name = "btnClosePositionList";
            this.btnClosePositionList.Size = new System.Drawing.Size(150, 70);
            this.btnClosePositionList.TabIndex = 3;
            this.btnClosePositionList.Text = "Close";
            this.btnClosePositionList.UseVisualStyleBackColor = false;
            this.btnClosePositionList.Click += new System.EventHandler(this.btnCloseDepartmentList_Click);
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
            this.btnUpdatePositionList.Click += new System.EventHandler(this.btnUpdatePositionList_Click);
            // 
            // btnNewPositionList
            // 
            this.btnNewPositionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewPositionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPositionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewPositionList.Location = new System.Drawing.Point(12, 27);
            this.btnNewPositionList.Name = "btnNewPositionList";
            this.btnNewPositionList.Size = new System.Drawing.Size(150, 70);
            this.btnNewPositionList.TabIndex = 0;
            this.btnNewPositionList.Text = "New";
            this.btnNewPositionList.UseVisualStyleBackColor = false;
            this.btnNewPositionList.Click += new System.EventHandler(this.btnNewPositionList_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Position List";
            this.pnlPositionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPositionList;
        private System.Windows.Forms.Button btnDeletePositionList;
        private System.Windows.Forms.Button btnClosePositionList;
        private System.Windows.Forms.Button btnUpdatePositionList;
        private System.Windows.Forms.Button btnNewPositionList;
        private System.Windows.Forms.DataGridView dgvPositionList;
    }
}