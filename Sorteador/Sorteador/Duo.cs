using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteador
{
    class Duo
    {
        
            public static void Duoo()
            {
                Console.WriteLine("Digite o valor maximo");
                int max = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                List<int> numeros = new List<int>();
                Random random = new Random();
                for (int i = 1; i < max; i++)
                {
                    int number = random.Next(1, max + 1);
                    while (numeros.Contains(number))
                    {
                        if (numeros.Count >= max)
                            break;
                        else
                            number = random.Next(1, max + 1);
                    }
                    numeros.Add(number);
                    Console.WriteLine(number.ToString());
                }
                Console.ReadKey();
            }
    }
}

