using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class programa2
    {
        public void Main(string[] agrs) {

            int[] myArray = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };
            int[] lista = new int[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        count++;
                    }

                    if (Numero(myArray[j]))
                    {
                        lista[i] = myArray[j];
                    }

                }
                if (lista[i] != 0)
                {
                    Console.WriteLine(lista[i] + "se repite:" + count);

                }

            }
            bool Numero(int num)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i] == num)
                    {
                        return false;
                    }
                }
                return true;
            }

        }


    }
}
    
