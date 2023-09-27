using System.Diagnostics;
using System.Linq;

namespace Elliott_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r= new Random(Environment.TickCount);
            int ascii;
            char input;

            char[] container=new char[50];
            Stopwatch sw= new Stopwatch();

           // var limits=new HashSet<int>() { 91, 92, 93, 94, 95, 96 };
            sw.Start();
            for (int i=0; i<50; i++ )
            {
                //    ascii = r.Next(65, 122);


                ascii = r.Next(65, 123);
                input = (char)ascii;

                while (container.Contains(input) == true || Char.IsLetter(input)==false)
                {
                    ascii = r.Next(65, 123);
                    input = (char)ascii;
                }

                container[i] = input;

            }
            sw.Stop();
            string output = new string(container);
            Console.WriteLine(output);
            Console.WriteLine("Elapsed time during generation: "+sw.Elapsed);
        }
    }
}