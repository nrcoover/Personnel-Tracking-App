
namespace PersonnelTracking
{
    partial class FrmPermissionList
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
            this.pnlPermissionListTop = new System.Windows.Forms.Panel();
            this.pnlEmployeePermissionList = new System.Windows.Forms.Panel();
            this.btnClearTask = new System.Windows.Forms.Button();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.lblDayAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDeliveryDate = new System.Windows.Forms.RadioButton();
            this.rdbStartDate = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblTaskFinish = new System.Windows.Forms.Label();
            this.txtDayAmount = new System.Windows.Forms.TextBox();
            this.lblPermissionDate = new System.Windows.Forms.Label();
            this.blbTaskStart = new System.Windows.Forms.Label();
            this.pnlAdminPermissionList = new System.Windows.Forms.Panel();
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
            this.pnlPermissionListBottom = new System.Windows.Forms.Panel();
            this.btnDisaprove = new System.Windows.Forms.Button();
            this.btnApprovePermissionList = new System.Windows.Forms.Button();
            this.btnDeletePermissionList = new System.Windows.Forms.Button();
            this.btnClosePermissionList = new System.Windows.Forms.Button();
            this.btnUpdatePermissionList = new System.Windows.Forms.Button();
            this.btnNewPermissionList = new System.Windows.Forms.Button();
            this.dgvPermissionList = new System.Windows.Forms.DataGridView();
            this.pnlPermissionListTop.SuspendLayout();
            this.pnlEmployeePermissionList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAdminPermissionList.SuspendLayout();
            this.pnlPermissionListBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissionList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPermissionListTop
            // 
            this.pnlPermissionListTop.BackColor = System.Drawing.Color.LightGray;
            this.pnlPermissionListTop.Controls.Add(this.pnlEmployeePermissionList);
            this.pnlPermissionListTop.Controls.Add(this.pnlAdminPermissionList);
            this.pnlPermissionListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPermissionListTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPermissionListTop.Name = "pnlPermissionListTop";
            this.pnlPermissionListTop.Size = new System.Drawing.Size(902, 221);
            this.pnlPermissionListTop.TabIndex = 0;
            // 
            // pnlEmployeePermissionList
            // 
            this.pnlEmployeePermissionList.Controls.Add(this.btnClearTask);
            this.pnlEmployeePermissionList.Controls.Add(this.btnSearchTask);
            this.pnlEmployeePermissionList.Controls.Add(this.lblDayAmount);
            this.pnlEmployeePermissionList.Controls.Add(this.groupBox1);
            this.pnlEmployeePermissionList.Controls.Add(this.dateTimePicker1);
            this.pnlEmployeePermissionList.Controls.Add(this.dtpEmployeeBirthday);
            this.pnlEmployeePermissionList.Controls.Add(this.lblTaskFinish);
            this.pnlEmployeePermissionList.Controls.Add(this.txtDayAmount);
            this.pnlEmployeePermissionList.Controls.Add(this.lblPermissionDate);
            this.pnlEmployeePermissionList.Controls.Add(this.blbTaskStart);
            this.pnlEmployeePermissionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeePermissionList.Location = new System.Drawing.Point(421, 0);
            this.pnlEmployeePermissionList.Name = "pnlEmployeePermissionList";
            this.pnlEmployeePermissionList.Size = new System.Drawing.Size(481, 221);
            this.pnlEmployeePermissionList.TabIndex = 1;
            // 
            // btnClearTask
            // 
            this.btnClearTask.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearTask.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTask.ForeColor = System.Drawing.Color.DimGray;
            this.btnClearTask.Location = new System.Drawing.Point(259, 141);
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
            this.btnSearchTask.Location = new System.Drawing.Point(103, 141);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(150, 54);
            this.btnSearchTask.TabIndex = 3;
            this.btnSearchTask.Text = "Search";
            this.btnSearchTask.UseVisualStyleBackColor = false;
            // 
            // lblDayAmount
            // 
            this.lblDayAmount.AutoSize = true;
            this.lblDayAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblDayAmount.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAmount.ForeColor = System.Drawing.Color.Gray;
            this.lblDayAmount.Location = new System.Drawing.Point(32, 110);
            this.lblDayAmount.Name = "lblDayAmount";
            this.lblDayAmount.Size = new System.Drawing.Size(99, 20);
            this.lblDayAmount.TabIndex = 17;
            this.lblDayAmount.Text = "Day Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.rdbDeliveryDate);
            this.groupBox1.Controls.Add(this.rdbStartDate);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(319, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 71);
            this.groupBox1.TabIndex = 21;
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
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dtpEmployeeBirthday
            // 
            this.dtpEmployeeBirthday.Location = new System.Drawing.Point(103, 55);
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
            this.lblTaskFinish.Location = new System.Drawing.Point(32, 81);
            this.lblTaskFinish.Name = "lblTaskFinish";
            this.lblTaskFinish.Size = new System.Drawing.Size(51, 20);
            this.lblTaskFinish.TabIndex = 18;
            this.lblTaskFinish.Text = "Finish";
            // 
            // txtDayAmount
            // 
            this.txtDayAmount.BackColor = System.Drawing.Color.White;
            this.txtDayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayAmount.Location = new System.Drawing.Point(137, 110);
            this.txtDayAmount.Name = "txtDayAmount";
            this.txtDayAmount.Size = new System.Drawing.Size(164, 26);
            this.txtDayAmount.TabIndex = 2;
            this.txtDayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDayAmount_KeyPress);
            // 
            // lblPermissionDate
            // 
            this.lblPermissionDate.AutoSize = true;
            this.lblPermissionDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPermissionDate.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissionDate.ForeColor = System.Drawing.Color.Gray;
            this.lblPermissionDate.Location = new System.Drawing.Point(32, 26);
            this.lblPermissionDate.Name = "lblPermissionDate";
            this.lblPermissionDate.Size = new System.Drawing.Size(124, 20);
            this.lblPermissionDate.TabIndex = 19;
            this.lblPermissionDate.Text = "PermissionDate";
            // 
            // blbTaskStart
            // 
            this.blbTaskStart.AutoSize = true;
            this.blbTaskStart.BackColor = System.Drawing.Color.Transparent;
            this.blbTaskStart.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbTaskStart.ForeColor = System.Drawing.Color.Gray;
            this.blbTaskStart.Location = new System.Drawing.Point(32, 55);
            this.blbTaskStart.Name = "blbTaskStart";
            this.blbTaskStart.Size = new System.Drawing.Size(45, 20);
            this.blbTaskStart.TabIndex = 20;
            this.blbTaskStart.Text = "Start";
            // 
            // pnlAdminPermissionList
            // 
            this.pnlAdminPermissionList.Controls.Add(this.cmbPositionSelect);
            this.pnlAdminPermissionList.Controls.Add(this.lblPositionSelect);
            this.pnlAdminPermissionList.Controls.Add(this.cmbDepartmentSelect);
            this.pnlAdminPermissionList.Controls.Add(this.lblDepartmentSelect);
            this.pnlAdminPermissionList.Controls.Add(this.txtEmployeeSurname);
            this.pnlAdminPermissionList.Controls.Add(this.lblEmployeeSurname);
            this.pnlAdminPermissionList.Controls.Add(this.txtEmployeeName);
            this.pnlAdminPermissionList.Controls.Add(this.txtEmployeeIDSearch);
            this.pnlAdminPermissionList.Controls.Add(this.lblEmployeeName);
            this.pnlAdminPermissionList.Controls.Add(this.lblEmployeeID);
            this.pnlAdminPermissionList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminPermissionList.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminPermissionList.Name = "pnlAdminPermissionList";
            this.pnlAdminPermissionList.Size = new System.Drawing.Size(421, 221);
            this.pnlAdminPermissionList.TabIndex = 0;
            // 
            // cmbPositionSelect
            // 
            this.cmbPositionSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSelect.FormattingEnabled = true;
            this.cmbPositionSelect.Location = new System.Drawing.Point(137, 161);
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
            this.lblPositionSelect.Location = new System.Drawing.Point(30, 164);
            this.lblPositionSelect.Name = "lblPositionSelect";
            this.lblPositionSelect.Size = new System.Drawing.Size(67, 20);
            this.lblPositionSelect.TabIndex = 19;
            this.lblPositionSelect.Text = "Position";
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(137, 127);
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
            this.lblDepartmentSelect.Location = new System.Drawing.Point(30, 130);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 20;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(185, 95);
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
            this.lblEmployeeSurname.Location = new System.Drawing.Point(30, 98);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(149, 20);
            this.lblEmployeeSurname.TabIndex = 15;
            this.lblEmployeeSurname.Text = "Employee Surname";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(185, 63);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeIDSearch
            // 
            this.txtEmployeeIDSearch.BackColor = System.Drawing.Color.White;
            this.txtEmployeeIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDSearch.Location = new System.Drawing.Point(185, 31);
            this.txtEmployeeIDSearch.Name = "txtEmployeeIDSearch";
            this.txtEmployeeIDSearch.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeIDSearch.TabIndex = 0;
            this.txtEmployeeIDSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeName.Location = new System.Drawing.Point(30, 66);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 20);
            this.lblEmployeeName.TabIndex = 17;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeID.Location = new System.Drawing.Point(30, 34);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeID.TabIndex = 18;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // pnlPermissionListBottom
            // 
            this.pnlPermissionListBottom.BackColor = System.Drawing.Color.LightGray;
            this.pnlPermissionListBottom.Controls.Add(this.btnDisaprove);
            this.pnlPermissionListBottom.Controls.Add(this.btnApprovePermissionList);
            this.pnlPermissionListBottom.Controls.Add(this.btnDeletePermissionList);
            this.pnlPermissionListBottom.Controls.Add(this.btnClosePermissionList);
            this.pnlPermissionListBottom.Controls.Add(this.btnUpdatePermissionList);
            this.pnlPermissionListBottom.Controls.Add(this.btnNewPermissionList);
            this.pnlPermissionListBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPermissionListBottom.Location = new System.Drawing.Point(0, 499);
            this.pnlPermissionListBottom.Name = "pnlPermissionListBottom";
            this.pnlPermissionListBottom.Size = new System.Drawing.Size(902, 117);
            this.pnlPermissionListBottom.TabIndex = 1;
            // 
            // btnDisaprove
            // 
            this.btnDisaprove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDisaprove.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisaprove.ForeColor = System.Drawing.Color.DimGray;
            this.btnDisaprove.Location = new System.Drawing.Point(152, 24);
            this.btnDisaprove.Name = "btnDisaprove";
            this.btnDisaprove.Size = new System.Drawing.Size(134, 70);
            this.btnDisaprove.TabIndex = 1;
            this.btnDisaprove.Text = "Disapprove";
            this.btnDisaprove.UseVisualStyleBackColor = false;
            // 
            // btnApprovePermissionList
            // 
            this.btnApprovePermissionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnApprovePermissionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprovePermissionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnApprovePermissionList.Location = new System.Drawing.Point(12, 24);
            this.btnApprovePermissionList.Name = "btnApprovePermissionList";
            this.btnApprovePermissionList.Size = new System.Drawing.Size(134, 70);
            this.btnApprovePermissionList.TabIndex = 0;
            this.btnApprovePermissionList.Text = "Approve";
            this.btnApprovePermissionList.UseVisualStyleBackColor = false;
            // 
            // btnDeletePermissionList
            // 
            this.btnDeletePermissionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeletePermissionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePermissionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeletePermissionList.Location = new System.Drawing.Point(594, 24);
            this.btnDeletePermissionList.Name = "btnDeletePermissionList";
            this.btnDeletePermissionList.Size = new System.Drawing.Size(134, 70);
            this.btnDeletePermissionList.TabIndex = 4;
            this.btnDeletePermissionList.Text = "DELETE";
            this.btnDeletePermissionList.UseVisualStyleBackColor = false;
            // 
            // btnClosePermissionList
            // 
            this.btnClosePermissionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClosePermissionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePermissionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnClosePermissionList.Location = new System.Drawing.Point(756, 24);
            this.btnClosePermissionList.Name = "btnClosePermissionList";
            this.btnClosePermissionList.Size = new System.Drawing.Size(134, 70);
            this.btnClosePermissionList.TabIndex = 5;
            this.btnClosePermissionList.Text = "Close";
            this.btnClosePermissionList.UseVisualStyleBackColor = false;
            this.btnClosePermissionList.Click += new System.EventHandler(this.btnClosePermissionList_Click);
            // 
            // btnUpdatePermissionList
            // 
            this.btnUpdatePermissionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdatePermissionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePermissionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdatePermissionList.Location = new System.Drawing.Point(454, 24);
            this.btnUpdatePermissionList.Name = "btnUpdatePermissionList";
            this.btnUpdatePermissionList.Size = new System.Drawing.Size(134, 70);
            this.btnUpdatePermissionList.TabIndex = 3;
            this.btnUpdatePermissionList.Text = "Update";
            this.btnUpdatePermissionList.UseVisualStyleBackColor = false;
            this.btnUpdatePermissionList.Click += new System.EventHandler(this.btnUpdatePermissionList_Click);
            // 
            // btnNewPermissionList
            // 
            this.btnNewPermissionList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewPermissionList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPermissionList.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewPermissionList.Location = new System.Drawing.Point(314, 24);
            this.btnNewPermissionList.Name = "btnNewPermissionList";
            this.btnNewPermissionList.Size = new System.Drawing.Size(134, 70);
            this.btnNewPermissionList.TabIndex = 2;
            this.btnNewPermissionList.Text = "New";
            this.btnNewPermissionList.UseVisualStyleBackColor = false;
            this.btnNewPermissionList.Click += new System.EventHandler(this.btnNewPermissionList_Click);
            // 
            // dgvPermissionList
            // 
            this.dgvPermissionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermissionList.Location = new System.Drawing.Point(0, 221);
            this.dgvPermissionList.Name = "dgvPermissionList";
            this.dgvPermissionList.Size = new System.Drawing.Size(902, 278);
            this.dgvPermissionList.TabIndex = 2;
            // 
            // FrmPermissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(902, 616);
            this.Controls.Add(this.dgvPermissionList);
            this.Controls.Add(this.pnlPermissionListBottom);
            this.Controls.Add(this.pnlPermissionListTop);
            this.Name = "FrmPermissionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission List";
            this.pnlPermissionListTop.ResumeLayout(false);
            this.pnlEmployeePermissionList.ResumeLayout(false);
            this.pnlEmployeePermissionList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAdminPermissionList.ResumeLayout(false);
            this.pnlAdminPermissionList.PerformLayout();
            this.pnlPermissionListBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPermissionListTop;
        private System.Windows.Forms.Panel pnlPermissionListBottom;
        private System.Windows.Forms.DataGridView dgvPermissionList;
        private System.Windows.Forms.Button btnDisaprove;
        private System.Windows.Forms.Button btnApprovePermissionList;
        private System.Windows.Forms.Button btnDeletePermissionList;
        private System.Windows.Forms.Button btnClosePermissionList;
        private System.Windows.Forms.Button btnUpdatePermissionList;
        private System.Windows.Forms.Button btnNewPermissionList;
        private System.Windows.Forms.Panel pnlEmployeePermissionList;
        private System.Windows.Forms.Panel pnlAdminPermissionList;
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
        private System.Windows.Forms.Button btnClearTask;
        private System.Windows.Forms.Button btnSearchTask;
        private System.Windows.Forms.Label lblDayAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDeliveryDate;
        private System.Windows.Forms.RadioButton rdbStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBirthday;
        private System.Windows.Forms.Label lblTaskFinish;
        private System.Windows.Forms.TextBox txtDayAmount;
        private System.Windows.Forms.Label lblPermissionDate;
        private System.Windows.Forms.Label blbTaskStart;
    }
}