using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };

            #region テスト用ドライバ
            //6.1.1
            Exercise1_1(numbers);
            Console.WriteLine("------");

            //6.1.2
            Exercise1_2(numbers);
            Console.WriteLine("------");

            //6.1.3
            Exercise1_3(numbers);
            Console.WriteLine("------");

            //6.1.4
            Exercise1_4(numbers);
            Console.WriteLine("------");

            //6.1.5
            Exercise1_5(numbers);
            #endregion
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach (var number in numbers.Skip(skip))
                Console.Write(number + " ");
            Console.WriteLine();
        }

        private static void Exercise1_3(int[] numbers) {
            numbers.Select(i => i.ToString()).ToList().ForEach(s => Console.Write(s+" "));
            Console.WriteLine();
        }

        private static void Exercise1_4(int[] numbers) {
            numbers.OrderBy(i => i).Take(3).ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine(numbers.Distinct().Count(i => i > 10));
        }
    }
}
