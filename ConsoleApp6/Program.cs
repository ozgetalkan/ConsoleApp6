using Newtonsoft.Json.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args) //
        {
            string text = System.IO.File.ReadAllText(@"C:\Data\Products.Json"); //dummyjson.com/products
            JObject x = JObject.Parse(text);
            
            var y = x.Children().ToArray();

            var y1 = y[0].Value<JProperty>();

            var items = (JArray)y1.Value;
            JObject obj = (JObject)items[0];

            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(items[0].ToString());
            //Console.ResetColor();

            foreach (var item in obj.Properties())
            {
                //Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(item.Name);
                //Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item.Value);
            }
        }
    }
}