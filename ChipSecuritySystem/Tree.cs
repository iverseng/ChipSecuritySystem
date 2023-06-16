using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    class Tree
    {

        public class Node<T>
        {
            public T Value { get; set; }
            public List<Node<T>> Children { get; set; }

            public Node(T value)
            {
                Value = value;
                Children = new List<Node<T>>();
            }

            public void AddChild(Node<T> child)
            {
                Children.Add(child);
            }
        }

        public class OneWayTree<T>
        {
            public Node<T> Root { get; private set; }

            public OneWayTree(T rootValue)
            {
                Root = new Node<T>(rootValue);
            }
        }
    }
}




