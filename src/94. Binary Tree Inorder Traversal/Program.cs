Console.WriteLine(1);

public class Solution
{
    public IList<int> InorderTraversal(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        List<int> list = [];

        void PassNode(TreeNode node)
        {
            if (node.Left != null)
            {
                PassNode(node.Left);
            }

            list.Add(node.Val);

            if (node.Right != null)
            {
                PassNode(node.Right);
            }
        }

        PassNode(root);

        return list;
    }
}

public class TreeNode
{
    public readonly int Val;
    public readonly TreeNode? Left;
    public readonly TreeNode? Right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }
}