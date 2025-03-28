using BinaryTree.Main;
using BinaryTree.Main.MaximumDepthBinaryTree;
using FluentAssertions;

namespace testcases;

public class MaximuDepthTree_Tests
{
   [Test]
   public void Test_Example_1_DFS()
   {
      TreeNode node1 = new TreeNode(7);
      TreeNode node2 = new TreeNode(15);
      TreeNode node3 = new TreeNode(20, node2, node1);
      TreeNode node4 = new TreeNode(9);
      TreeNode node6 = new TreeNode(3, node4, node3);

      Solution solution = new();
      int testResult = solution.MaxDepthDFS(node6);

      testResult.Should().Be(3);
   }
   
   [Test]
   public void Test_Example_1_BFS()
   {
      TreeNode node1 = new TreeNode(7);
      TreeNode node2 = new TreeNode(15);
      TreeNode node3 = new TreeNode(20, node2, node1);
      TreeNode node4 = new TreeNode(9);
      TreeNode node6 = new TreeNode(3, node4, node3);

      Solution solution = new();
      int testResult = solution.MaxDepthBFS(node6);

      testResult.Should().Be(3);
   }
   
   [Test]
   public void Test_Example_1_Iterative_DFS()
   {
      TreeNode node1 = new TreeNode(7);
      TreeNode node2 = new TreeNode(15);
      TreeNode node3 = new TreeNode(20, node2, node1);
      TreeNode node4 = new TreeNode(9);
      TreeNode node6 = new TreeNode(3, node4, node3);

      Solution solution = new();
      int testResult = solution.MaxDepthIterativeDFS(node6);

      testResult.Should().Be(3);
   }
}