using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize2 {

    class InchConverter {

        //フィールド
        private const double raito = 0.0254; //インチ(定数)

        //メソッド
        public static double ToMeter(double inch) {
            return inch * raito;
        }


    }
}
