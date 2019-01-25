using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSoftware
{
    public class StoredProcedures
    {
        //Bills related operations
        public static string InsertNewBill = "InsertNewBill";
        public static string RetrieveBill = "RetrieveBill";
        public static string EditBill = "EditBill";
        public static string DeleteBill = "DeleteBill";

        //Orders related operations
        public static string InsertNewOrder = "InsertNewOrder";
        public static string RetrieveOrder = "RetrieveOrder";
        public static string EditOrder = "EditOrder";
        public static string DeleteOrder = "DeleteOrder";

        //Products related operations
        public static string InsertNewProduct = "InsertNewProduct";

        //Ledger related operations
        public static string RetrieveCustomerBills = "RetrieveCustomerBills";

        //Balance sheet related operations
        public static string RetrieveProductTransctions = "RetrieveProductTransctions";
    }
}
