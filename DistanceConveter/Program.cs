using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConveter {
    class Program {

        public static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeelToMeterList(1,10);
            } else {
                PrintMeterToFeelList(1,10);
            }
        }

        // メートルからフィートへの対応表を出力
        private static void PrintMeterToFeelList(int state,int stop) {
            for (int meter = state; meter <= stop; meter++) {
                double feet = FeetConverter.MeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

        // フィートからメートルへの対応表を出力
        private static void PrintFeelToMeterList(int state,int stop) {           
            for (int feet = state; feet <= stop; feet++) {
                double meter = FeetConverter.FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
        
    }
}