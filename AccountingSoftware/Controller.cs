using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSoftware
{
    class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //Parameter mapping functions ------------------------------------------
        private Dictionary<string, object> MapBillParameters(Bill bill)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@invoice", bill.invoiceNumber);
            Parameters.Add("@date", bill.date);
            Parameters.Add("@customerName", bill.customerName);
            Parameters.Add("@customerAddress", bill.customerAddress);
            Parameters.Add("@brokerName", bill.brokerName);
            Parameters.Add("@truckNumber", bill.truckNumber);
            Parameters.Add("@driverName", bill.driverName);
            Parameters.Add("@licenseNumber", bill.licenseNumber);
            Parameters.Add("@driverNumber", bill.driverNumber);
            Parameters.Add("@transport", bill.transport);
            Parameters.Add("@insurance", bill.insurance);
            Parameters.Add("@policyNumber", bill.policyNumber);
            Parameters.Add("@insuranceValue", bill.insuranceValue);
            Parameters.Add("@totalQtl", bill.totalQtl);
            Parameters.Add("@totalPkg", bill.totalPkg);
            Parameters.Add("@totalWeight", bill.totalWeight);
            Parameters.Add("@totalAmount", bill.totalAmount);
            Parameters.Add("@RsWords", bill.RsWords);
            Parameters.Add("@freightRate", bill.freightRate);
            Parameters.Add("@freightAmount", bill.freightAmount);

            return Parameters;
        }

        private Dictionary <string, object> MapOrderDetailsParameters(Order order)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@bill_id", order.billId);
            Parameters.Add("@product_id", order.productId);
            Parameters.Add("@serialNumber", order.serialNumber);
            Parameters.Add("@goodsDescription", order.goodsDescription);
            Parameters.Add("@Qtl", order.Qtl);
            Parameters.Add("@weight", order.weight);
            Parameters.Add("@Pkg", order.Pkg);
            Parameters.Add("@ratePerQtl", order.ratePerQtl);
            Parameters.Add("@amount", order.amount);

            return Parameters;
        }

        private Dictionary<string, object> MapProductParameters(Product product)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@id", product.id);
            Parameters.Add("@name", product.name);

            return Parameters;
        }
        //-------------------------------------------------------------------------

        //Billing related functions -----------------------------------------------
        public int InsertNewBill(Bill bill)
        {
            string StoredProcedureName = StoredProcedures.InsertNewBill;

            Dictionary<string, object> Parameters = MapBillParameters(bill);
            
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //--------------------------------------------------------------------------

        //Orders related functions--------------------------------------------------
        public int InsertOrders(List<Order> orders)
        {
            string StoredProcedureName = StoredProcedures.InsertNewOrder;

            for (int i = 0; i < orders.Count; i++)
            {
                Dictionary<string, object> Parameters = MapOrderDetailsParameters(orders[i]);
                int res = dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

                if (res == 0)
                    return i + 1;
            }

            return -1; //No problem
        }
        //--------------------------------------------------------------------------

        //Product related functions ------------------------------------------------
        public int InsertNewProduct(Product product)
        {
            string StoredProcedureName = StoredProcedures.InsertNewProduct;

            Dictionary<string, object> Parameters = MapProductParameters(product);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public List<string> RetrieveAllProducts()
        {
            string StoredProcedureName = StoredProcedures.RetrieveAllProducts;
            List<string> list = new List<string>();

            DataTable dt = dbMan.ExecuteReader(StoredProcedureName, null);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                var str = dt.Rows[i].ItemArray.Select(x => x.ToString()).ToArray();
                list.Add(str[0]);
            }

            return list;
        }

        public int RetrieveProductByName(string name)
        {
            string StoredProcedureName = StoredProcedures.RetrieveProductByName;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);

            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        //--------------------------------------------------------------------------
    }
}
