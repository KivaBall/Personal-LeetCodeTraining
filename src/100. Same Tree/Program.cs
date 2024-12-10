

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        bool CheckNode(TreeNode? f, TreeNode? s)
        {
            if (f == null && s == null)
            {
                return true;
            }

            if (f == null || s == null)
            {
                return false;
            }

            return f.val == s.val && CheckNode(f.left, s.left) && CheckNode(f.right, s.right);
        }

        return CheckNode(p, q);
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}