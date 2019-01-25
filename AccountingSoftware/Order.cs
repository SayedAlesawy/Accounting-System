using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSoftware
{
    public class Order
    {
        public int billId { get; set; }
        public int productId { get; set; }
        public int serialNumber { get; set; }
        public string goodsDescription { get; set; }
        public double Qtl { get; set; }
        public double Pkg { get; set; }
        public double weight { get; set; }
        public double ratePerQtl { get; set; }
        public double amount { get; set; }
    }
}
