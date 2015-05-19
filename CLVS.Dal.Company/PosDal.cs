using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLVS.Dal.Company
{
    public class PosDal
    {
        string conStr = ConfigurationManager.ConnectionStrings["CompanyDBEntities"].ConnectionString;
        public PosDal(string dbName)
        {
            this.conStr = this.conStr.Replace("#DBName#", dbName);
        }

    }
}
