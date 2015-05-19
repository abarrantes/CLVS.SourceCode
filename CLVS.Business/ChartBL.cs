using CLVS.Model;
using CLVS.Dal.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLVS.Utility;

namespace CLVS.Business
{
    public class ChartBL
    {
        private string DbName;
        public ChartBL(string dbName)
        {
            this.DbName = dbName;
        }
        public IList<ChartAxisModel> GetSalesBarChart()
        {
            ChartDal chartDal = new ChartDal(DbName);
            ChartLinesModel line = new ChartLinesModel { ChartAxisList = chartDal.GetSalesBarChart() };
            ChartUtil.SetMonthFormat(line);
            return line.ChartAxisList;
        }
        public IList<ChartLinesModel> GetSalesInvoiceChart()
        {
            ChartDal chartDal = new ChartDal(DbName);
            IList<ChartLinesModel> lineItems=chartDal.GetSalesInvoiceChart();
            foreach (var line in lineItems)
            {
                ChartUtil.SetMonthFormat(line);
            }
            return lineItems;
        }
    }
}
