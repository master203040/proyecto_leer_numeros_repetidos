using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class proyecto2
    {
        static void Main(string[] args) 
        {
            int[] myArray = { 1, 3, 9, 3, 9, 1, 2};
            bool repley = false;
            for (var x = 0; x < myArray.Length; x++)
            {
                int a = myArray[x];
                int c = x +1;
                for (int y = c; y< myArray.Length; y++)
                {

                    int b = myArray[y];
                    if (a == b)
                    {
                        repley = true;
                        System.Console.WriteLine("en numero " + a + "esta repetido en la lista ");
                    }

                }
            
                
            }
            if (repley==false)
            {
                System.Console.WriteLine("no hay numeros repetidos en la lista ");
            
            }


        }

    }
}
