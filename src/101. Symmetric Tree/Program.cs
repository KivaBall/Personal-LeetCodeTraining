/*var tree = new TreeNode(
    1,
    new TreeNode(
        2,
        new TreeNode(3),
        new TreeNode(4)),
    new TreeNode(
        2,
        new TreeNode(4),
        new TreeNode(3)));*/

/*var tree = new TreeNode(
    1,
    new TreeNode(
        2,
        null,
        new TreeNode(3)),
    new TreeNode(
        2,
        null,
        new TreeNode(3)));*/

/*var tree = new TreeNode(
    1,
    new TreeNode(
        0,
        null,
        null),
    null);*/

// Console.WriteLine(new Solution().IsSymmetric(tree));

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        bool CheckNode(TreeNode nodeLeft, TreeNode nodeRight)
        {
            if (nodeLeft.val != nodeRight.val)
            {
                return false;
            }

            if (nodeLeft.left != null && nodeRight.right != null)
            {
                if (!CheckNode(nodeLeft.left, nodeRight.right))
                {
                    return false;
                }
            }
            else if (nodeLeft.left != null || nodeRight.right != null)
            {
                return false;
            }

            if (nodeLeft.right != null && nodeRight.left != null)
            {
                if (!CheckNode(nodeLeft.right, nodeRight.left))
                {
                    return false;
                }
            }
            else if (nodeLeft.right != null || nodeRight.left != null)
            {
                return false;
            }

            return true;
        }

        return root.left == null && root.right == null
            ? true
            : root.left == null || root.right == null
                ? false
                : CheckNode(root.left, root.right);
    }
}

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public readonly int val = val;
    public readonly TreeNode? left = left;
    public readonly TreeNode? right = right;
}