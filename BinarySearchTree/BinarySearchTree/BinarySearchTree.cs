using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class BinarySearchTree<T>
    {
        private TreeElement root;
        private IComparer<T> comparer;

        public BinarySearchTree(IComparer<T> comparer = null)
        {
        }

        public IEnumerable<T> PreorderTraversal()
        {
            if (root != null)
            {
                return Preorder(root);
            }
            else
            {
                return null;
            }
        }

        private IEnumerable<T> Preorder(TreeElement current)
        {
            yield return current.Data;
            if (current.Left != null)
            {
                foreach(var val in Preorder(current.Left))
                {
                    yield return val;
                }
            }
            
            if (current.Right != null)
            {
                foreach (var val in Preorder(current.Right))
                {
                    yield return val;
                }
            }
        }

        public IEnumerable<T> InorderTraversal()
        {
            if (root != null)
            {
                return Inorder(root);
            }
            else
            {
                return null;
            }
        }

        private IEnumerable<T> Inorder(TreeElement current)
        {
            if (current.Left != null)
            {
                foreach (var val in Inorder(current.Left))
                {
                    yield return val;
                }
            }

            yield return current.Data;
            if (current.Right != null)
            {
                foreach (var val in Inorder(current.Right))
                {
                    yield return val;
                }
            }
        }

        public IEnumerable<T> PostorderTraversal()
        {
            if (root != null)
            {
                return Postorder(root);
            }
            else
            {
                return null;
            }
        }

        private IEnumerable<T> Postorder(TreeElement current)
        {
            if (current.Left != null)
            {
                foreach (var val in Postorder(current.Left))
                {
                    yield return val;
                }
            }

            if (current.Right != null)
            {
                foreach (var val in Postorder(current.Right))
                {
                    yield return val;
                }
            }

            yield return current.Data;
        }

        public bool Add(T value)
        {
            if (comparer != null)
            {
                return AddComparer(value);
            }

            if (root == null)
            {
                root = new TreeElement(value);
                return true;
            }
            
            TreeElement currentElement = root;
            while (true)
            {
                int comparisonResult = ((dynamic)value).CompareTo(currentElement.Data);
                if (comparisonResult > 0)
                {
                    if (currentElement.Right != null)
                    {
                        currentElement = currentElement.Right;
                    }
                    else
                    {
                        currentElement.Right = new TreeElement(value);
                        return true;
                    }
                }
                else if (comparisonResult < 0)
                {
                    if (currentElement.Left != null)
                    {
                        currentElement = currentElement.Left;
                    }
                    else
                    {
                        currentElement.Left = new TreeElement(value);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        private bool AddComparer(T value)
        {
            if (root == null)
            {
                root = new TreeElement(value);
                return true;
            }

            TreeElement currentElement = root;
            while (true)
            {
                int comparisonResult = comparer.Compare(value, currentElement.Data);
                if (comparisonResult > 0)
                {
                    if (currentElement.Right != null)
                    {
                        currentElement = currentElement.Right;
                    }
                    else
                    {
                        currentElement.Right = new TreeElement(value);
                        return true;
                    }
                }
                else if (comparisonResult < 0)
                {
                    if (currentElement.Left != null)
                    {
                        currentElement = currentElement.Left;
                    }
                    else
                    {
                        currentElement.Left = new TreeElement(value);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public class TreeElement
        {
            public TreeElement(T value)
            {
                Data = value;
            }

            public TreeElement Right
            {
                get; set;
            }

            public TreeElement Left
            {
                get; set;
            }

            public T Data
            {
                get;
            }
        }
    }
}
