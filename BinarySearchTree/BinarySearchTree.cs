namespace BinarySearchTree
{
    /// <summary>
    /// A binary search tree allowing nodes to be added to the tree and a check to see if a given
    /// value exists in the tree. The Binary Search Tree allows quickly finding a value in the tree
    /// without having to look at every member.
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>   Adds a node to the tree for a given value. </summary>
        ///
        /// <param name="value">    The int to add to the tree. </param>
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

        /// <summary>   Query if this tree contains the given value. </summary>
        ///
        /// <param name="value">    The int to test for containment. </param>
        ///
        /// <returns>   True if the value is in this collection, false if not. </returns>
        public bool Contains(int value)
        {
            return _root.Contains(value);
        }

        private BinaryNode _root;
    }
}
