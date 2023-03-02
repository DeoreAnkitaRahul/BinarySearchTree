using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    class CreateBST<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public CreateBST<T> leftTree { get; set; }
        public CreateBST<T> rightTree { get; set; }
        public CreateBST(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;
        }
        static int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    leftCount++;
                    this.leftTree = new CreateBST<T>(item);
                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                {
                    rightCount++;
                    this.rightTree = new CreateBST<T>(item);
                }
                else
                    this.rightTree.Insert(item);
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + leftCount + rightCount));
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightTree.Display();
            }
        }
    }
}
