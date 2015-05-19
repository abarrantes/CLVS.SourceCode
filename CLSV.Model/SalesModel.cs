using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLVS.Model
{
    public class SalesModel
    {
      
        public string Remark { get; set; }

        public string CustomerCode { get; set; }

        public DateTime DocDueDate { get; set; }

        public IList<SalesLineModel> SalesLine { get; set; }

    }

    public class SalesLineModel
    {
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
