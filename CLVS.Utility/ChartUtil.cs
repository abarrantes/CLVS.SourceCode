using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLVS.Model;
using System.Globalization;

namespace CLVS.Utility
{
    public static class ChartUtil
    {
        public static void SetMonthFormat(ChartLinesModel chartLineModel)
        {
            ChartAxisModel axis;
            for (int i = 1; i <= 12; i++)
            {
                if (chartLineModel.ChartAxisList.Where(flt => flt.X == i.ToString()).Count() > 0)
                {
                    axis = chartLineModel.ChartAxisList.Where(flt => flt.X == i.ToString()).First();
                }
                else
                {
                    axis = new ChartAxisModel { Y = 0, X = i.ToString() };                  
                    chartLineModel.ChartAxisList.Add(axis);
                }
            }
            chartLineModel.ChartAxisList=chartLineModel.ChartAxisList.OrderBy(ord => Convert.ToInt32(ord.X)).ToList();
            SetMonthName(chartLineModel);
               
        }

        public static void SetMonthName(ChartLinesModel chartLineModel)
        {
            foreach (var axis in chartLineModel.ChartAxisList)
            {
                axis.X = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(axis.X)).Substring(0,3);
            }            
        }
    
    }
}
