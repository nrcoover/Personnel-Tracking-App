using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelTracking
{
    public partial class FrmSalaryList : Form
    {
        public FrmSalaryList()
        {
            InitializeComponent();
        }

        private void btnNewSalaryList_Click(object sender, EventArgs e)
        {
            FrmSalary frm = new FrmSalary();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdateSalaryList_Click(object sender, EventArgs e)
        {
            FrmSalary frm = new FrmSalary();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnCloseSalaryList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
