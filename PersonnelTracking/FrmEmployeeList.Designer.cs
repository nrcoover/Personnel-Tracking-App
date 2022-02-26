
namespace PersonnelTracking
{
    partial class FrmEmployeeList
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
            this.pnlEmployeeList = new System.Windows.Forms.Panel();
            this.btnDeleteEmployeeList = new System.Windows.Forms.Button();
            this.btnCloseEmployeeList = new System.Windows.Forms.Button();
            this.btnUpdateEmployeeList = new System.Windows.Forms.Button();
            this.btnAddEmployeeList = new System.Windows.Forms.Button();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.pnlEmployeeListTop = new System.Windows.Forms.Panel();
            this.cmbPositionSelect = new System.Windows.Forms.ComboBox();
            this.lblPositionSelect = new System.Windows.Forms.Label();
            this.cmbDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.btnClearEmployee = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.lblDepartmentSelect = new System.Windows.Forms.Label();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeIDSearch = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeIDSearch = new System.Windows.Forms.Label();
            this.pnlEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnlEmployeeListTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployeeList
            // 
            this.pnlEmployeeList.BackColor = System.Drawing.Color.LightGray;
            this.pnlEmployeeList.Controls.Add(this.btnDeleteEmployeeList);
            this.pnlEmployeeList.Controls.Add(this.btnCloseEmployeeList);
            this.pnlEmployeeList.Controls.Add(this.btnUpdateEmployeeList);
            this.pnlEmployeeList.Controls.Add(this.btnAddEmployeeList);
            this.pnlEmployeeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEmployeeList.Location = new System.Drawing.Point(0, 473);
            this.pnlEmployeeList.Name = "pnlEmployeeList";
            this.pnlEmployeeList.Size = new System.Drawing.Size(930, 121);
            this.pnlEmployeeList.TabIndex = 2;
            // 
            // btnDeleteEmployeeList
            // 
            this.btnDeleteEmployeeList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteEmployeeList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployeeList.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteEmployeeList.Location = new System.Drawing.Point(324, 27);
            this.btnDeleteEmployeeList.Name = "btnDeleteEmployeeList";
            this.btnDeleteEmployeeList.Size = new System.Drawing.Size(150, 70);
            this.btnDeleteEmployeeList.TabIndex = 2;
            this.btnDeleteEmployeeList.Text = "DELETE";
            this.btnDeleteEmployeeList.UseVisualStyleBackColor = false;
            // 
            // btnCloseEmployeeList
            // 
            this.btnCloseEmployeeList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCloseEmployeeList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseEmployeeList.ForeColor = System.Drawing.Color.DimGray;
            this.btnCloseEmployeeList.Location = new System.Drawing.Point(705, 27);
            this.btnCloseEmployeeList.Name = "btnCloseEmployeeList";
            this.btnCloseEmployeeList.Size = new System.Drawing.Size(150, 70);
            this.btnCloseEmployeeList.TabIndex = 3;
            this.btnCloseEmployeeList.Text = "Close";
            this.btnCloseEmployeeList.UseVisualStyleBackColor = false;
            // 
            // btnUpdateEmployeeList
            // 
            this.btnUpdateEmployeeList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateEmployeeList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployeeList.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateEmployeeList.Location = new System.Drawing.Point(168, 27);
            this.btnUpdateEmployeeList.Name = "btnUpdateEmployeeList";
            this.btnUpdateEmployeeList.Size = new System.Drawing.Size(150, 70);
            this.btnUpdateEmployeeList.TabIndex = 1;
            this.btnUpdateEmployeeList.Text = "Update";
            this.btnUpdateEmployeeList.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployeeList
            // 
            this.btnAddEmployeeList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddEmployeeList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployeeList.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddEmployeeList.Location = new System.Drawing.Point(12, 27);
            this.btnAddEmployeeList.Name = "btnAddEmployeeList";
            this.btnAddEmployeeList.Size = new System.Drawing.Size(150, 70);
            this.btnAddEmployeeList.TabIndex = 0;
            this.btnAddEmployeeList.Text = "Add";
            this.btnAddEmployeeList.UseVisualStyleBackColor = false;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(930, 473);
            this.dgvEmployeeList.TabIndex = 3;
            // 
            // pnlEmployeeListTop
            // 
            this.pnlEmployeeListTop.BackColor = System.Drawing.Color.LightGray;
            this.pnlEmployeeListTop.Controls.Add(this.cmbPositionSelect);
            this.pnlEmployeeListTop.Controls.Add(this.lblPositionSelect);
            this.pnlEmployeeListTop.Controls.Add(this.cmbDepartmentSelect);
            this.pnlEmployeeListTop.Controls.Add(this.btnClearEmployee);
            this.pnlEmployeeListTop.Controls.Add(this.btnSearchEmployee);
            this.pnlEmployeeListTop.Controls.Add(this.lblDepartmentSelect);
            this.pnlEmployeeListTop.Controls.Add(this.txtEmployeeSurname);
            this.pnlEmployeeListTop.Controls.Add(this.lblEmployeeSurname);
            this.pnlEmployeeListTop.Controls.Add(this.txtEmployeeName);
            this.pnlEmployeeListTop.Controls.Add(this.txtEmployeeIDSearch);
            this.pnlEmployeeListTop.Controls.Add(this.lblEmployeeName);
            this.pnlEmployeeListTop.Controls.Add(this.lblEmployeeIDSearch);
            this.pnlEmployeeListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeeListTop.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeListTop.Name = "pnlEmployeeListTop";
            this.pnlEmployeeListTop.Size = new System.Drawing.Size(930, 169);
            this.pnlEmployeeListTop.TabIndex = 0;
            // 
            // cmbPositionSelect
            // 
            this.cmbPositionSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSelect.FormattingEnabled = true;
            this.cmbPositionSelect.Location = new System.Drawing.Point(533, 68);
            this.cmbPositionSelect.Name = "cmbPositionSelect";
            this.cmbPositionSelect.Size = new System.Drawing.Size(217, 28);
            this.cmbPositionSelect.TabIndex = 4;
            // 
            // lblPositionSelect
            // 
            this.lblPositionSelect.AutoSize = true;
            this.lblPositionSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblPositionSelect.Location = new System.Drawing.Point(421, 71);
            this.lblPositionSelect.Name = "lblPositionSelect";
            this.lblPositionSelect.Size = new System.Drawing.Size(67, 20);
            this.lblPositionSelect.TabIndex = 0;
            this.lblPositionSelect.Text = "Position";
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(533, 25);
            this.cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            this.cmbDepartmentSelect.Size = new System.Drawing.Size(217, 28);
            this.cmbDepartmentSelect.TabIndex = 3;
            // 
            // btnClearEmployee
            // 
            this.btnClearEmployee.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearEmployee.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.btnClearEmployee.Location = new System.Drawing.Point(768, 84);
            this.btnClearEmployee.Name = "btnClearEmployee";
            this.btnClearEmployee.Size = new System.Drawing.Size(150, 54);
            this.btnClearEmployee.TabIndex = 6;
            this.btnClearEmployee.Text = "Clear";
            this.btnClearEmployee.UseVisualStyleBackColor = false;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearchEmployee.Location = new System.Drawing.Point(768, 21);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(150, 54);
            this.btnSearchEmployee.TabIndex = 5;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            // 
            // lblDepartmentSelect
            // 
            this.lblDepartmentSelect.AutoSize = true;
            this.lblDepartmentSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblDepartmentSelect.Location = new System.Drawing.Point(421, 28);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 0;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(185, 112);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeSurname.TabIndex = 2;
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeSurname.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(30, 115);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(149, 20);
            this.lblEmployeeSurname.TabIndex = 0;
            this.lblEmployeeSurname.Text = "Employee Surname";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(185, 68);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeIDSearch
            // 
            this.txtEmployeeIDSearch.BackColor = System.Drawing.Color.White;
            this.txtEmployeeIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDSearch.Location = new System.Drawing.Point(185, 25);
            this.txtEmployeeIDSearch.Name = "txtEmployeeIDSearch";
            this.txtEmployeeIDSearch.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeIDSearch.TabIndex = 0;
            this.txtEmployeeIDSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeIDSearch_KeyPress);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeName.Location = new System.Drawing.Point(30, 71);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 20);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeIDSearch
            // 
            this.lblEmployeeIDSearch.AutoSize = true;
            this.lblEmployeeIDSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeIDSearch.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeIDSearch.Location = new System.Drawing.Point(30, 28);
            this.lblEmployeeIDSearch.Name = "lblEmployeeIDSearch";
            this.lblEmployeeIDSearch.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeIDSearch.TabIndex = 0;
            this.lblEmployeeIDSearch.Text = "Employee ID";
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(930, 594);
            this.Controls.Add(this.pnlEmployeeListTop);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.pnlEmployeeList);
            this.Name = "FrmEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.pnlEmployeeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnlEmployeeListTop.ResumeLayout(false);
            this.pnlEmployeeListTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeList;
        private System.Windows.Forms.Button btnDeleteEmployeeList;
        private System.Windows.Forms.Button btnCloseEmployeeList;
        private System.Windows.Forms.Button btnUpdateEmployeeList;
        private System.Windows.Forms.Button btnAddEmployeeList;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Panel pnlEmployeeListTop;
        private System.Windows.Forms.TextBox txtEmployeeIDSearch;
        private System.Windows.Forms.Label lblEmployeeIDSearch;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.ComboBox cmbPositionSelect;
        private System.Windows.Forms.Label lblPositionSelect;
        private System.Windows.Forms.Button btnClearEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
    }
}