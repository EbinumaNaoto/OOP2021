﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {

    class Program {

        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));

            Dictionary<string, int> amountPerStore =  sales.GetPerStoreSales();
            foreach (KeyValuePair<string, int> obj in amountPerStore) {
                Console.WriteLine("{0} {1}",obj.Key, obj.Value);
            }
        }

        // List2-15
        // 売上データを読み込み、Saleオブジェクトのリストを返す
        private static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
