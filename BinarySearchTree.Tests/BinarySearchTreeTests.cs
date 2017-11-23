using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace BinarySearchTree.Tests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void HappyPath()
        {
            var binarySearchTree = new BinarySearchTree();

            var n1 = binarySearchTree.AddNode();
            var n2 = binarySearchTree.AddNode();
            var n3 = binarySearchTree.AddNode();

            binarySearchTree.Contains(n2, 3).Should().BeTrue();
        }
    }
}
