using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryNode
    {
        internal BinaryNode(int value = 1, BinaryNode left = null)
        {
            Value = value;
            Left = left;
            Right = null;
        }

        public int Value { get; }
        public BinaryNode Left { get; }
        public BinaryNode Right { get; private set; }

        public BinaryNode AddNode()
        {
            Right = new BinaryNode(Value + 1, this);
            return Right;
        }
    }
}
