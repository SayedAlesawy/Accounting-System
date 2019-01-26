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
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        private Product CaptureProductDetails()
        {
            Product product = new Product();

            product.id = int.Parse(txtbx_productID.Text);
            product.name = txtbx_name.Text;

            return product;
        }

        private void ClearForm()
        {
            txtbx_name.Text = "";
            txtbx_productID.Text = "";
        }

        private bool ValidateForm()
        {
            if (txtbx_productID.Text.Length == 0)
            {
                MessageBox.Show("Enter product Id");
                return false;
            }
            if(txtbx_name.Text.Length == 0)
            {
                MessageBox.Show("Enter product Name");
                return false;
            }

            return true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            
            Product product = CaptureProductDetails();
            Controller con = new Controller();

            int res = con.InsertNewProduct(product);

            if (res == 1)
            {
                MessageBox.Show("A new product has been added");
            }
            else
            {
                MessageBox.Show("[Database Level Error] Error while inserting");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
