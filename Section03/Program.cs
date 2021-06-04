using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            Exercise3_1(names);
            Console.WriteLine("-----");

            Exercise3_2();
            Console.WriteLine("-----");

        }

        private static void Exercise3_1(List<string> names) {
            int count = 0;
            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
        }

        private static void Exercise3_2() {
            
        }

    }
}
