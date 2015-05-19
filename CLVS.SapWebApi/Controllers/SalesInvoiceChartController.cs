using CLVS.Business;
using CLVS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CLVS.SapWebApi.Controllers
{
    public class SalesInvoiceChartController : ApiController
    {
        public IEnumerable<ChartLinesModel> Get()
        {
            string dbName = "SBODemoUS";
            ChartBL chartBL = new ChartBL(dbName);
            return chartBL.GetSalesInvoiceChart();
        }
    }
}
