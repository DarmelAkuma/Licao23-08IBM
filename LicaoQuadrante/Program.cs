using System;

namespace LicaoQuadrante {
    class Program {
        static void Main(string[] args) {
            Conta();
        }
        static void Conta() {

            string[] valores = Console.ReadLine().Split(' ');
            int coordenadaX = int.Parse(valores[0]);
            int coordenadaY = int.Parse(valores[1]);

            while (coordenadaX != 0 && coordenadaY != 0) {
                if (coordenadaX > 0 && coordenadaY > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (coordenadaX < 0 && coordenadaY > 0) {
                    Console.WriteLine("segundo");
                }
                else if (coordenadaX < 0 && coordenadaY < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");


                }
                valores = Console.ReadLine().Split(' ');
                coordenadaX = int.Parse(valores[0]);
                coordenadaY = int.Parse(valores[1]);
            }
        }
    }
}
