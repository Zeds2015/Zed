using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
   public class Exercicio_Total
    {
        int[] vetor = new int[3];
        int i = 0;


        public int exercicio01()
        {
            while(i < 3)
            {
                Console.Write("Digite um Número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                i++;
            }
            int menor = vetor.Min();
            return menor;
        }

        public int Menor(params int[] leks)
        {
            int menor = leks.Min();
                return menor;
        }
    }
}
