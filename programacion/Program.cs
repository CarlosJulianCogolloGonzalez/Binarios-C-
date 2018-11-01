using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binarios
{
    class Program
    {
        static void Main(string[] args)
        {
            const int est =2;
            int x =0;
            int A = 0;
            int D = 0;
            int I = 0;
            int [] vectordebinarios = new int[21];
            string linea;
            Console.Write("Ingrese un Numero:");
            linea = Console.ReadLine();
             x = int.Parse(linea);
            D = 1;
            while ((x >= est))
            {
                A = x % est;
                vectordebinarios[D] = A;
                D = D + 1;
                x = x / est;
            }
            vectordebinarios [D] = x;
            
            for (I = D; I >= 1;I += -1)
            {
                Console.Write(vectordebinarios[I] + " ");
            }
           
        }
    }
}
