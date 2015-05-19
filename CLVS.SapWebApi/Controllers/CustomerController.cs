using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CLVS.Business;
using CLVS.Model;

namespace CLVS.SapWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<CustomerModel> Get()
        {
            string dbName = "SBODemoUS";
            PosBL posBL = new PosBL(dbName);
            return posBL.GetAllCustomer();
        }
    }
}
