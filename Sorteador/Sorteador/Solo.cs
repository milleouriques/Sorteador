using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteador
{
    public class Solo
    {
        public static void Soloo()
        {
            Console.WriteLine("Digite o valor maximo");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Random random = new Random();
            int number = random.Next(1, max + 1);
            Console.WriteLine($"O sorteado foi {number}");
            
            Console.ReadKey();
        }
    }
}
