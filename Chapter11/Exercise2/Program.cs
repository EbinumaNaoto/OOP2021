using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2 {

    class Program {

        static void Main(string[] args) {

            var newXdoc = new XDocument(); //新しいXML
            var newElement = new XElement("dificultkanji",
                                    new XElement("word", new XAttribute("kanji",""),new XAttribute("yomi",""))); //新しいXMLの部品

            var xdoc = XDocument.Load("11_2.xml"); //読み込み
            var xdifficultkanji = xdoc.Root.Elements() //旧式データの取り出し
                                          .Select(x => new {
                                            Kanji = x.Element("kanji").Value,
                                            Yomi = x.Element("yomi").Value,
                                          });

            //新しいXMLへの書き込み
            foreach (var word in xdifficultkanji) {
                newElement.Attribute("kanji").Value = word.Kanji;
                newElement.Attribute("yomi").Value = word.Yomi;
                newXdoc.Root.Add(newElement);
            }

            newXdoc.Save("11_2kaitou.xml");


        }
    }
}
