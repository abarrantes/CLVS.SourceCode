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
    public class ItemController : ApiController
    {
        // GET: Item
        public IEnumerable<ItemModel> Get(string CustomerCode)
        {
            string dbName = "SBODemoUS";
            PosBL posBL = new PosBL(dbName);
            return posBL.GetAllItem(CustomerCode);
        }
    }
}