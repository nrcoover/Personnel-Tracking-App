
namespace PersonnelTracking
{
    partial class FrmPosition
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
            this.lblDepartmentSelect = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.btnClosePosition = new System.Windows.Forms.Button();
            this.btnUpdatePosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepartmentSelect
            // 
            this.lblDepartmentSelect.AutoSize = true;
            this.lblDepartmentSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSelect.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentSelect.Location = new System.Drawing.Point(43, 81);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 4;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(155, 42);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(217, 26);
            this.txtPosition.TabIndex = 5;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(43, 45);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(67, 20);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Position";
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(155, 78);
            this.cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            this.cmbDepartmentSelect.Size = new System.Drawing.Size(217, 28);
            this.cmbDepartmentSelect.TabIndex = 10;
            // 
            // btnClosePosition
            // 
            this.btnClosePosition.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClosePosition.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePosition.ForeColor = System.Drawing.Color.DimGray;
            this.btnClosePosition.Location = new System.Drawing.Point(222, 126);
            this.btnClosePosition.Name = "btnClosePosition";
            this.btnClosePosition.Size = new System.Drawing.Size(150, 49);
            this.btnClosePosition.TabIndex = 12;
            this.btnClosePosition.Text = "Close";
            this.btnClosePosition.UseVisualStyleBackColor = false;
            this.btnClosePosition.Click += new System.EventHandler(this.btnClosePosition_Click);
            // 
            // btnUpdatePosition
            // 
            this.btnUpdatePosition.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdatePosition.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePosition.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdatePosition.Location = new System.Drawing.Point(47, 126);
            this.btnUpdatePosition.Name = "btnUpdatePosition";
            this.btnUpdatePosition.Size = new System.Drawing.Size(150, 49);
            this.btnUpdatePosition.TabIndex = 11;
            this.btnUpdatePosition.Text = "Update";
            this.btnUpdatePosition.UseVisualStyleBackColor = false;
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(415, 223);
            this.Controls.Add(this.btnClosePosition);
            this.Controls.Add(this.btnUpdatePosition);
            this.Controls.Add(this.cmbDepartmentSelect);
            this.Controls.Add(this.lblDepartmentSelect);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPosition);
            this.Name = "FrmPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Position";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Button btnClosePosition;
        private System.Windows.Forms.Button btnUpdatePosition;
    }
}