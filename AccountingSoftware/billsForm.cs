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
    public partial class billsForm : Form
    {
        public billsForm()
        {
            InitializeComponent();
            debug_initForm();
        }

        private Bill CaptureBillDetails()
        {
            Bill bill = new Bill();

            bill.invoiceNumber = int.Parse(txtbx_InvoiceNumber.Text);
            bill.date = dtp_DateTimePicker.Value;
            bill.customerName = txtbx_customerName.Text;
            bill.customerAddress = txtbx_customerPlace.Text;
            bill.brokerName = txtbx_brokerName.Text;
            bill.truckNumber = int.Parse(txtbx_truckNo.Text);
            bill.driverName = txtbx_driverName.Text;
            bill.licenseNumber = txtbx_licNo.Text;
            bill.driverNumber = int.Parse(txtbx_driverNo.Text);
            bill.transport = txtbx_transport.Text;
            bill.insurance = txtbx_insurance.Text;
            bill.policyNumber = txtbx_policyNo.Text;
            bill.insuranceValue = double.Parse(txtbx_insuranceAmount.Text);
            bill.totalQtl = double.Parse(txtbx_totalQtl.Text);
            bill.totalPkg = double.Parse(txtbx_totalPkg.Text);
            bill.totalWeight = double.Parse(txtbx_totalWeight.Text);
            bill.totalAmount = double.Parse(txtbx_totalAmount.Text);
            bill.RsWords = txtbx_RsWords.Text;
            bill.freightRate = double.Parse(txtbx_freightRate.Text);
            bill.freightAmount = double.Parse(txtbx_freightAmount.Text);

            return bill;
        }

        private List<Order> CaptureOrdersDetails()
        {
            List<Order> orders = new List<Order>();
            
            for(int i = 0; i < datagrid_orderDetails.Rows.Count; i++)
            {
                Order order = new Order();

                order.serialNumber = int.Parse(datagrid_orderDetails.Rows[i].Cells[0].Value.ToString());
                order.goodsDescription = datagrid_orderDetails.Rows[i].Cells[1].Value.ToString();
                order.Qtl = double.Parse(datagrid_orderDetails.Rows[i].Cells[2].Value.ToString());
                order.Pkg = double.Parse(datagrid_orderDetails.Rows[i].Cells[3].Value.ToString());
                order.weight = double.Parse(datagrid_orderDetails.Rows[i].Cells[4].Value.ToString());
                order.ratePerQtl = double.Parse(datagrid_orderDetails.Rows[i].Cells[5].Value.ToString());
                double R = double.Parse(datagrid_orderDetails.Rows[i].Cells[6].Value.ToString());
                double P = double.Parse(datagrid_orderDetails.Rows[i].Cells[7].Value.ToString());
                order.amount = R + P / 100.0;

                orders.Add(order);
            }

            return orders;
        }

        private void debug_initForm()
        {
            txtbx_InvoiceNumber.Text = "123";
            dtp_DateTimePicker.Value = DateTime.Today;
            txtbx_customerName.Text = "Sayed";
            txtbx_customerPlace.Text = "Nozha";
            txtbx_brokerName.Text = "Ali";
            txtbx_truckNo.Text = "123";
            txtbx_driverName.Text = "Ahmed";
            txtbx_licNo.Text = "123";
            txtbx_driverNo.Text = "123";
            txtbx_transport.Text = "Nozhten";
            txtbx_insurance.Text = "123";
            txtbx_policyNo.Text = "123";
            txtbx_insuranceAmount.Text = "123";
            txtbx_totalQtl.Text = "123";
            txtbx_totalPkg.Text = "123";
            txtbx_totalWeight.Text = "123";
            txtbx_totalAmount.Text = "123";
            txtbx_RsWords.Text = "123";
            txtbx_freightRate.Text = "123";
            txtbx_freightAmount.Text = "123";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //DBManager dbMan = new DBManager();
            Bill bill = CaptureBillDetails();
            //List<Order> orders = CaptureOrdersDetails();
            Controller con = new Controller();

            int res = con.InsertNewBill(bill);

            if (res == 1)
            {
                MessageBox.Show("A new bill has been added");
            }
            else
            {
                MessageBox.Show("Error while inserting");
            }
        }
    }
}
