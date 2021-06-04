using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };
            
            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.Write("都市名を入力してください:");
            var line = Console.ReadLine();
            Console.WriteLine(names.FindIndex(s => s == line));
        }

        private static void Exercise2_2(List<string> names) {
            Console.WriteLine(names.Count(s => s.Contains('o')));
        }

        private static void Exercise2_3(List<string> names) {
            var array = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in array)
                Console.Write("\"{0}\", ", name);
            Console.WriteLine();
        }

        private static void Exercise2_4(List<string> names) {
            var indexs = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var i in indexs)
                Console.Write("{0}, ", i);
            Console.WriteLine();
        }
    }
}
