using BinaryTree.Main;
using BinaryTree.Main.InvertBinaryTree;
using FluentAssertions;

namespace testcases;

public class InvertBinaryTree_Tests
{
    [Test]
    public void Test_Example_1()
    {
        TreeNode four = new(4);
        TreeNode five = new(5);
        TreeNode six = new(6);
        TreeNode seven = new(7);
        TreeNode two = new(2, four, five);
        TreeNode three = new(3, six, seven);
        TreeNode one = new(1, two, three);

        var solution = new Solution();
        TreeNode invertedTree = solution.InvertTree(one);
        
        invertedTree.val.Should().Be(1);
        invertedTree.left.val.Should().Be(3);
        invertedTree.right.val.Should().Be(2);
        invertedTree.left.left.val.Should().Be(7);
        invertedTree.left.right.val.Should().Be(6);
        invertedTree.right.left.val.Should().Be(5);
        invertedTree.right.right.val.Should().Be(4);
    }
}