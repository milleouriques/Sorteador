using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteador
{
    class Varios
    {
        public static void Varioss()
        {
            Console.WriteLine("Digite o valor maximo");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o quantos elementos sortear");// add
            int contagem = Convert.ToInt32(Console.ReadLine());     //add
            Console.Clear();
            List<int> numeros = new List<int>();
            Random random = new Random();
            for (int i = 1; i < contagem + 1; i++)//change
            {
                int number = random.Next(1, max + 1);
                while (numeros.Contains(number))
                {
                    if (numeros.Count >= contagem) //change
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
