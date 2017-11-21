using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tree = new BinarySearchTree<float>();
            tree.Add(1);
            tree.Add(23);
            tree.Add(23.0024f);
            tree.Add(25);
            tree.Add(-1234);
            tree.Add(14);
            tree.Add(-100);
            foreach (var f in tree.PostorderTraversal())
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}
