using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class PrintArr
    {
        public PrintArr(int[] arr, int seq)
        {
            Console.Write("sequence #: "+seq.ToString()+"\n");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                
                if (arr[i] !=0)
                    Console.Write(arr[i].ToString());
            }

            Console.Write("\n");
        }

    }
}
