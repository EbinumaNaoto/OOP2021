﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesCalculator {
    //売上集計クラス
    class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        // List2-15
        // 売上データを読み込み、Saleオブジェクトのリストを返す
        private IEnumerable<Sale> ReadSales(string filePath) {
            var sales = new List<Sale>();
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

        //List 2-17
        //店舗別売上
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    //既にコレクションに店舗が設定されている
                    dict[sale.ShopName] += sale.Amount;
                } else {
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }
    }
}
