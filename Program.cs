namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");
            //CreateBST<int> bst = new CreateBST<int>(56);
            //bst.AddNode(30);
            //bst.AddNode(70);

            //Console.WriteLine(bst.Root.Key);
            //Console.WriteLine(bst.Root.Left.Key);
            //Console.WriteLine(bst.Root.Right.Key);

            Console.WriteLine("Create Binary Search Tree as shown in figure");
            CreateBST<int> bst = new CreateBST<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            bst.Display();
            bst.GetSize();
            bool result = bst.Search(63, bst);
            Console.WriteLine(result);
        }
    }
}
