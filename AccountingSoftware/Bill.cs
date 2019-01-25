using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSoftware
{
    public class Bill
    {
        public int invoiceNumber { get; set; }
        public DateTime date { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string brokerName { get; set; }
        public int truckNumber { get; set; }
        public string driverName { get; set; }
        public string licenseNumber { get; set; }
        public int driverNumber { get; set; }
        public string transport { get; set; }
        public string insurance { get; set; }
        public string policyNumber { get; set; }
        public double insuranceValue { get; set; }
        public double totalQtl { get; set; }
        public double totalPkg { get; set; }
        public double totalWeight { get; set; }
        public double totalAmount { get; set; }
        public string RsWords { get; set; }
        public double freightRate { get; set; }
        public double freightAmount { get; set; }
    }
}
