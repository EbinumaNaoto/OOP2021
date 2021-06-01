using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize2 {

    //インチとメートルの単位変換クラス(静的クラス)
    public static class InchConverter {

        //フィールド
        private const double raito = 0.0254; //インチ(定数)

        //メートルからインチを求める
        public static double FromMeter(double meter) {
            return meter * raito;
        }

        //インチからメートルを求める
        public static double ToMeter(double inch) {
            return inch * raito;
        }


    }
}
