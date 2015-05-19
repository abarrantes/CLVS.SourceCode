using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CLVS.Model;
using CLVS.Business;
using CLVS.DIApi;

namespace CLVS.SapWebApi.Controllers
{
    public class SalesOrderController : ApiController
    {
        //[ResponseType(typeof(SalesModel))]
        public string  PostSalesOrder(SalesModel salesModel)
        {
            if (!ModelState.IsValid)
            {
                return "Bad request";
            }

            try
            {
                Sales sale = new Sales();
                return sale.CreateOrder(salesModel);
            }
            catch (Exception ex)
            {
                return "Exception occured in accessing the DI API";
            }

        }
    }
}
