namespace BinarySearchTree
{
    internal class BinaryNode
    {
        internal BinaryNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public int Value { get; }

        public BinaryNode Left { get; private set; }

        public BinaryNode Right { get; private set; }

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
