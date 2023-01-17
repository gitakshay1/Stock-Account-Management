using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Account_Management
{
    internal class Stock_Portfolio
    {
        Stocks stock = new Stocks();

        List<Stocks> list = new List<Stocks>();
        public void StockReport(string jFilePath)
        {
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Stocks>>(json);
                Console.WriteLine("***** Stock Report ****** ");
                foreach (var objects in items)
                {
                    double value = objects.Shares * objects.SharePrice;
                    Console.WriteLine("Stock : "+objects.StockName + " Shares : " + objects.Shares + " SharePrice : " + objects.SharePrice + " Total Value fos stock : " + value);
                }
            }
        }
    }
}
