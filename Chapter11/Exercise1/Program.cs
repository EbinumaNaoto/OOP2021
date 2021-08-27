using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {

    class Program {

        static void Main(string[] args) {

            var file = "Sample.xml";

            //11.1.1
            Exercise1_1(file);
            Console.WriteLine("-------");

            //11.1.2
            Exercise1_2(file);
            Console.WriteLine("-------");

            //11.1.3
            Exercise1_3(file);
            Console.WriteLine("-------");

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xballsports = xdoc.Root.Elements()
                                       .Select(x => new {
                                           Name = (string)x.Element("name"),
                                           Teammembers = (int)x.Element("teammembers"),
                                       });

            foreach (var xballsport in xballsports) {
                Console.WriteLine($"競技名:{xballsport.Name} チームメンバー数:{xballsport.Teammembers}人");
            }
        }

        private static void Exercise1_2(string file) {
            
        }

        private static void Exercise1_3(string file) {
            
        }
    }
}
