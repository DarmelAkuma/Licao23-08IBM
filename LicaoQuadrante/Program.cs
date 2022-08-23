using System;

namespace LicaoQuadrante {
    class Program {
        static void Main(string[] args) {

            Calculo calculo = new Calculo();

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            while (x != 0 && y != 0) {

                Console.WriteLine("{0}", calculo.Conta(x, y));

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }       
        }
    }
}
