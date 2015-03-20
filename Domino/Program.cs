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
            string str;
            ReadJasonFile Reader = new ReadJasonFile();
            Object Pieces = new Object();
            str = Reader.Readfile(@"C:\Users\Roman\Documents\Visual Studio 2012\Projects\Domino\Pieces.json");

            var pieces = JsonConvert.DeserializeObject<JInput>(str);
            //Pieces = JsonConvert.DeserializeObject<Piece>(str);

            JToken entireJson = JToken.Parse(str);
            
            //JObject o = JObject.Parse(str);

            //JArray inner = entireJson["Pieces"].Value<JArray>();

            //This will be "Apple"
            //string name = (string)o["left"];

            Console.Write(str);
            Console.Read();

        }
    }
    public class JPiece
    {
        public int left { get; set; }
        public int right { get; set; }
    }
    public class JInput
    {
        public JPiece[] pieces { get; set; }
    }
}
