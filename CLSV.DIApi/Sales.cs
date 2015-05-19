using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbobsCOM;
using CLVS.Model;
//using SAPbouiCOM;
//using SBODI_Server;
namespace CLVS.DIApi
{
    public class Sales
    {
       public string  CreateOrder(SalesModel salesModel)
       {
           Company oCompany = new Company();
           oCompany.Server = "SV12SQL12BA4";
           oCompany.UserName = "manager";
           oCompany.Password = "manager";
           oCompany.DbUserName = "sa";
           oCompany.DbPassword = "B1Admin";
           oCompany.CompanyDB = "SBODemoUS";
           oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;
           oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012;
           //oCompany.UseTrusted = true;
           oCompany.LicenseServer = "SV12SQL12BA4";
           int lErrCode;
           string temp_string;
           var result = oCompany.Connect();
           oCompany.GetLastError(out lErrCode, out temp_string);

           SAPbobsCOM.Documents oOrder;
           oOrder = (SAPbobsCOM.Documents)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders);
           oOrder.CardCode = salesModel.CustomerCode;
           oOrder.DocType = BoDocumentTypes.dDocument_Items;
           oOrder.DocDueDate = salesModel.DocDueDate;

           foreach (var line in salesModel.SalesLine)
           {
               oOrder.Lines.ItemCode = line.ItemCode;
               oOrder.Lines.Quantity = line.Quantity;
               oOrder.Lines.UnitPrice = line.UnitPrice;
               oOrder.Lines.Add();
           }
           string returnMsg = string.Empty;
           if (oOrder.Add() != 0)
               returnMsg= "Error: " + oCompany.GetLastErrorDescription();
           else
               returnMsg = "The order number " + oCompany.GetNewObjectKey() + " was created succesfully";

           if (oCompany.Connected == true)
           {
               oCompany.Disconnect();
           }
           return returnMsg;

       }
             
    }
}
