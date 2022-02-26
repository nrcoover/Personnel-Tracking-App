
namespace PersonnelTracking
{
    partial class FrmSalaryList
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
            this.pnlSalaryListMaster = new System.Windows.Forms.Panel();
            this.pnlEmployeeSalaryList = new System.Windows.Forms.Panel();
            this.btnClearTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLess = new System.Windows.Forms.RadioButton();
            this.rdbEquals = new System.Windows.Forms.RadioButton();
            this.rdbMore = new System.Windows.Forms.RadioButton();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.cmbSalaryMonth = new System.Windows.Forms.ComboBox();
            this.lblSalaryMonth = new System.Windows.Forms.Label();
            this.txtSalaryYear = new System.Windows.Forms.TextBox();
            this.lblSalaryYear = new System.Windows.Forms.Label();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.pnlAdminSalaryList = new System.Windows.Forms.Panel();
            this.cmbPositionSelect = new System.Windows.Forms.ComboBox();
            this.lblPositionSelect = new System.Windows.Forms.Label();
            this.cmbDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.lblDepartmentSelect = new System.Windows.Forms.Label();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeIDSearch = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.pnlSalaryListBottom = new System.Windows.Forms.Panel();
            this.btnDeleteSalaryList = new System.Windows.Forms.Button();
            this.btnCloseSalaryList = new System.Windows.Forms.Button();
            this.btnUpdateSalaryList = new System.Windows.Forms.Button();
            this.btnNewSalaryList = new System.Windows.Forms.Button();
            this.dgvSalaryList = new System.Windows.Forms.DataGridView();
            this.pnlSalaryListMaster.SuspendLayout();
            this.pnlEmployeeSalaryList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAdminSalaryList.SuspendLayout();
            this.pnlSalaryListBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalaryListMaster
            // 
            this.pnlSalaryListMaster.BackColor = System.Drawing.Color.LightGray;
            this.pnlSalaryListMaster.Controls.Add(this.pnlEmployeeSalaryList);
            this.pnlSalaryListMaster.Controls.Add(this.pnlAdminSalaryList);
            this.pnlSalaryListMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalaryListMaster.Location = new System.Drawing.Point(0, 0);
            this.pnlSalaryListMaster.Name = "pnlSalaryListMaster";
            this.pnlSalaryListMaster.Size = new System.Drawing.Size(948, 198);
            this.pnlSalaryListMaster.TabIndex = 0;
            // 
            // pnlEmployeeSalaryList
            // 
            this.pnlEmployeeSalaryList.Controls.Add(this.btnClearTask);
            this.pnlEmployeeSalaryList.Controls.Add(this.groupBox1);
            this.pnlEmployeeSalaryList.Controls.Add(this.btnSearchTask);
            this.pnlEmployeeSalaryList.Controls.Add(this.cmbSalaryMonth);
            this.pnlEmployeeSalaryList.Controls.Add(this.lblSalaryMonth);
            this.pnlEmployeeSalaryList.Controls.Add(this.txtSalaryYear);
            this.pnlEmployeeSalaryList.Controls.Add(this.lblSalaryYear);
            this.pnlEmployeeSalaryList.Controls.Add(this.txtEmployeeSalary);
            this.pnlEmployeeSalaryList.Controls.Add(this.lblEmployeeSalary);
            this.pnlEmployeeSalaryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeSalaryList.Location = new System.Drawing.Point(407, 0);
            this.pnlEmployeeSalaryList.Name = "pnlEmployeeSalaryList";
            this.pnlEmployeeSalaryList.Size = new System.Drawing.Size(541, 198);
            this.pnlEmployeeSalaryList.TabIndex = 1;
            // 
            // btnClearTask
            // 
            this.btnClearTask.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearTask.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTask.ForeColor = System.Drawing.Color.DimGray;
            this.btnClearTask.Location = new System.Drawing.Point(381, 104);
            this.btnClearTask.Name = "btnClearTask";
            this.btnClearTask.Size = new System.Drawing.Size(123, 63);
            this.btnClearTask.TabIndex = 4;
            this.btnClearTask.Text = "Clear";
            this.btnClearTask.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.rdbLess);
            this.groupBox1.Controls.Add(this.rdbEquals);
            this.groupBox1.Controls.Add(this.rdbMore);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(177, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 35);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // rdbLess
            // 
            this.rdbLess.AutoSize = true;
            this.rdbLess.ForeColor = System.Drawing.Color.Gray;
            this.rdbLess.Location = new System.Drawing.Point(72, 12);
            this.rdbLess.Name = "rdbLess";
            this.rdbLess.Size = new System.Drawing.Size(52, 21);
            this.rdbLess.TabIndex = 1;
            this.rdbLess.TabStop = true;
            this.rdbLess.Text = "Less";
            this.rdbLess.UseVisualStyleBackColor = true;
            // 
            // rdbEquals
            // 
            this.rdbEquals.AutoSize = true;
            this.rdbEquals.ForeColor = System.Drawing.Color.Gray;
            this.rdbEquals.Location = new System.Drawing.Point(130, 12);
            this.rdbEquals.Name = "rdbEquals";
            this.rdbEquals.Size = new System.Drawing.Size(67, 21);
            this.rdbEquals.TabIndex = 2;
            this.rdbEquals.TabStop = true;
            this.rdbEquals.Text = "Equals";
            this.rdbEquals.UseVisualStyleBackColor = true;
            // 
            // rdbMore
            // 
            this.rdbMore.AutoSize = true;
            this.rdbMore.ForeColor = System.Drawing.Color.Gray;
            this.rdbMore.Location = new System.Drawing.Point(6, 12);
            this.rdbMore.Name = "rdbMore";
            this.rdbMore.Size = new System.Drawing.Size(60, 21);
            this.rdbMore.TabIndex = 0;
            this.rdbMore.TabStop = true;
            this.rdbMore.Text = "More";
            this.rdbMore.UseVisualStyleBackColor = true;
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearchTask.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTask.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearchTask.Location = new System.Drawing.Point(380, 34);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(124, 64);
            this.btnSearchTask.TabIndex = 3;
            this.btnSearchTask.Text = "Search";
            this.btnSearchTask.UseVisualStyleBackColor = false;
            // 
            // cmbSalaryMonth
            // 
            this.cmbSalaryMonth.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalaryMonth.FormattingEnabled = true;
            this.cmbSalaryMonth.Location = new System.Drawing.Point(178, 139);
            this.cmbSalaryMonth.Name = "cmbSalaryMonth";
            this.cmbSalaryMonth.Size = new System.Drawing.Size(196, 28);
            this.cmbSalaryMonth.TabIndex = 2;
            // 
            // lblSalaryMonth
            // 
            this.lblSalaryMonth.AutoSize = true;
            this.lblSalaryMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaryMonth.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryMonth.ForeColor = System.Drawing.Color.Gray;
            this.lblSalaryMonth.Location = new System.Drawing.Point(43, 142);
            this.lblSalaryMonth.Name = "lblSalaryMonth";
            this.lblSalaryMonth.Size = new System.Drawing.Size(105, 20);
            this.lblSalaryMonth.TabIndex = 28;
            this.lblSalaryMonth.Text = "Salary Month";
            // 
            // txtSalaryYear
            // 
            this.txtSalaryYear.BackColor = System.Drawing.Color.White;
            this.txtSalaryYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryYear.Location = new System.Drawing.Point(178, 107);
            this.txtSalaryYear.Name = "txtSalaryYear";
            this.txtSalaryYear.Size = new System.Drawing.Size(196, 26);
            this.txtSalaryYear.TabIndex = 1;
            // 
            // lblSalaryYear
            // 
            this.lblSalaryYear.AutoSize = true;
            this.lblSalaryYear.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaryYear.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryYear.ForeColor = System.Drawing.Color.Gray;
            this.lblSalaryYear.Location = new System.Drawing.Point(43, 110);
            this.lblSalaryYear.Name = "lblSalaryYear";
            this.lblSalaryYear.Size = new System.Drawing.Size(91, 20);
            this.lblSalaryYear.TabIndex = 26;
            this.lblSalaryYear.Text = "Salary Year";
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSalary.Location = new System.Drawing.Point(177, 34);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(196, 26);
            this.txtEmployeeSalary.TabIndex = 0;
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeSalary.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalary.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(42, 37);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(129, 20);
            this.lblEmployeeSalary.TabIndex = 27;
            this.lblEmployeeSalary.Text = "Employee Salary";
            // 
            // pnlAdminSalaryList
            // 
            this.pnlAdminSalaryList.Controls.Add(this.cmbPositionSelect);
            this.pnlAdminSalaryList.Controls.Add(this.lblPositionSelect);
            this.pnlAdminSalaryList.Controls.Add(this.cmbDepartmentSelect);
            this.pnlAdminSalaryList.Controls.Add(this.lblDepartmentSelect);
            this.pnlAdminSalaryList.Controls.Add(this.txtEmployeeSurname);
            this.pnlAdminSalaryList.Controls.Add(this.lblEmployeeSurname);
            this.pnlAdminSalaryList.Controls.Add(this.txtEmployeeName);
            this.pnlAdminSalaryList.Controls.Add(this.txtEmployeeIDSearch);
            this.pnlAdminSalaryList.Controls.Add(this.lblEmployeeName);
            this.pnlAdminSalaryList.Controls.Add(this.lblEmployeeID);
            this.pnlAdminSalaryList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminSalaryList.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminSalaryList.Name = "pnlAdminSalaryList";
            this.pnlAdminSalaryList.Size = new System.Drawing.Size(407, 198);
            this.pnlAdminSalaryList.TabIndex = 0;
            // 
            // cmbPositionSelect
            // 
            this.cmbPositionSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSelect.FormattingEnabled = true;
            this.cmbPositionSelect.Location = new System.Drawing.Point(134, 150);
            this.cmbPositionSelect.Name = "cmbPositionSelect";
            this.cmbPositionSelect.Size = new System.Drawing.Size(246, 28);
            this.cmbPositionSelect.TabIndex = 4;
            // 
            // lblPositionSelect
            // 
            this.lblPositionSelect.AutoSize = true;
            this.lblPositionSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblPositionSelect.Location = new System.Drawing.Point(27, 153);
            this.lblPositionSelect.Name = "lblPositionSelect";
            this.lblPositionSelect.Size = new System.Drawing.Size(67, 20);
            this.lblPositionSelect.TabIndex = 29;
            this.lblPositionSelect.Text = "Position";
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(134, 116);
            this.cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            this.cmbDepartmentSelect.Size = new System.Drawing.Size(246, 28);
            this.cmbDepartmentSelect.TabIndex = 3;
            // 
            // lblDepartmentSelect
            // 
            this.lblDepartmentSelect.AutoSize = true;
            this.lblDepartmentSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblDepartmentSelect.Location = new System.Drawing.Point(27, 119);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 30;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(182, 84);
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
            this.lblEmployeeSurname.Location = new System.Drawing.Point(27, 87);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(149, 20);
            this.lblEmployeeSurname.TabIndex = 26;
            this.lblEmployeeSurname.Text = "Employee Surname";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(182, 52);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeIDSearch
            // 
            this.txtEmployeeIDSearch.BackColor = System.Drawing.Color.White;
            this.txtEmployeeIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDSearch.Location = new System.Drawing.Point(182, 20);
            this.txtEmployeeIDSearch.Name = "txtEmployeeIDSearch";
            this.txtEmployeeIDSearch.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeIDSearch.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeName.Location = new System.Drawing.Point(27, 55);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 20);
            this.lblEmployeeName.TabIndex = 27;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeID.Location = new System.Drawing.Point(27, 23);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeID.TabIndex = 28;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // pnlSalaryListBottom
            // 
            this.pnlSalaryListBottom.BackColor = System.Drawing.Color.LightGray;
            this.pnlSalaryListBottom.Controls.Add(this.btnDeleteSalaryList);
            this.pnlSalaryListBottom.Controls.Add(this.btnCloseSalaryList);
            this.pnlSalaryListBottom.Controls.Add(this.btnUpdateSalaryList);
            this.pnlSalaryListBottom.Controls.Add(this.btnNewSalaryList);
            this.pnlSalaryListBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSalaryListBottom.Location = new System.Drawing.Point(0, 452);
            this.pnlSalaryListBottom.Name = "pnlSalaryListBottom";
            this.pnlSalaryListBottom.Size = new System.Drawing.Size(948, 110);
            this.pnlSalaryListBottom.TabIndex = 1;
            // 
            // btnDeleteSalaryList
            // 
            this.btnDeleteSalaryList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteSalaryList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSalaryList.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteSalaryList.Location = new System.Drawing.Point(324, 19);
            this.btnDeleteSalaryList.Name = "btnDeleteSalaryList";
            this.btnDeleteSalaryList.Size = new System.Drawing.Size(150, 70);
            this.btnDeleteSalaryList.TabIndex = 2;
            this.btnDeleteSalaryList.Text = "DELETE";
            this.btnDeleteSalaryList.UseVisualStyleBackColor = false;
            // 
            // btnCloseSalaryList
            // 
            this.btnCloseSalaryList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCloseSalaryList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSalaryList.ForeColor = System.Drawing.Color.DimGray;
            this.btnCloseSalaryList.Location = new System.Drawing.Point(786, 19);
            this.btnCloseSalaryList.Name = "btnCloseSalaryList";
            this.btnCloseSalaryList.Size = new System.Drawing.Size(150, 70);
            this.btnCloseSalaryList.TabIndex = 3;
            this.btnCloseSalaryList.Text = "Close";
            this.btnCloseSalaryList.UseVisualStyleBackColor = false;
            this.btnCloseSalaryList.Click += new System.EventHandler(this.btnCloseSalaryList_Click);
            // 
            // btnUpdateSalaryList
            // 
            this.btnUpdateSalaryList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateSalaryList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSalaryList.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateSalaryList.Location = new System.Drawing.Point(168, 19);
            this.btnUpdateSalaryList.Name = "btnUpdateSalaryList";
            this.btnUpdateSalaryList.Size = new System.Drawing.Size(150, 70);
            this.btnUpdateSalaryList.TabIndex = 1;
            this.btnUpdateSalaryList.Text = "Update";
            this.btnUpdateSalaryList.UseVisualStyleBackColor = false;
            // 
            // btnNewSalaryList
            // 
            this.btnNewSalaryList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewSalaryList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSalaryList.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewSalaryList.Location = new System.Drawing.Point(12, 19);
            this.btnNewSalaryList.Name = "btnNewSalaryList";
            this.btnNewSalaryList.Size = new System.Drawing.Size(150, 70);
            this.btnNewSalaryList.TabIndex = 0;
            this.btnNewSalaryList.Text = "New";
            this.btnNewSalaryList.UseVisualStyleBackColor = false;
            // 
            // dgvSalaryList
            // 
            this.dgvSalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalaryList.Location = new System.Drawing.Point(0, 198);
            this.dgvSalaryList.Name = "dgvSalaryList";
            this.dgvSalaryList.Size = new System.Drawing.Size(948, 254);
            this.dgvSalaryList.TabIndex = 2;
            // 
            // FrmSalaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.dgvSalaryList);
            this.Controls.Add(this.pnlSalaryListBottom);
            this.Controls.Add(this.pnlSalaryListMaster);
            this.Name = "FrmSalaryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary List";
            this.pnlSalaryListMaster.ResumeLayout(false);
            this.pnlEmployeeSalaryList.ResumeLayout(false);
            this.pnlEmployeeSalaryList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAdminSalaryList.ResumeLayout(false);
            this.pnlAdminSalaryList.PerformLayout();
            this.pnlSalaryListBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalaryListMaster;
        private System.Windows.Forms.Panel pnlSalaryListBottom;
        private System.Windows.Forms.DataGridView dgvSalaryList;
        private System.Windows.Forms.Button btnDeleteSalaryList;
        private System.Windows.Forms.Button btnCloseSalaryList;
        private System.Windows.Forms.Button btnUpdateSalaryList;
        private System.Windows.Forms.Button btnNewSalaryList;
        private System.Windows.Forms.Panel pnlEmployeeSalaryList;
        private System.Windows.Forms.Panel pnlAdminSalaryList;
        private System.Windows.Forms.ComboBox cmbPositionSelect;
        private System.Windows.Forms.Label lblPositionSelect;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeIDSearch;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ComboBox cmbSalaryMonth;
        private System.Windows.Forms.Label lblSalaryMonth;
        private System.Windows.Forms.TextBox txtSalaryYear;
        private System.Windows.Forms.Label lblSalaryYear;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLess;
        private System.Windows.Forms.RadioButton rdbEquals;
        private System.Windows.Forms.RadioButton rdbMore;
        private System.Windows.Forms.Button btnClearTask;
        private System.Windows.Forms.Button btnSearchTask;
    }
}