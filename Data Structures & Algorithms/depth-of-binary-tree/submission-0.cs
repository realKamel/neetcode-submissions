/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxDepth(TreeNode root) {
                if (root is null)
        {
            return 0;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var levels = 0;
        while (queue.Count > 0)
        {
            var currentSize = queue.Count;
            for (var i = 0; i < currentSize; i++)
            {
                var node = queue.Dequeue();
                if (node.left is not null)
                    queue.Enqueue(node.left);
                if (node.right is not null)
                    queue.Enqueue(node.right);
            }
            levels++;
        }
        return levels;
    }
}