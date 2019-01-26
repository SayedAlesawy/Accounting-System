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
            InitalizeProductsList();
            datagrid_orderDetails.Rows[0].Cells[0].Value = "1";
        }

        private void InitalizeProductsList()
        {
            Controller con = new Controller();
            DataGridViewComboBoxColumn cmbo = new DataGridViewComboBoxColumn();
            cmbo.Width = 380;
            cmbo.HeaderText = "Goods Description";
            cmbo.DataSource = con.RetrieveAllProducts();
            datagrid_orderDetails.Columns.Insert(1, cmbo);
        }

        private int GetProductId(string name)
        {
            Controller con = new Controller();
            return con.RetrieveProductByName(name);
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
            
            for(int i = 0; i < datagrid_orderDetails.Rows.Count - 1; i++)
            {
                Order order = new Order();

                order.serialNumber = int.Parse(datagrid_orderDetails.Rows[i].Cells[0].Value.ToString());
                order.goodsDescription = datagrid_orderDetails.Rows[i].Cells[1].Value.ToString();
                order.Qtl = double.Parse(datagrid_orderDetails.Rows[i].Cells[2].Value.ToString());
                order.Pkg = double.Parse(datagrid_orderDetails.Rows[i].Cells[3].Value.ToString());
                order.weight = double.Parse(datagrid_orderDetails.Rows[i].Cells[4].Value.ToString());
                order.ratePerQtl = double.Parse(datagrid_orderDetails.Rows[i].Cells[5].Value.ToString());
                order.amount = double.Parse(datagrid_orderDetails.Rows[i].Cells[6].Value.ToString());
                order.billId = int.Parse(txtbx_InvoiceNumber.Text);
                order.productId = GetProductId(order.goodsDescription);

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

        private int InsertBillFrom()
        {
            Bill bill = CaptureBillDetails();
            Controller con = new Controller();

            int res = con.InsertNewBill(bill);

            if (res == 0)
            {
                MessageBox.Show("There is an error the bill data!");
            }

            return res;
        }

        private int InsertOrders()
        {
            List<Order> orders = CaptureOrdersDetails();
            Controller con = new Controller();

            int res = con.InsertOrders(orders);

            if (res != -1)
            {
                MessageBox.Show("There is an error in inserting item number: " + res.ToString());
            }

            return res;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int BillInsertionRes = InsertBillFrom();
            int ordersInsertionRes = InsertOrders();

            if(BillInsertionRes == 1 && ordersInsertionRes == -1)
            {
                MessageBox.Show("New bill has been added successfully!");
            }
        }

        private void datagrid_orderDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for(int i = 0; i < datagrid_orderDetails.Rows.Count; i++)
            {
                datagrid_orderDetails.Rows[i].Cells[0].Value = (i + 1).ToString(); 
            }
        }

        private void datagrid_orderDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < datagrid_orderDetails.Rows.Count; i++)
            {
                datagrid_orderDetails.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
    }
}
