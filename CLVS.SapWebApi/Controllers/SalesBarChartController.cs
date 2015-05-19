using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CLVS.Business;
using CLVS.Model;
using System.Web.Http;

namespace CLVS.SapWebApi.Controllers
{
    public class SalesBarChartController : ApiController
    {
        // GET: SalesBarChart
        public IEnumerable<ChartAxisModel> Get()
        {
            string dbName = "SBODemoUS";
            ChartBL chartBL = new ChartBL(dbName);
            return chartBL.GetSalesBarChart();
        }
    }
}