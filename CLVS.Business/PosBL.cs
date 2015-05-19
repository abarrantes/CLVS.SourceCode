using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLVS.Model;
using CLVS.Dal.Company;

namespace CLVS.Business
{
    public class PosBL
    {
        private string DbName;
        public PosBL(string dbName)
        {
            this.DbName = dbName;
        }
        public IList<CustomerModel> GetAllCustomer()
        {
            ShareDal share = new ShareDal(DbName);
            return share.GetAllCustomer();
        }

        public IList<ItemModel> GetAllItem(string customerCode)
        {
            ShareDal share = new ShareDal(DbName);
            return share.GetAllItem(customerCode);
        }

        
        
    }
}
