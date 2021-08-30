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

            //11.1.4
            Exercise1_4(file);
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
            var xdoc = XDocument.Load(file);
            var xballsports = xdoc.Root.Elements()
                                       .Select(x => new {
                                           Firstplayed = x.Element("firstplayed").Value,
                                           Name = x.Element("name").Attribute("kanji").Value,
                                       }).OrderBy(x => int.Parse(x.Firstplayed));
            foreach (var xballsport in xballsports) {
                Console.WriteLine($"{xballsport.Name} {xballsport.Firstplayed}");
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xballsport = xdoc.Root.Elements()
                                       .Select(x => new {
                                           Teammembers = x.Element("teammembers").Value,
                                           Name = x.Element("name").Value,
                                       }).OrderByDescending(x => int.Parse(x.Teammembers))
                                       .First();
            Console.WriteLine($"最大人数競技名:{xballsport.Name} {xballsport.Teammembers}人");
        }

        private static void Exercise1_4(string file) {

            var newfile = "sports.xml"; //出力する新しいファイル

            //P290 リスト11.15を参考にする
            var element = new XElement("ballsport",
                                        new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                        new XElement("teammembers", "11"),
                                        new XElement("firstplayed", "1867"));

            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
        }
    }
}
