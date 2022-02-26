
namespace PersonnelTracking
{
    partial class FrmTask
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
            this.pnlTaskMasterRight = new System.Windows.Forms.Panel();
            this.pnlTaskChildTop = new System.Windows.Forms.Panel();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
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
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.lblTaskState = new System.Windows.Forms.Label();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTaskContent = new System.Windows.Forms.Label();
            this.txtTaskContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTaskMasterRight.SuspendLayout();
            this.pnlTaskChildTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTaskMasterRight
            // 
            this.pnlTaskMasterRight.BackColor = System.Drawing.Color.LightGray;
            this.pnlTaskMasterRight.Controls.Add(this.dgvTasks);
            this.pnlTaskMasterRight.Controls.Add(this.pnlTaskChildTop);
            this.pnlTaskMasterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTaskMasterRight.Location = new System.Drawing.Point(541, 0);
            this.pnlTaskMasterRight.Name = "pnlTaskMasterRight";
            this.pnlTaskMasterRight.Size = new System.Drawing.Size(297, 507);
            this.pnlTaskMasterRight.TabIndex = 0;
            // 
            // pnlTaskChildTop
            // 
            this.pnlTaskChildTop.Controls.Add(this.cmbPositionSelect);
            this.pnlTaskChildTop.Controls.Add(this.cmbDepartmentSelect);
            this.pnlTaskChildTop.Controls.Add(this.lblPositionSelect);
            this.pnlTaskChildTop.Controls.Add(this.lblDepartmentSelect);
            this.pnlTaskChildTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskChildTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskChildTop.Name = "pnlTaskChildTop";
            this.pnlTaskChildTop.Size = new System.Drawing.Size(297, 161);
            this.pnlTaskChildTop.TabIndex = 0;
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.Location = new System.Drawing.Point(0, 161);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(297, 346);
            this.dgvTasks.TabIndex = 1;
            // 
            // cmbPositionSelect
            // 
            this.cmbPositionSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSelect.FormattingEnabled = true;
            this.cmbPositionSelect.Location = new System.Drawing.Point(20, 105);
            this.cmbPositionSelect.Name = "cmbPositionSelect";
            this.cmbPositionSelect.Size = new System.Drawing.Size(174, 28);
            this.cmbPositionSelect.TabIndex = 1;
            // 
            // lblPositionSelect
            // 
            this.lblPositionSelect.AutoSize = true;
            this.lblPositionSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblPositionSelect.Location = new System.Drawing.Point(16, 82);
            this.lblPositionSelect.Name = "lblPositionSelect";
            this.lblPositionSelect.Size = new System.Drawing.Size(67, 20);
            this.lblPositionSelect.TabIndex = 13;
            this.lblPositionSelect.Text = "Position";
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(20, 41);
            this.cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            this.cmbDepartmentSelect.Size = new System.Drawing.Size(174, 28);
            this.cmbDepartmentSelect.TabIndex = 0;
            // 
            // lblDepartmentSelect
            // 
            this.lblDepartmentSelect.AutoSize = true;
            this.lblDepartmentSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblDepartmentSelect.Location = new System.Drawing.Point(16, 18);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 14;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(183, 105);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.ReadOnly = true;
            this.txtEmployeeSurname.Size = new System.Drawing.Size(180, 26);
            this.txtEmployeeSurname.TabIndex = 9;
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeSurname.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(28, 108);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(149, 20);
            this.lblEmployeeSurname.TabIndex = 10;
            this.lblEmployeeSurname.Text = "Employee Surname";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(183, 73);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(180, 26);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // txtEmployeeIDSearch
            // 
            this.txtEmployeeIDSearch.BackColor = System.Drawing.Color.White;
            this.txtEmployeeIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDSearch.Location = new System.Drawing.Point(183, 41);
            this.txtEmployeeIDSearch.Name = "txtEmployeeIDSearch";
            this.txtEmployeeIDSearch.ReadOnly = true;
            this.txtEmployeeIDSearch.Size = new System.Drawing.Size(180, 26);
            this.txtEmployeeIDSearch.TabIndex = 7;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeName.Location = new System.Drawing.Point(28, 76);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 20);
            this.lblEmployeeName.TabIndex = 11;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeIDSearch
            // 
            this.lblEmployeeIDSearch.AutoSize = true;
            this.lblEmployeeIDSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeIDSearch.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeIDSearch.Location = new System.Drawing.Point(28, 44);
            this.lblEmployeeIDSearch.Name = "lblEmployeeIDSearch";
            this.lblEmployeeIDSearch.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeIDSearch.TabIndex = 12;
            this.lblEmployeeIDSearch.Text = "Employee ID";
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(183, 181);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(180, 28);
            this.cmbTaskState.TabIndex = 0;
            // 
            // lblTaskState
            // 
            this.lblTaskState.AutoSize = true;
            this.lblTaskState.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskState.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskState.ForeColor = System.Drawing.Color.Gray;
            this.lblTaskState.Location = new System.Drawing.Point(71, 184);
            this.lblTaskState.Name = "lblTaskState";
            this.lblTaskState.Size = new System.Drawing.Size(84, 20);
            this.lblTaskState.TabIndex = 14;
            this.lblTaskState.Text = "Task State";
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskTitle.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTaskTitle.Location = new System.Drawing.Point(71, 218);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(79, 20);
            this.lblTaskTitle.TabIndex = 10;
            this.lblTaskTitle.Text = "Task Title";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblTaskContent
            // 
            this.lblTaskContent.AutoSize = true;
            this.lblTaskContent.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskContent.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskContent.ForeColor = System.Drawing.Color.Gray;
            this.lblTaskContent.Location = new System.Drawing.Point(71, 250);
            this.lblTaskContent.Name = "lblTaskContent";
            this.lblTaskContent.Size = new System.Drawing.Size(105, 20);
            this.lblTaskContent.TabIndex = 10;
            this.lblTaskContent.Text = "Task Content";
            // 
            // txtTaskContent
            // 
            this.txtTaskContent.BackColor = System.Drawing.Color.White;
            this.txtTaskContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskContent.Location = new System.Drawing.Point(183, 247);
            this.txtTaskContent.Multiline = true;
            this.txtTaskContent.Name = "txtTaskContent";
            this.txtTaskContent.Size = new System.Drawing.Size(307, 165);
            this.txtTaskContent.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Location = new System.Drawing.Point(184, 418);
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
            this.btnClose.Location = new System.Drawing.Point(340, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(838, 507);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbTaskState);
            this.Controls.Add(this.lblTaskState);
            this.Controls.Add(this.txtTaskContent);
            this.Controls.Add(this.lblTaskContent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.txtEmployeeSurname);
            this.Controls.Add(this.lblEmployeeSurname);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeIDSearch);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeIDSearch);
            this.Controls.Add(this.pnlTaskMasterRight);
            this.Name = "FrmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.pnlTaskMasterRight.ResumeLayout(false);
            this.pnlTaskChildTop.ResumeLayout(false);
            this.pnlTaskChildTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTaskMasterRight;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Panel pnlTaskChildTop;
        private System.Windows.Forms.ComboBox cmbPositionSelect;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Label lblPositionSelect;
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeIDSearch;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeIDSearch;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Label lblTaskState;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTaskContent;
        private System.Windows.Forms.TextBox txtTaskContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}