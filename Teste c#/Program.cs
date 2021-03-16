using System;

namespace Teste_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 5;
            Classe01 cla = new Classe01();
            cla.Calculo(n);
        }
    }

    class Classe01{
        public double numero {get; set;}
        public void Calculo(double x)

        {
            numero = x;
            double[] vet = new double[3];
            vet[0]= 10;
            vet[1]= 20;
            vet[2]=30;
            
            for (var i = 0; i < vet.Length; i++)
            {
                vet[i] = vet[i] + numero + i;
                Console.Write(vet[i]);
            }
        }
    }
}
