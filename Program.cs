using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;
            double q;
            
            Console.WriteLine("Uma milha marítma é mil e oitocentos e cinquenta e dois metros");
            Console.WriteLine("Já um quilometro é mil metros");
            Console.Write("Digite a milha marítma: ");
            m = double.Parse(Console.ReadLine());

            // Operação
            q = m * 1.852;

            Console.WriteLine("O resultado em km é igual a {0}", q);
        }
    }
}
