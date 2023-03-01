namespace BinarySearchTree   
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.AddNode(30);
            bst.AddNode(70);

            Console.WriteLine(bst.Root.Key);
            Console.WriteLine(bst.Root.Left.Key);
            Console.WriteLine(bst.Root.Right.Key);
        }
    }
}