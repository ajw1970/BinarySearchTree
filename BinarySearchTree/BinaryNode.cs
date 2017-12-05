// file:	BinaryNode.cs
//
// summary:	Implements the binary node class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    /// <summary>   A binary node. </summary>
    public class BinaryNode
    {
        /// <summary>   Constructor. </summary>
        ///
        /// <param name="value">    The value. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        internal BinaryNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        /// <summary>   Gets the value. </summary>
        ///
        /// <value> The value. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int Value { get; }

        /// <summary>   Gets or sets the left. </summary>
        ///
        /// <value> The left. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public BinaryNode Left { get; private set; }

        /// <summary>   Gets or sets the right. </summary>
        ///
        /// <value> The right. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public BinaryNode Right { get; private set; }

        /// <summary>   Adds a node. </summary>
        ///
        /// <param name="newValue"> The new value. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNode(int newValue)
        {
            if (newValue == Value) return;

            if (newValue > Value)
            {
                if (Right == null)
                {
                    Right = new BinaryNode(newValue);
                    return;
                }
                Right.AddNode(newValue);
                return;
            }

            if (Left == null)
            {
                Left = new BinaryNode(newValue);
                return;
            }
            Left.AddNode(newValue);
        }

        /// <summary>   Query if this object contains the given testValue. </summary>
        ///
        /// <param name="testValue">    The int to test for containment. </param>
        ///
        /// <returns>   True if the object is in this collection, false if not. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Contains(int testValue)
        {
            if (testValue == Value) return true;
            if (testValue > Value)
            {
                if (Right == null) return false;
                return Right.Contains(testValue);
            }
            if (Left == null) return false;
            return Left.Contains(testValue);
        }
    }
}
