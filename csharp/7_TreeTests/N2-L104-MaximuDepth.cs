using BinaryTree.Main;
using BinaryTree.Main.MaximumDepthBinaryTree;
using FluentAssertions;

namespace testcases;

public class MaximuDepth_Tests
{
   [Test]
   public void Test_Example_1()
   {
      TreeNode node1 = new TreeNode(7);
      TreeNode node2 = new TreeNode(15);
      TreeNode node3 = new TreeNode(20, node2, node1);
      TreeNode node4 = new TreeNode(9);
      TreeNode node6 = new TreeNode(3, node4, node3);

      Solution solution = new();
      int testResult = solution.MaxDepth(node6);

      testResult.Should().Be(3);
   }
}