using System;
using System.Collections.Generic;
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

        public int InsertNewBill(Bill bill)
        {
            string StoredProcedureName = StoredProcedures.InsertNewBill;

            Dictionary<string, object> Parameters = MapBillParameters(bill);
            
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}
