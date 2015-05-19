using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLVS.Model;
using CLVS.DIApi;

namespace CLVS.TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalesCreation salesCreation = new SalesCreation();
            salesCreation.CreateSales();
        }
    }
}
