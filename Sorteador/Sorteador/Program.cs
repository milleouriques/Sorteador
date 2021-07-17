using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n 1 - Sorteador Numeros \n 2 - Sorteador Duo \n 3 - Sortear Solo");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Varios.Varioss();
            }
            else if(escolha == 2)
            {
                Duo.Duoo();
            }
            else if (escolha == 3)
            {
                Solo.Soloo();
            }
        }
    }
}
