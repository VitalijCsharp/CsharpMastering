using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftNode { get; set; }
        public Tree<TItem> RightNode { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftNode = null;
            this.RightNode = null;
        }

        public void Insert(TItem newItem)
        {

            //TItem currentNodeValue = this.NodeData;

            if (this.NodeData == null)
            {
                this.NodeData = newItem;
            }
            else
            {
                if (NodeData.CompareTo(newItem) > 0)
                {
                    if (LeftNode == null)
                    {
                        this.LeftNode = new Tree<TItem>(newItem);
                    }
                    else
                    {
                        this.LeftNode.Insert(newItem);
                    }
                }
                else
                {
                    if (RightNode == null)
                    {
                        this.RightNode = new Tree<TItem>(newItem);
                    }
                    else
                    {
                        this.RightNode.Insert(newItem);
                    }
                }
            }
        }

        public string WalkTree()
        {
            string result = "";

            if (this.LeftNode != null)
            {
               result = this.LeftNode.WalkTree();
            }            
                
            result +=$" {NodeData.ToString()}";        

            if (this.RightNode != null)
            {
                result += this.RightNode.WalkTree();
            }       
                           
            return result;
        }
    }
}
