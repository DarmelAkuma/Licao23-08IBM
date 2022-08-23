using System;
using System.Collections.Generic;
using System.Text;

namespace LicaoQuadrante {
    class Calculo {

        public string Conta(int x, int y) {

            if (x > 0 && y > 0) {
                return "primeiro";
            }
            else if (x < 0 && y > 0) {
                return "segundo";
            }
            else if (x < 0 && y < 0) {
                return "terceiro";
            }
            else {
                return "quarto";
            }         
        }
    }
}
