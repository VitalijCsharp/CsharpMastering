using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenPosition sp = new ScreenPosition();
            sp.X = -10;
            sp.Y = -1281;
            Console.WriteLine($"X = {sp.X} Y = {sp.Y}");

        }
    }
}
