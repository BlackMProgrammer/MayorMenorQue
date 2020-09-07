using System;

namespace MayorMenorQue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el Primer numero");
            string valnumero1 = Console.ReadLine();

            int numero1 = Convert.ToInt32(valnumero1);

            Console.WriteLine("Digite el Segundo numero");
            string valnumero2 = Console.ReadLine();

            int numero2 = Convert.ToInt32(valnumero2);

            if (numero1 > numero2)
            {
                Console.WriteLine("{0} es mayor que {1} ", numero1, numero2);
            }
            else {
                Console.WriteLine("{0} es menor que {1} ", numero1, numero2);
            }

        }
    }
}
