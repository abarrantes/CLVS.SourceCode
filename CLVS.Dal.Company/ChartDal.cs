using CLVS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLVS.Dal.Company
{
    public class ChartDal
    {
        string conStr = @"metadata=res://*/CompanyDB.csdl|res://*/CompanyDB.ssdl|res://*/CompanyDB.msl;provider=System.Data.SqlClient;provider connection string=';data source=vs13sql12ba4.cloudapp.net;initial catalog=#DBName#;persist security info=True;user id=sa;password=B1Admin;MultipleActiveResultSets=True;App=EntityFramework';";
        string adoConStr = @"data source=vs13sql12ba4.cloudapp.net;initial catalog=#DBName#;persist security info=True;user id=sa;password=B1Admin;MultipleActiveResultSets=True;App=EntityFramework";
        public ChartDal(string dbName)
        {
            this.conStr = this.conStr.Replace("#DBName#", dbName);
            this.adoConStr = this.adoConStr.Replace("#DBName#", dbName);
        }
        public IList<ChartAxisModel> GetSalesBarChart()
        {
            string SqlString = @"SELECT DATEPART(MM,T0.[DocDate]) as X, COUNT(T0.[DocNum]) as Y
                               FROM ORDR T0 
                               WHERE T0.[DocStatus] ='O'
                               GROUP BY DATEPART(MM,T0.[DocDate])";
            DataTable dt = new DataTable();
            List<ChartAxisModel> list = new List<ChartAxisModel>();
            using (SqlConnection conn = new SqlConnection(adoConStr))
            {
                using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                {
                    try
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.SelectCommand.CommandTimeout = 0;
                            da.Fill(dt);
                            foreach (DataRow row in dt.Rows)
                            {
                                list.Add(new ChartAxisModel() { X = Convert.ToString(row["X"]), Y = Convert.ToInt32(row["Y"]) });
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Fetching query execution failed");
                    }
                }

            }
            return list;
        }

        public IList<ChartLinesModel> GetSalesInvoiceChart()
        {
            string SqlString1 = @"SELECT DATEPART(MM,T0.[DocDate]) as X, COUNT(T0.[DocNum]) as Y
                               FROM ORDR T0 
                               WHERE T0.[DocStatus] ='C'
                               GROUP BY DATEPART(MM,T0.[DocDate])";
            string SqlString2 = @"SELECT DATEPART(MM,T0.[DocDate]) as X, COUNT(T0.[DocNum]) as Y
                               FROM OINV T0 
                               GROUP BY DATEPART(MM,T0.[DocDate])";
            DataTable dt = new DataTable();
            
            List<ChartLinesModel> line = new List<ChartLinesModel>();
            using (SqlConnection conn = new SqlConnection(adoConStr))
            {
                using (SqlCommand cmd = new SqlCommand(SqlString1, conn))
                {
                    try
                    {
                        List<ChartAxisModel> list = new List<ChartAxisModel>();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                             
                            da.SelectCommand.CommandTimeout = 0;
                            da.Fill(dt);
                            foreach (DataRow row in dt.Rows)
                            {
                                list.Add(new ChartAxisModel() { X = Convert.ToString(row["X"]), Y = Convert.ToInt32(row["Y"]) });
                            }
                        }
                        line.Add(new ChartLinesModel { ChartAxisList=list});

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Fetching query execution failed");
                    }
                }
                using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
                {
                    try
                    {
                        List<ChartAxisModel> list = new List<ChartAxisModel>();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dt.Clear();
                            da.SelectCommand.CommandTimeout = 0;
                            da.Fill(dt);
                            foreach (DataRow row in dt.Rows)
                            {
                                list.Add(new ChartAxisModel() { X = Convert.ToString(row["X"]), Y = Convert.ToInt32(row["Y"]) });
                            }
                        }
                        line.Add(new ChartLinesModel { ChartAxisList = list });

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Fetching query execution failed");
                    }
                }

            }
            return line;
        }            
    }
}
