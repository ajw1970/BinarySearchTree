// file:	BinarySearchTree.cs
//
// summary:	Implements the binary search tree class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>   A binary search tree. </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class BinarySearchTree
    {
        /// <summary>   Adds a node. </summary>
        ///
        /// <param name="value">    The int to test for containment. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        /// <summary>   The root. </summary>
        private BinaryNode _root;

        /// <summary>   Query if this object contains the given value. </summary>
        ///
        /// <param name="value">    The int to test for containment. </param>
        ///
        /// <returns>   True if the object is in this collection, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Contains(int value)
        {
            return _root.Contains(value);
        }
    }
}
