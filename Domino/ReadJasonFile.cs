using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Domino
{
    public class ReadJasonFile
    {
        private string _text;

        public ReadJasonFile()
        {
            // string _text = System.IO.File.ReadAllText(@"C:\Users\Roman\Documents\Visual Studio 2012\Projects\Domino\Pieces.json");
           
        }
        
        
         public string Readfile(string file)
         {
        
             _text = System.IO.File.ReadAllText(file);
             return _text;
         }
        //static ReadJasonFile serializer = new ReadJasonFile();
        //static MemoryStream stream1 = new MemoryStream();

        //stream1.Position = 0;
        //StreamReader sr = new StreamReader(stream1);

        //StreamReader sr = new StreamReader(stream1);


        //public ReadJasonFile()
        //{

        //    MyObject obj = serializer.Deserialize<MyObject>(File.ReadAllText(@"C:\Users\Roman\Documents\Visual Studio 2012\Projects\Domino\Pieces.json"));
        //}

    }
}
