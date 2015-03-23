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
            Console.WriteLine ("sequence #: "+seq.ToString());
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] != 0)
                    Console.Write(arr[i].ToString());
            }

            //foreach (int a in arr)
            //    Console.Write(arr[a]);

            Console.WriteLine();
        }

    }
}
