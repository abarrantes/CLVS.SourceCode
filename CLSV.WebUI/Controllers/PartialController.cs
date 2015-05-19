using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLVS.WebUI.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult _Pos()
        {
            return PartialView("~/Views/Partial/_Pos.cshtml");
        }

        public ActionResult _SalesBarChart()
        {
            return PartialView("~/Views/Chart/_SalesBarChart.cshtml");
        }

        public ActionResult _SalesInvoiceChart()
        {
            return PartialView("~/Views/Chart/_SalesInvoiceChart.cshtml");
        }

        public ActionResult _ChartLayout()
        {
            return PartialView("~/Views/Chart/_ChartLayout.cshtml");
        }

        public ActionResult _SalesOrder()
        {
            return PartialView("~/Views/Partial/_SalesOrder.cshtml");
        }
    }
}