using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mammal[] arr = { new Horse(), new Whale(), new Human() ,new Delphine()};

                foreach (var item in arr)
                {
                    Console.WriteLine(item.GetName());
                }
                Delphine del = new Delphine();
                Console.WriteLine(del.GetName());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

       
            
        
    }
}
