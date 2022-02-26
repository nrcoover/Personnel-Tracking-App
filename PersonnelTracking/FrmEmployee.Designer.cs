
namespace PersonnelTracking
{
    partial class FrmEmployee
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
            this.pnlEmployeeTop = new System.Windows.Forms.Panel();
            this.cmbPositionSelect = new System.Windows.Forms.ComboBox();
            this.lblPositionSelect = new System.Windows.Forms.Label();
            this.cmbDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lblDepartmentSelect = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.txtEmployeeImagePath = new System.Windows.Forms.TextBox();
            this.pbxEmployeeImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSalary = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpEmployeeBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdayPicker = new System.Windows.Forms.Label();
            this.lblEmployeeAddress = new System.Windows.Forms.Label();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pnlEmployeeTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployeeTop
            // 
            this.pnlEmployeeTop.BackColor = System.Drawing.Color.LightGray;
            this.pnlEmployeeTop.Controls.Add(this.btnCheck);
            this.pnlEmployeeTop.Controls.Add(this.cbxAdmin);
            this.pnlEmployeeTop.Controls.Add(this.txtEmployeePassword);
            this.pnlEmployeeTop.Controls.Add(this.lblPassword);
            this.pnlEmployeeTop.Controls.Add(this.txtEmployeeID);
            this.pnlEmployeeTop.Controls.Add(this.lblEmployeeID);
            this.pnlEmployeeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeeTop.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeTop.Name = "pnlEmployeeTop";
            this.pnlEmployeeTop.Size = new System.Drawing.Size(869, 74);
            this.pnlEmployeeTop.TabIndex = 0;
            // 
            // cmbPositionSelect
            // 
            this.cmbPositionSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositionSelect.FormattingEnabled = true;
            this.cmbPositionSelect.Location = new System.Drawing.Point(137, 273);
            this.cmbPositionSelect.Name = "cmbPositionSelect";
            this.cmbPositionSelect.Size = new System.Drawing.Size(198, 28);
            this.cmbPositionSelect.TabIndex = 7;
            // 
            // lblPositionSelect
            // 
            this.lblPositionSelect.AutoSize = true;
            this.lblPositionSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblPositionSelect.Location = new System.Drawing.Point(30, 276);
            this.lblPositionSelect.Name = "lblPositionSelect";
            this.lblPositionSelect.Size = new System.Drawing.Size(67, 20);
            this.lblPositionSelect.TabIndex = 0;
            this.lblPositionSelect.Text = "Position";
            // 
            // cmbDepartmentSelect
            // 
            this.cmbDepartmentSelect.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentSelect.FormattingEnabled = true;
            this.cmbDepartmentSelect.Location = new System.Drawing.Point(137, 239);
            this.cmbDepartmentSelect.Name = "cmbDepartmentSelect";
            this.cmbDepartmentSelect.Size = new System.Drawing.Size(198, 28);
            this.cmbDepartmentSelect.TabIndex = 6;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBrowseImage.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.ForeColor = System.Drawing.Color.DimGray;
            this.btnBrowseImage.Location = new System.Drawing.Point(341, 175);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(102, 26);
            this.btnBrowseImage.TabIndex = 4;
            this.btnBrowseImage.Text = "Upload File";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            // 
            // lblDepartmentSelect
            // 
            this.lblDepartmentSelect.AutoSize = true;
            this.lblDepartmentSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentSelect.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSelect.ForeColor = System.Drawing.Color.Gray;
            this.lblDepartmentSelect.Location = new System.Drawing.Point(30, 242);
            this.lblDepartmentSelect.Name = "lblDepartmentSelect";
            this.lblDepartmentSelect.Size = new System.Drawing.Size(98, 20);
            this.lblDepartmentSelect.TabIndex = 0;
            this.lblDepartmentSelect.Text = "Department";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.White;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(137, 25);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeID.Location = new System.Drawing.Point(30, 28);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.BackColor = System.Drawing.Color.White;
            this.txtEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassword.Location = new System.Drawing.Point(523, 28);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(177, 26);
            this.txtEmployeePassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(438, 30);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdmin.ForeColor = System.Drawing.Color.Gray;
            this.cbxAdmin.Location = new System.Drawing.Point(706, 30);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(137, 24);
            this.cbxAdmin.TabIndex = 9;
            this.cbxAdmin.Text = "Check if Admin";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeName.Location = new System.Drawing.Point(30, 114);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(101, 20);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee ID";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(137, 111);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeSurname.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(30, 146);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(74, 20);
            this.lblEmployeeSurname.TabIndex = 0;
            this.lblEmployeeSurname.Text = "Surname";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.BackColor = System.Drawing.Color.White;
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(137, 143);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeSurname.TabIndex = 2;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.BackColor = System.Drawing.Color.Transparent;
            this.lblImagePath.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagePath.ForeColor = System.Drawing.Color.Gray;
            this.lblImagePath.Location = new System.Drawing.Point(30, 178);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(89, 20);
            this.lblImagePath.TabIndex = 0;
            this.lblImagePath.Text = "Image Path";
            // 
            // txtEmployeeImagePath
            // 
            this.txtEmployeeImagePath.BackColor = System.Drawing.Color.White;
            this.txtEmployeeImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeImagePath.Location = new System.Drawing.Point(137, 175);
            this.txtEmployeeImagePath.Name = "txtEmployeeImagePath";
            this.txtEmployeeImagePath.Size = new System.Drawing.Size(198, 26);
            this.txtEmployeeImagePath.TabIndex = 3;
            // 
            // pbxEmployeeImage
            // 
            this.pbxEmployeeImage.Location = new System.Drawing.Point(487, 112);
            this.pbxEmployeeImage.Name = "pbxEmployeeImage";
            this.pbxEmployeeImage.Size = new System.Drawing.Size(356, 372);
            this.pbxEmployeeImage.TabIndex = 7;
            this.pbxEmployeeImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Gray;
            this.lblSalary.Location = new System.Drawing.Point(30, 210);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(54, 20);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Salary";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(137, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dtpEmployeeBirthday
            // 
            this.dtpEmployeeBirthday.Location = new System.Drawing.Point(137, 307);
            this.dtpEmployeeBirthday.Name = "dtpEmployeeBirthday";
            this.dtpEmployeeBirthday.Size = new System.Drawing.Size(198, 20);
            this.dtpEmployeeBirthday.TabIndex = 8;
            // 
            // lblBirthdayPicker
            // 
            this.lblBirthdayPicker.AutoSize = true;
            this.lblBirthdayPicker.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthdayPicker.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdayPicker.ForeColor = System.Drawing.Color.Gray;
            this.lblBirthdayPicker.Location = new System.Drawing.Point(30, 308);
            this.lblBirthdayPicker.Name = "lblBirthdayPicker";
            this.lblBirthdayPicker.Size = new System.Drawing.Size(72, 20);
            this.lblBirthdayPicker.TabIndex = 0;
            this.lblBirthdayPicker.Text = "Birthday";
            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = true;
            this.lblEmployeeAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeAddress.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployeeAddress.Location = new System.Drawing.Point(30, 336);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(68, 20);
            this.lblEmployeeAddress.TabIndex = 0;
            this.lblEmployeeAddress.Text = "Address";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.BackColor = System.Drawing.Color.White;
            this.txtEmployeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeAddress.Location = new System.Drawing.Point(137, 333);
            this.txtEmployeeAddress.Multiline = true;
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(306, 96);
            this.txtEmployeeAddress.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Location = new System.Drawing.Point(137, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 49);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.Location = new System.Drawing.Point(293, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 49);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCheck.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.DimGray;
            this.btnCheck.Location = new System.Drawing.Point(341, 25);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(74, 26);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(869, 514);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpEmployeeBirthday);
            this.Controls.Add(this.pbxEmployeeImage);
            this.Controls.Add(this.pnlEmployeeTop);
            this.Controls.Add(this.txtEmployeeImagePath);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.txtEmployeeSurname);
            this.Controls.Add(this.lblEmployeeSurname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.lblEmployeeAddress);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.cmbPositionSelect);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.lblBirthdayPicker);
            this.Controls.Add(this.lblPositionSelect);
            this.Controls.Add(this.lblDepartmentSelect);
            this.Controls.Add(this.cmbDepartmentSelect);
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.pnlEmployeeTop.ResumeLayout(false);
            this.pnlEmployeeTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeTop;
        private System.Windows.Forms.ComboBox cmbPositionSelect;
        private System.Windows.Forms.Label lblPositionSelect;
        private System.Windows.Forms.ComboBox cmbDepartmentSelect;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label lblDepartmentSelect;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbxAdmin;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtEmployeeImagePath;
        private System.Windows.Forms.PictureBox pbxEmployeeImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBirthday;
        private System.Windows.Forms.Label lblBirthdayPicker;
        private System.Windows.Forms.Label lblEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheck;
    }
}