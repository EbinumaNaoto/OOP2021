using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {

    class Program {

        static void Main(string[] args) {
            //"条件演算子"の例文
            var list = new List<int> { 10, 20, 30, 40, };
            var key = 40;
            var num = list.Contains(key)?1:0;   //条件演算子(三項演算子)
            Console.WriteLine(num);
            
            //"null合体演算子"の例文
            string code = "12345";
            var message = GetMessage(code) ?? DefaultMessage(); //null合体演算子
            Console.WriteLine(message);

            var ret = GetProductA();

            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();
            
            var product = Session["MyProduct"] as Product;
            if (true) {
                //productが取得できなかった時の処理
                Console.WriteLine("productが取得できなかった");
            } else {
                //productが取得できた時の処理
                Console.WriteLine("productが取得できた");
            }
        }

        //スタブ
        private static object DefaultMessage() {
            return "Default Message";
        }

        private static object GetMessage(object code) {
            return code;
        }

        //"null条件演算子"の例文
        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            return sale?.Product;   //null条件演算子
        }
    }

    class Sale {
        //プロパティの初期化
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12345;
        public Product Product { get; set; }
    }
}
