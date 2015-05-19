using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLVS.Model;
using System.Data.SqlClient;
using System.Data;

namespace CLVS.Dal.Company
{
    public class ShareDal
    {       
        string conStr = @"metadata=res://*/CompanyDB.csdl|res://*/CompanyDB.ssdl|res://*/CompanyDB.msl;provider=System.Data.SqlClient;provider connection string=';data source=vs13sql12ba4.cloudapp.net;initial catalog=#DBName#;persist security info=True;user id=sa;password=B1Admin;MultipleActiveResultSets=True;App=EntityFramework';";
        string adoConStr = @"data source=vs13sql12ba4.cloudapp.net;initial catalog=#DBName#;persist security info=True;user id=sa;password=B1Admin;MultipleActiveResultSets=True;App=EntityFramework";
        public ShareDal(string dbName)
        {
            this.conStr = this.conStr.Replace("#DBName#", dbName);
            this.adoConStr = this.adoConStr.Replace("#DBName#", dbName);
        }

        public IList<CustomerModel> GetAllCustomer()
        {
            using (CompanyDBEntities entity = new CompanyDBEntities(conStr))
            {
               return   entity.OCRDs
                        .Where(flt => flt.CardType == "C")
                        .Select(s => new CustomerModel 
                            { 
                                 CustomerCode=s.CardCode,
                                 CustomerName=s.CardName
                            }).ToList();
            }
        }

        public IList<ItemModel> GetAllItem(string customerCode)
        {
            using (CompanyDBEntities entity = new CompanyDBEntities(conStr))
            {
                string defaultWhr = entity.OADMs.Select(s => s.DfltWhs).First();       
                var itemList= (from item in entity.OITMs
                              join price in entity.ITM1 on
                              item.ItemCode equals price.ItemCode
                              join listNum in entity.OCRDs on
                              price.PriceList equals listNum.ListNum
                              join tax in entity.CRD1 on
                              listNum.ShipToDef equals tax.Address
                              join rate in entity.OSTCs on
                              tax.TaxCode equals rate.Code
                              where listNum.CardCode == customerCode
                              select new ItemModel
                              {
                                  ItemCode = item.ItemCode,
                                  ItemName = item.ItemName,
                                  Price = price.Price,
                                  Whs = item.DfltWH ?? defaultWhr,
                                  StockT = item.OnHand,
                                  StockO = item.OnOrder,
                                  TaxCode=tax.TaxCode,
                                  Rate=rate.Rate

                              }).ToList();

                var stockWList = entity.OITWs.Select(s => new { s.ItemCode,s.WhsCode,s.OnHand }).ToList();
                foreach (var item in itemList)
                {
                    foreach (var stock in stockWList)
                    {
                        if (item.ItemCode == stock.ItemCode && item.Whs == stock.WhsCode)
                        {
                            item.StockW = stock.OnHand;
                            break;
                        }
                    }
                }
                return itemList;               
            }
        }
        
    }

}
