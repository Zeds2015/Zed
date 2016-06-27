using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Ex01
    {
        static void Main(string[] args)
        {
            Exercicio_Total n = new Exercicio_Total();
            int menor = n.exercicio01();

            Console.WriteLine("\nO menor número é: " + menor);
            Console.ReadKey();
        }
    }
}
