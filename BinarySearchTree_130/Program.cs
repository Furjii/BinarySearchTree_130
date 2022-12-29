using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_130
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the nod class

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /* A node class consist of the tree things, the information to the right child, and references to the left child. */

    class binarytree
    {
        public Node ROOT;
        public binarytree()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
        public void insert(string element)/* Insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)/*Check if the node to be inserted already inserted or not */
            {
                Console.WriteLine("Duplicate words not allowerd");
                return;
            }
            else /* if the specified node is not present */
            {
                tmp = new Node(element, null, null); /*creates a node*/
                if (parent == null) /* if the trees is empty*/
            }
        }
    }
        static void Main(string[] args)
        {
        }
    }
}
