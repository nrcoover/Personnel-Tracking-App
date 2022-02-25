
namespace PersonnelTracking
{
    partial class FrmDepartment
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
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnCloseDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.White;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(187, 45);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(198, 26);
            this.txtDepartment.TabIndex = 0;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(56, 48);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(98, 20);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateDepartment.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateDepartment.Location = new System.Drawing.Point(60, 99);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(150, 49);
            this.btnUpdateDepartment.TabIndex = 1;
            this.btnUpdateDepartment.Text = "Update";
            this.btnUpdateDepartment.UseVisualStyleBackColor = false;
            // 
            // btnCloseDepartment
            // 
            this.btnCloseDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCloseDepartment.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.btnCloseDepartment.Location = new System.Drawing.Point(235, 99);
            this.btnCloseDepartment.Name = "btnCloseDepartment";
            this.btnCloseDepartment.Size = new System.Drawing.Size(150, 49);
            this.btnCloseDepartment.TabIndex = 2;
            this.btnCloseDepartment.Text = "Close";
            this.btnCloseDepartment.UseVisualStyleBackColor = false;
            this.btnCloseDepartment.Click += new System.EventHandler(this.btnCloseDepartment_Click);
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(437, 197);
            this.Controls.Add(this.btnCloseDepartment);
            this.Controls.Add(this.btnUpdateDepartment);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Name = "FrmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnCloseDepartment;
    }
}