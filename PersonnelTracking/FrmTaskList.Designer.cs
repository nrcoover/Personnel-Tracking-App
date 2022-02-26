
namespace PersonnelTracking
{
    partial class FrmTaskList
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
            this.pnlTaskListSearchCriteria = new System.Windows.Forms.Panel();
            this.pnlEmployeeTaskList = new System.Windows.Forms.Panel();
            this.btnClearTask = new System.Windows.Forms.Button();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.lblTaskState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDeliveryDate = new System.Windows.Forms.RadioButton();
            this.rdbStartDate = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblTaskFinish = new System.Windows.Forms.Label();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.blbTaskStart = new System.Windows.Forms.Label();
            this.pnlAdminTaskList = new System.Windows.Forms.Panel();
            this.cmbPositionSelect = new System.Windows.Forms.ComboBox();
            this.lblPositionSelect = new System.Windows.Forms.Label();
            this.cmbDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.lblDepartmentSelect = new System.Windows.Forms.Label();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeIDSearch = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeIDSearch = new System.Windows.Forms.Label();
            this.pnlTaskListBottom = new System.Windows.Forms.Panel();
            this.btnApproveTaskList = new System.Windows.Forms.Button();
            this.btnDeleteTaskList = new System.Windows.Forms.Button();
            this.btnCloseTaskList = new System.Windows.Forms.Button();
            this.btnUpdateTaskList = new System.Windows.Forms.Button();
            this.btnNewTaskList = new System.Windows.Forms.Button();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.pnlTaskListSearchCriteria.SuspendLayout();
            this.pnlEmployeeTaskList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAdminTaskList.SuspendLayout();
            this.pnlTaskListBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTaskListSearchCriteria
            // 
            this.pnlTaskListSearchCriteria.BackColor = System.Drawing.Color.LightGray;
            this.pnlTaskListSearchCriteria.Controls.Add(this.pnlEmployeeTaskList);
            this.pnlTaskListSearchCriteria.Controls.Add(this.pnlAdminTaskList);
            this.pnlTaskListSearchCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskListSearchCriteria.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskListSearchCriteria.Name = "pnlTaskListSearchCriteria";
            this.pnlTaskListSearchCriteria.Size = new System.Drawing.Size(867, 223);
            this.pnlTaskListSearchCriteria.TabIndex = 0;
            // 
            // pnlEmployeeTaskList
            // 
            this.pnlEmployeeTaskList.Controls.Add(this.btnClearTask);
            this.pnlEmployeeTaskList.Controls.Add(this.btnSearchTask);
            this.pnlEmployeeTaskList.Controls.Add(this.cmbTaskState);
            this.pnlEmployeeTaskList.Controls.Add(this.lblTaskState);
            this.pnlEmployeeTaskList.Controls.Add(this.groupBox1);
            this.pnlEmployeeTaskList.Controls.Add(this.dateTimePicker1);
            this.pnlEmployeeTaskList.Controls.Add(this.dtpEmployeeBirthday);
            this.pnlEmployeeTaskList.Controls.Add(this.lblTaskFinish);
            this.pnlEmployeeTaskList.Controls.Add(this.lblTaskDate);
            this.pnlEmployeeTaskList.Controls.Add(this.blbTaskStart);
            this.pnlEmployeeTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeTaskList.Location = new System.Drawing.Point(406, 0);
            this.pnlEmployeeTaskList.Name = "pnlEmployeeTaskList";
            this.pnlEmployeeTaskList.Size = new System.Drawing.Size(461, 223);
            this.pnlEmployeeTaskList.TabIndex = 1;
            // 
            // btnClearTask
            // 
            this.btnClearTask.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearTask.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTask.ForeColor = System.Drawing.Color.DimGray;
            this.btnClearTask.Location = new System.Drawing.Point(239, 143);
            this.btnClearTask.Name = "btnClearTask";
            this.btnClearTask.Size = new System.Drawing.Size(150, 54);
            this.btnClearTask.TabIndex = 4;
            this.btnClearTask.Text = "Clear";
            this.btnClearTask.UseVisualStyleBackColor = false;
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearchTask.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTask.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearchTask.Location = new System.Drawing.Point(83, 143);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(150, 54);
            this.btnSearchTask.TabIndex = 3;
            this.btnSearchTask.Text = "Search";
            this.btnSearchTask.UseVisualStyleBackColor = false;
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(106, 109);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(175, 28);
            this.cmbTaskState.TabIndex = 2;
            // 
            // lblTaskState
            // 
            this.lblTaskState.AutoSize = true;
            this.lblTaskState.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskState.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskState.ForeColor = System.Drawing.Color.Gray;
            this.lblTaskState.Location = new System.Drawing.Point(12, 112);
            this.lblTaskState.Name = "lblTaskState";
            this.lblTaskState.Size = new System.Drawing.Size(84, 20);
            this.lblTaskState.TabIndex = 9;
            this.lblTaskState.Text = "Task State";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.rdbDeliveryDate);
            this.groupBox1.Controls.Add(this.rdbStartDate);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(299, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 71);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rdbDeliveryDate
            // 
            this.rdbDeliveryDate.AutoSize = true;
            this.rdbDeliveryDate.ForeColor = System.Drawing.Color.Gray;
            this.rdbDeliveryDate.Location = new System.Drawing.Point(6, 39);
            this.rdbDeliveryDate.Name = "rdbDeliveryDate";
            this.rdbDeliveryDate.Size = new System.Drawing.Size(110, 21);
            this.rdbDeliveryDate.TabIndex = 1;
            this.rdbDeliveryDate.TabStop = true;
            this.rdbDeliveryDate.Text = "Delivery Date";
            this.rdbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rdbStartDate
            // 
            this.rdbStartDate.AutoSize = true;
            this.rdbStartDate.ForeColor = System.Drawing.Color.Gray;
            this.rdbStartDate.Location = new System.Drawing.Point(6, 12);
            this.rdbStartDate.Name = "rdbStartDate";
            this.rdbStartDate.Size = new System.Drawing.Size(89, 21);
            this.rdbStartDate.TabIndex = 0;
            this.rdbStartDate.TabStop = true;
            this.rdbStartDate.Text = "Start Date";
            this.rdbStartDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dtpEmployeeBirthday
            // 
            this.dtpEmployeeBirthday.Location = new System.Drawing.Point(83, 57);
            this.dtpEmployeeBirthday.Name = "dtpEmployeeBirthday";
            this.dtpEmployeeBirthday.Size = new System.Drawing.Size(198, 20);
            this.dtpEmployeeBirthday.TabIndex = 0;
            // 
            // lblTaskFinish
            // 
            this.lblTaskFinish.AutoSize = true;
            this.lblTaskFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskFinish.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskFinish.ForeColor = System.Drawing.Color.Gray;
            this.lblTaskFinish.Location = new System.Drawing.Point(12, 83);
            this.lblTaskFinish.Name = "lblTaskFinish";
            this.lblTaskFinish.Size = new System.Drawing.Size(51, 20);
            this.lblTaskFinish.TabIndex = 9;
            this.lblTaskFinish.Text = "Finish";
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.AutoSize = true;
            this.lblTaskDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDate.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDate.ForeColor = System.Drawing.Color.Gray;
            this.lblTaskDate.Location = new System.Drawing.Point(12, 28);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(81, 20);
            this.lblTaskDate.TabIndex = 9;
            this.lblTaskDate.Text = "Task Date";
            // 
            // blbTaskStart
            // 
            this.blbTaskStart.AutoSize = true;
            this.blbTaskStart.BackColor = System.Drawing.Color.Transparent;
            this.blbTaskStart.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbTaskStart.ForeColor = System.Drawing.Color.Gray;
            this.blbTaskStart.Location = new System.Drawing.Point(12, 57);
            this.blbTaskStart.Name = "blbTaskStart";
            this.blbTaskStart.Size = new System.Drawing.Size(45, 20);
            this.blbTaskStart.TabIndex = 9;
            this.blbTaskStart.Text = "Start";
            // 
            // pnlAdminTaskList
            // 
            this.pnlAdminTaskList.Controls.Add(this.cmbPositionSelect);
            this.pnlAdminTaskList.Controls.Add(this.lblPositionSelect);
            this.pnlAdminTaskList.Controls.Add(this.cmbDepartmentSelect);
            this.pnlAdminTaskList.Controls.Add(this.lblDepartmentSelect);
            this.pnlAdminTaskList.Controls.Add(this.txtEmployeeSurname);
            this.pnlAdminTaskList.Controls.Add(this.lblEmployeeSurname);
            this.pnlAdminTaskList.Controls.Add(this.txtEmployeeName);
            this.pnlAdminTaskList.Controls.Add(this.txtEmployeeIDSearch);
            this.pnlAdminTaskList.Controls.Add(this.lblEmployeeName);
            this.pnlAdminTaskList.Controls.Add(this.lblEmployeeIDSearch);
            this.pnlAdminTaskList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminTaskList.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminTaskList.Name = "pnlAdminTaskList";
            this.pnlAdminTaskList.Size = new System.Drawing.Size(406, 223);
            this.pnlAdminTaskList.TabIndex = 0;
            // 
            // cmbPositionSelect
            // 
            this.cmbPositionSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSelect.FormattingEnabled = true;
            this.cmbPositionSelect.Location = new System.Drawing.Point(128, 155);
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
            this.lblPositionSelect.Location = new System.Drawing.Point(21, 158);
            this.lblPositionSelect.Name = "lblPositionSelect";
            this.lblPositionSelect.Size = new System.Drawing.Size(67, 20);
            this.lblPositionSelect.TabIndex = 9;
            this.lblPositionSelect.Text = "Position";
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(128, 121);
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
            this.lblDepartmentSelect.Location = new System.Drawing.Point(21, 124);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 10;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(176, 89);
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
            this.lblEmployeeSurname.Location = new System.Drawing.Point(21, 92);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(149, 20);
            this.lblEmployeeSurname.TabIndex = 3;
            this.lblEmployeeSurname.Text = "Employee Surname";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(176, 57);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeIDSearch
            // 
            this.txtEmployeeIDSearch.BackColor = System.Drawing.Color.White;
            this.txtEmployeeIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDSearch.Location = new System.Drawing.Point(176, 25);
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
            this.lblEmployeeName.Location = new System.Drawing.Point(21, 60);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 20);
            this.lblEmployeeName.TabIndex = 5;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeIDSearch
            // 
            this.lblEmployeeIDSearch.AutoSize = true;
            this.lblEmployeeIDSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeIDSearch.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeIDSearch.Location = new System.Drawing.Point(21, 28);
            this.lblEmployeeIDSearch.Name = "lblEmployeeIDSearch";
            this.lblEmployeeIDSearch.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeIDSearch.TabIndex = 6;
            this.lblEmployeeIDSearch.Text = "Employee ID";
            // 
            // pnlTaskListBottom
            // 
            this.pnlTaskListBottom.BackColor = System.Drawing.Color.LightGray;
            this.pnlTaskListBottom.Controls.Add(this.btnApproveTaskList);
            this.pnlTaskListBottom.Controls.Add(this.btnDeleteTaskList);
            this.pnlTaskListBottom.Controls.Add(this.btnCloseTaskList);
            this.pnlTaskListBottom.Controls.Add(this.btnUpdateTaskList);
            this.pnlTaskListBottom.Controls.Add(this.btnNewTaskList);
            this.pnlTaskListBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTaskListBottom.Location = new System.Drawing.Point(0, 472);
            this.pnlTaskListBottom.Name = "pnlTaskListBottom";
            this.pnlTaskListBottom.Size = new System.Drawing.Size(867, 116);
            this.pnlTaskListBottom.TabIndex = 1;
            // 
            // btnApproveTaskList
            // 
            this.btnApproveTaskList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnApproveTaskList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveTaskList.ForeColor = System.Drawing.Color.DimGray;
            this.btnApproveTaskList.Location = new System.Drawing.Point(12, 24);
            this.btnApproveTaskList.Name = "btnApproveTaskList";
            this.btnApproveTaskList.Size = new System.Drawing.Size(150, 70);
            this.btnApproveTaskList.TabIndex = 0;
            this.btnApproveTaskList.Text = "Approve";
            this.btnApproveTaskList.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTaskList
            // 
            this.btnDeleteTaskList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteTaskList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTaskList.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteTaskList.Location = new System.Drawing.Point(480, 24);
            this.btnDeleteTaskList.Name = "btnDeleteTaskList";
            this.btnDeleteTaskList.Size = new System.Drawing.Size(150, 70);
            this.btnDeleteTaskList.TabIndex = 3;
            this.btnDeleteTaskList.Text = "DELETE";
            this.btnDeleteTaskList.UseVisualStyleBackColor = false;
            // 
            // btnCloseTaskList
            // 
            this.btnCloseTaskList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCloseTaskList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTaskList.ForeColor = System.Drawing.Color.DimGray;
            this.btnCloseTaskList.Location = new System.Drawing.Point(705, 24);
            this.btnCloseTaskList.Name = "btnCloseTaskList";
            this.btnCloseTaskList.Size = new System.Drawing.Size(150, 70);
            this.btnCloseTaskList.TabIndex = 4;
            this.btnCloseTaskList.Text = "Close";
            this.btnCloseTaskList.UseVisualStyleBackColor = false;
            this.btnCloseTaskList.Click += new System.EventHandler(this.btnCloseTaskList_Click);
            // 
            // btnUpdateTaskList
            // 
            this.btnUpdateTaskList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateTaskList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTaskList.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdateTaskList.Location = new System.Drawing.Point(324, 24);
            this.btnUpdateTaskList.Name = "btnUpdateTaskList";
            this.btnUpdateTaskList.Size = new System.Drawing.Size(150, 70);
            this.btnUpdateTaskList.TabIndex = 2;
            this.btnUpdateTaskList.Text = "Update";
            this.btnUpdateTaskList.UseVisualStyleBackColor = false;
            // 
            // btnNewTaskList
            // 
            this.btnNewTaskList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewTaskList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTaskList.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewTaskList.Location = new System.Drawing.Point(168, 24);
            this.btnNewTaskList.Name = "btnNewTaskList";
            this.btnNewTaskList.Size = new System.Drawing.Size(150, 70);
            this.btnNewTaskList.TabIndex = 1;
            this.btnNewTaskList.Text = "New";
            this.btnNewTaskList.UseVisualStyleBackColor = false;
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskList.Location = new System.Drawing.Point(0, 223);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.Size = new System.Drawing.Size(867, 249);
            this.dgvTaskList.TabIndex = 2;
            // 
            // FrmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(867, 588);
            this.Controls.Add(this.dgvTaskList);
            this.Controls.Add(this.pnlTaskListBottom);
            this.Controls.Add(this.pnlTaskListSearchCriteria);
            this.Name = "FrmTaskList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task List";
            this.pnlTaskListSearchCriteria.ResumeLayout(false);
            this.pnlEmployeeTaskList.ResumeLayout(false);
            this.pnlEmployeeTaskList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAdminTaskList.ResumeLayout(false);
            this.pnlAdminTaskList.PerformLayout();
            this.pnlTaskListBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTaskListSearchCriteria;
        private System.Windows.Forms.Panel pnlTaskListBottom;
        private System.Windows.Forms.DataGridView dgvTaskList;
        private System.Windows.Forms.Button btnDeleteTaskList;
        private System.Windows.Forms.Button btnCloseTaskList;
        private System.Windows.Forms.Button btnUpdateTaskList;
        private System.Windows.Forms.Button btnNewTaskList;
        private System.Windows.Forms.Button btnApproveTaskList;
        private System.Windows.Forms.Panel pnlEmployeeTaskList;
        private System.Windows.Forms.Panel pnlAdminTaskList;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeIDSearch;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeIDSearch;
        private System.Windows.Forms.ComboBox cmbPositionSelect;
        private System.Windows.Forms.Label lblPositionSelect;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Label lblTaskState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDeliveryDate;
        private System.Windows.Forms.RadioButton rdbStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBirthday;
        private System.Windows.Forms.Label lblTaskFinish;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Label blbTaskStart;
        private System.Windows.Forms.Button btnClearTask;
        private System.Windows.Forms.Button btnSearchTask;
    }
}