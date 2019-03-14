using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarMaquinaDeCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe maquina;
            maquina = new MaquinaCafe();
            //double _valorCafe = 0;
            double entrada = 0;

            Console.WriteLine("******Maquina de Café******");
            Console.WriteLine();


            //while (entrada < 10)
            //{
            //}
            Console.WriteLine("Insira a moeda: ");
            entrada = Convert.ToDouble(Console.ReadLine());
            maquina.ValorCafe = Convert.ToDouble(entrada);
            
            Console.WriteLine("O valor é: " + "R$" + maquina.ValorCafe);

            Console.ReadKey();

        }
    }
}
