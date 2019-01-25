using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSoftware
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_enterBill_Click(object sender, EventArgs e)
        {
            billsForm billingForm = new billsForm();
            //this.Hide();
            billingForm.Show();
        }

        private void btn_cmpBalanceSheet_Click(object sender, EventArgs e)
        {

        }
    }
}
