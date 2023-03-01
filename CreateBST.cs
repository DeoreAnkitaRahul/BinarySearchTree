using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class CreateBST
    {
        public interface INode<T> where T : IComparable<T>
        {
            T Key { get; set; }
            INode<T> Left { get; set; }
            INode<T> Right { get; set; }
        }

        public class BinaryNode<T> : INode<T> where T : IComparable<T>
        {
            public T Key { get; set; }
            public INode<T> Left { get; set; }
            public INode<T> Right { get; set; }

            public BinaryNode(T key)
            {
                Key = key;
                Left = null;
                Right = null;
            }
        }

        public class BinarySearchTree<T> where T : IComparable<T>
        {
            public INode<T> Root { get; set; }

            public BinarySearchTree(T key)
            {
                Root = new BinaryNode<T>(key);
            }

            public void AddNode(T key)
            {
                AddNode(Root, key);
            }

            private void AddNode(INode<T> node, T key)
            {
                if (key.CompareTo(node.Key) < 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new BinaryNode<T>(key);
                    }
                    else
                    {
                        AddNode(node.Left, key);
                    }
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new BinaryNode<T>(key);
                    }
                    else
                    {
                        AddNode(node.Right, key);
                    }
                }
            }
        }
    }
    public interface INode<T> where T : IComparable<T>
    {
        T Key { get; set; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
    }

    public class BinaryNode<T> : INode<T> where T : IComparable<T>
    {
        public T Key { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }

        public BinaryNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public INode<T> Root { get; set; }

        public BinarySearchTree(T key)
        {
            Root = new BinaryNode<T>(key);
        }

        public void AddNode(T key)
        {
            AddNode(Root, key);
        }

        private void AddNode(INode<T> node, T key)
        {
            if (key.CompareTo(node.Key) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryNode<T>(key);
                }
                else
                {
                    AddNode(node.Left, key);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryNode<T>(key);
                }
                else
                {
                    AddNode(node.Right, key);
                }
            }
        }
    }
}
public interface INode<T> where T : IComparable<T>
{
    T Key { get; set; }
    INode<T> Left { get; set; }
    INode<T> Right { get; set; }
}

public class BinaryNode<T> : INode<T> where T : IComparable<T>
{
    public T Key { get; set; }
    public INode<T> Left { get; set; }
    public INode<T> Right { get; set; }

    public BinaryNode(T key)
    {
        Key = key;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree<T> where T : IComparable<T>
{
    public INode<T> Root { get; set; }

    public BinarySearchTree(T key)
    {
        Root = new BinaryNode<T>(key);
    }

    public void AddNode(T key)
    {
        AddNode(Root, key);
    }

    private void AddNode(INode<T> node, T key)
    {
        if (key.CompareTo(node.Key) < 0)
        {
            if (node.Left == null)
            {
                node.Left = new BinaryNode<T>(key);
            }
            else
            {
                AddNode(node.Left, key);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new BinaryNode<T>(key);
            }
            else
            {
                AddNode(node.Right, key);
            }
        }
    }
}



