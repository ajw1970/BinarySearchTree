using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public void AddNode(int value)
        {
            if (_root == null)
            {
                _root = new BinaryNode(value);
                return;
            }

            if (_root.Value == value) return;

            _root.AddNode(value);
        }

        private BinaryNode _root;

        public bool Contains(int value)
        {
            return _root.Contains(value);
        }
    }
}
