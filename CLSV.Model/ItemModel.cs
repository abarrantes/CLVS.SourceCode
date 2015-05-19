using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLVS.Model
{
    public class ItemModel
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
        public string TaxCode { get; set; }
        public string Whs { get; set; }
        public decimal? StockT { get; set; }
        public decimal? StockO { get; set; }
        public decimal? StockW { get; set; }
        public decimal? Rate { get; set; }
      

    }
}
