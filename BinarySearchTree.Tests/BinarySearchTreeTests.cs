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
        [Theory]
        [InlineData(new[] { 2, 1, 3 }, 3, true)]
        [InlineData(new[] { 2, 1, 3 }, 4, false)]
        [InlineData(new[] { 1, 2, 3 }, 3, true)]
        [InlineData(new[] { 1, 2, 3 }, 4, false)]
        [InlineData(new[] { 5, 1, 9, 3, 5, 2 }, 3, true)]
        [InlineData(new[] { 5, 1, 9, 3, 5, 2 }, 4, false)]
        public void Contains_WorksAsExpected(int[] values, int testValue, bool expectedResult)
        {
            var binarySearchTree = new BinarySearchTree();

            foreach (var value in values)
            {
                binarySearchTree.AddNode(value);
            }

            binarySearchTree.Contains(testValue).Should().Be(expectedResult);
        }
    }
}
