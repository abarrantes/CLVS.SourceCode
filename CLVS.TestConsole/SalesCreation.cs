using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLVS.Model;
using CLVS.DIApi;

namespace CLVS.TestConsole
{
    public class SalesCreation
    {
        public void CreateSales()
        { 
            SalesModel saleModel = new SalesModel();
            saleModel.CustomerCode = "C20000";
            saleModel.DocDueDate = DateTime.Now.AddDays(1);

            IList<SalesLineModel> list = new List<SalesLineModel>();
            SalesLineModel line1 = new SalesLineModel();
            line1.ItemCode = "I00001";
            line1.ItemDescription = "Blu-Ray Disc 10-Pack";
            line1.Quantity = 2;
            list.Add(line1);

            SalesLineModel line2 = new SalesLineModel();
            line2.ItemCode = "I00002";
            line2.ItemDescription = "Blu-Ray DL Disc 10-Pack";
            line2.Quantity = 5;
            list.Add(line2);
            saleModel.SalesLine = list;

            Sales sale = new Sales();
            sale.CreateOrder(saleModel);

        }
    }
}
