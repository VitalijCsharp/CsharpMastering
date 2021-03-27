using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BuildTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tree<char> charTree = null;
            //char[] items = { 'C', 'S', 'A', 'M', 'L', 'O' };

            //InsertIntoTree<char>(ref charTree, items);
            //string sortedData = charTree.WalkTree();
            //Console.WriteLine(sortedData);

            Wrapper<string> wrappedString = new Wrapper<string>();
            IWrapper<string> iwrappedString = wrappedString;
            iwrappedString.SetData("Hello");
            Console.WriteLine(iwrappedString.GetData());
        }
        static void InsertIntoTree<TItem>(ref Tree<TItem> tree, params TItem[] data) where TItem : IComparable<TItem>
        {
            foreach (var datum in data)
            {
                if(tree == null)
                {
                    tree = new Tree<TItem>(datum);
                }
                else
                {
                    tree.Insert(datum);
                }
            }
        }
    }
}
