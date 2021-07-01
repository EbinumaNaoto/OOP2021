using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {

    class Program {

        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char ,int>();
            foreach (var c in text.ToUpper().OrderBy(c => c)) {
                //大文字小文字を区別しないため全て大文字に変換して処理
                if ('A' <= c && c <= 'Z') {
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict[c] = 1;
                }
            }
            
            foreach (var item in dict) {
                Console.WriteLine($"{item.Key} ,{item.Value}");
            }
            
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach (var c in text.ToUpper()) {
                //大文字小文字を区別しないため全て大文字に変換して処理
                if ('A' <= c && c <= 'Z') {
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict[c] = 1;
                }
            }

            foreach (var item in dict) {
                Console.WriteLine($"{item.Key} ,{item.Value}");
            }

        }
    }
}
