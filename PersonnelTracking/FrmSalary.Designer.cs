
namespace PersonnelTracking
{
    partial class FrmSalary
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
            this.pnlSalaryMaster = new System.Windows.Forms.Panel();
            this.pnlSalaryChildTop = new System.Windows.Forms.Panel();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeIDSearch = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeIDSearch = new System.Windows.Forms.Label();
            this.cmbPositionSelect = new System.Windows.Forms.ComboBox();
            this.cmbDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.lblPositionSelect = new System.Windows.Forms.Label();
            this.lblDepartmentSelect = new System.Windows.Forms.Label();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.lblSalaryYear = new System.Windows.Forms.Label();
            this.txtSalaryYear = new System.Windows.Forms.TextBox();
            this.cmbSalaryMonth = new System.Windows.Forms.ComboBox();
            this.lblSalaryMonth = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSalaryMaster.SuspendLayout();
            this.pnlSalaryChildTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalaryMaster
            // 
            this.pnlSalaryMaster.BackColor = System.Drawing.Color.LightGray;
            this.pnlSalaryMaster.Controls.Add(this.dgvSalary);
            this.pnlSalaryMaster.Controls.Add(this.pnlSalaryChildTop);
            this.pnlSalaryMaster.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSalaryMaster.Location = new System.Drawing.Point(435, 0);
            this.pnlSalaryMaster.Name = "pnlSalaryMaster";
            this.pnlSalaryMaster.Size = new System.Drawing.Size(301, 463);
            this.pnlSalaryMaster.TabIndex = 0;
            // 
            // pnlSalaryChildTop
            // 
            this.pnlSalaryChildTop.Controls.Add(this.cmbPositionSelect);
            this.pnlSalaryChildTop.Controls.Add(this.cmbDepartmentSelect);
            this.pnlSalaryChildTop.Controls.Add(this.lblPositionSelect);
            this.pnlSalaryChildTop.Controls.Add(this.lblDepartmentSelect);
            this.pnlSalaryChildTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalaryChildTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSalaryChildTop.Name = "pnlSalaryChildTop";
            this.pnlSalaryChildTop.Size = new System.Drawing.Size(301, 164);
            this.pnlSalaryChildTop.TabIndex = 0;
            // 
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.Location = new System.Drawing.Point(0, 164);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.Size = new System.Drawing.Size(301, 299);
            this.dgvSalary.TabIndex = 1;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(193, 104);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.ReadOnly = true;
            this.txtEmployeeSurname.Size = new System.Drawing.Size(180, 26);
            this.txtEmployeeSurname.TabIndex = 15;
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeSurname.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(38, 107);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(149, 20);
            this.lblEmployeeSurname.TabIndex = 16;
            this.lblEmployeeSurname.Text = "Employee Surname";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(193, 72);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(180, 26);
            this.txtEmployeeName.TabIndex = 14;
            // 
            // txtEmployeeIDSearch
            // 
            this.txtEmployeeIDSearch.BackColor = System.Drawing.Color.White;
            this.txtEmployeeIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDSearch.Location = new System.Drawing.Point(193, 40);
            this.txtEmployeeIDSearch.Name = "txtEmployeeIDSearch";
            this.txtEmployeeIDSearch.ReadOnly = true;
            this.txtEmployeeIDSearch.Size = new System.Drawing.Size(180, 26);
            this.txtEmployeeIDSearch.TabIndex = 13;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeName.Location = new System.Drawing.Point(38, 75);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 20);
            this.lblEmployeeName.TabIndex = 17;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeIDSearch
            // 
            this.lblEmployeeIDSearch.AutoSize = true;
            this.lblEmployeeIDSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeIDSearch.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeIDSearch.Location = new System.Drawing.Point(38, 43);
            this.lblEmployeeIDSearch.Name = "lblEmployeeIDSearch";
            this.lblEmployeeIDSearch.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeIDSearch.TabIndex = 18;
            this.lblEmployeeIDSearch.Text = "Employee ID";
            // 
            // cmbPositionSelect
            // 
            this.cmbPositionSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSelect.FormattingEnabled = true;
            this.cmbPositionSelect.Location = new System.Drawing.Point(25, 107);
            this.cmbPositionSelect.Name = "cmbPositionSelect";
            this.cmbPositionSelect.Size = new System.Drawing.Size(174, 28);
            this.cmbPositionSelect.TabIndex = 1;
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(25, 43);
            this.cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            this.cmbDepartmentSelect.Size = new System.Drawing.Size(174, 28);
            this.cmbDepartmentSelect.TabIndex = 0;
            // 
            // lblPositionSelect
            // 
            this.lblPositionSelect.AutoSize = true;
            this.lblPositionSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblPositionSelect.Location = new System.Drawing.Point(21, 84);
            this.lblPositionSelect.Name = "lblPositionSelect";
            this.lblPositionSelect.Size = new System.Drawing.Size(67, 20);
            this.lblPositionSelect.TabIndex = 17;
            this.lblPositionSelect.Text = "Position";
            // 
            // lblDepartmentSelect
            // 
            this.lblDepartmentSelect.AutoSize = true;
            this.lblDepartmentSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblDepartmentSelect.Location = new System.Drawing.Point(21, 20);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 18;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSalary.Location = new System.Drawing.Point(193, 164);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(180, 26);
            this.txtEmployeeSalary.TabIndex = 0;
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeSalary.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalary.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(38, 167);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(129, 20);
            this.lblEmployeeSalary.TabIndex = 19;
            this.lblEmployeeSalary.Text = "Employee Salary";
            // 
            // lblSalaryYear
            // 
            this.lblSalaryYear.AutoSize = true;
            this.lblSalaryYear.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaryYear.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryYear.ForeColor = System.Drawing.Color.Gray;
            this.lblSalaryYear.Location = new System.Drawing.Point(38, 199);
            this.lblSalaryYear.Name = "lblSalaryYear";
            this.lblSalaryYear.Size = new System.Drawing.Size(91, 20);
            this.lblSalaryYear.TabIndex = 19;
            this.lblSalaryYear.Text = "Salary Year";
            // 
            // txtSalaryYear
            // 
            this.txtSalaryYear.BackColor = System.Drawing.Color.White;
            this.txtSalaryYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryYear.Location = new System.Drawing.Point(193, 196);
            this.txtSalaryYear.Name = "txtSalaryYear";
            this.txtSalaryYear.Size = new System.Drawing.Size(180, 26);
            this.txtSalaryYear.TabIndex = 1;
            // 
            // cmbSalaryMonth
            // 
            this.cmbSalaryMonth.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalaryMonth.FormattingEnabled = true;
            this.cmbSalaryMonth.Location = new System.Drawing.Point(193, 228);
            this.cmbSalaryMonth.Name = "cmbSalaryMonth";
            this.cmbSalaryMonth.Size = new System.Drawing.Size(180, 28);
            this.cmbSalaryMonth.TabIndex = 2;
            // 
            // lblSalaryMonth
            // 
            this.lblSalaryMonth.AutoSize = true;
            this.lblSalaryMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaryMonth.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryMonth.ForeColor = System.Drawing.Color.Gray;
            this.lblSalaryMonth.Location = new System.Drawing.Point(38, 231);
            this.lblSalaryMonth.Name = "lblSalaryMonth";
            this.lblSalaryMonth.Size = new System.Drawing.Size(105, 20);
            this.lblSalaryMonth.TabIndex = 22;
            this.lblSalaryMonth.Text = "Salary Month";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Location = new System.Drawing.Point(67, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.Location = new System.Drawing.Point(223, 293);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(736, 463);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbSalaryMonth);
            this.Controls.Add(this.lblSalaryMonth);
            this.Controls.Add(this.txtSalaryYear);
            this.Controls.Add(this.lblSalaryYear);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.lblEmployeeSalary);
            this.Controls.Add(this.txtEmployeeSurname);
            this.Controls.Add(this.lblEmployeeSurname);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeIDSearch);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeIDSearch);
            this.Controls.Add(this.pnlSalaryMaster);
            this.Name = "FrmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.pnlSalaryMaster.ResumeLayout(false);
            this.pnlSalaryChildTop.ResumeLayout(false);
            this.pnlSalaryChildTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalaryMaster;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Panel pnlSalaryChildTop;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeIDSearch;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeIDSearch;
        private System.Windows.Forms.ComboBox cmbPositionSelect;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Label lblPositionSelect;
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label lblSalaryYear;
        private System.Windows.Forms.TextBox txtSalaryYear;
        private System.Windows.Forms.ComboBox cmbSalaryMonth;
        private System.Windows.Forms.Label lblSalaryMonth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}