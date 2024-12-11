Console.WriteLine("Hello, World!");

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        int CheckNode(int depth, TreeNode node)
        {
            if (node.left == null)
            {
                if (node.right == null)
                {
                    return depth;
                }
                else
                {
                    return Math.Max(depth, CheckNode(depth + 1, node.right));
                }
            }
            else
            {
                if (node.right == null)
                {
                    return Math.Max(depth, CheckNode(depth + 1, node.left));
                }
                else
                {
                    return Math.Max(Math.Max(depth, CheckNode(depth + 1, node.left)), CheckNode(depth + 1, node.right));
                }
            }
        }

        return root == null ? 0 : CheckNode(1, root);
    }
}

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}