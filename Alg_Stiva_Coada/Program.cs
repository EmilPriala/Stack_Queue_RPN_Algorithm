using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Stiva_Coada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            TADL coada = new MyQueue();
            
            for (int i = 0; i < 10; i++)
            {
                coada.Push(i);
                coada.Pop();
                coada.Pop();
            }
            Console.WriteLine(coada.View());
            Console.ReadKey();*/

            RPN rPN = new RPN();
            rPN.Eval();
            Console.ReadKey();
        }
    }
}
