using System;
using System.Text;
using System.Threading;

namespace bruteforcehelloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'H', 'E', 'L', 'L', 'O', ' ', 'W', 'O', 'R', 'L', 'D', '!' };
            int counter = 0;
            Random rnd = new Random();
            StringBuilder helloStr = new StringBuilder();
            while (helloStr.ToString() != "HELLO WORLD!") {
                for (int index = 0; index < letters.Length; index++) {
                    foreach (char c in letters) {
                        if (rnd.Next(90) == c) {
                            helloStr.Append(c);
                            Console.Write(c);
                            counter++;
                        } else {
                        //    Console.Write(Convert.ToChar(rnd.Next(90)));
                        }
                    }
                }
            }
            Console.WriteLine(counter + " letters processed");
            Console.ReadLine();
        }
    }
}
