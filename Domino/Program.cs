using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace Domino
{
    class Program
    {
        public static void Main(string[] args)
        {
            string jstr;
            int numberOfpieces;

            int matchCounter = 0;

            ReadJsonFile Reader = new ReadJsonFile();
            jstr = Reader.Readfile(@"C:\Temp\Pieces.json");
            
            var heapOf = JsonConvert.DeserializeObject<JInput>(jstr);//reading the json file
            
            numberOfpieces = heapOf.pieces.Length;//counting elements
           

            for (int p = 0; p < numberOfpieces; p++)
            {
                int[] sortArr = new int[numberOfpieces * 2]; //array for sorting
                //intit of the first element
                sortArr[0] = heapOf.pieces[p].left;
                sortArr[1] = heapOf.pieces[p].right;

                for (int i = 1, j = 2; i < numberOfpieces; i++, j = j + 2)
                {
                    if (heapOf.pieces[i].left == sortArr[j - 1] && (p!=i))//checking right side
                    {
                        sortArr[j] = heapOf.pieces[i].left;
                        sortArr[j + 1] = heapOf.pieces[i].right;

                        matchCounter++;
                       new PrintArr(sortArr, matchCounter);
                    }
                    else if (heapOf.pieces[i].right == sortArr[j - 1] && (p != i))//checking right side
                    {
                        sortArr[j] = heapOf.pieces[i].right;
                        sortArr[j + 1] = heapOf.pieces[i].left;

                        matchCounter++;
                        new PrintArr(sortArr, matchCounter);
                    }
                    else if (heapOf.pieces[i].left == sortArr[0] && (p != i))//checking left side
                    {
                        for (int cnt = sortArr.Length-1; cnt > 1; cnt = cnt - 2)
                        {
                            sortArr[cnt] = sortArr[cnt-2];
                            sortArr[cnt-1] = sortArr[cnt - 3];

                        }

                        sortArr[0] = heapOf.pieces[i].right;
                        sortArr[1] = heapOf.pieces[i].left;

                        matchCounter++;
                        new PrintArr(sortArr, matchCounter);
                    }
                    else if (heapOf.pieces[i].right == sortArr[0] && (p != i))//checking left side
                    {
                        for (int cnt = sortArr.Length - 1; cnt > 1; cnt = cnt - 2)
                        {
                            sortArr[cnt] = sortArr[cnt - 2];
                            sortArr[cnt - 1] = sortArr[cnt - 3];
                        }

                        sortArr[1] = heapOf.pieces[i].right;
                        sortArr[0] = heapOf.pieces[i].left;

                        matchCounter++;
                        new PrintArr(sortArr, matchCounter);
                    }



                }
            }

            Console.Read();
          

        }
    }
    
   
}
