using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public BinarySearchTree()
        {
            _binaryNodes = new List<BinaryNode>();
        }

        public BinaryNode AddNode()
        {
            BinaryNode newNode = null;
            BinaryNode lastNode = _binaryNodes.LastOrDefault();
            if (lastNode == null)
            {
                newNode = new BinaryNode();
            }
            else
            {
                newNode = lastNode.AddNode();
            }
            
            _binaryNodes.Add(newNode);
            return newNode;
        }

        private readonly List<BinaryNode> _binaryNodes;

        public bool Contains(BinaryNode node, int value)
        {
            if (node.Value == value) return true;
            if (node.Left != null && node.Left.Value == value) return true;
            if (node.Right != null && node.Right.Value == value) return true;
            return false;
        }
    }
}
