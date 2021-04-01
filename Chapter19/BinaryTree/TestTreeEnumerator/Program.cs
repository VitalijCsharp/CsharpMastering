using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace TestTreeEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Insert(20);
            tree.Insert(-100);
            tree.Insert(15);
            tree.Insert(0);
            tree.Insert(235);
            tree.Insert(5);
            tree.Insert(2);
            tree.Insert(50);

            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
        }
    }
}
