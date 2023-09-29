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
    public bool IsBalanced(TreeNode root) {
        if(root == null){
            return true;
        }
        int lHeight = height(root.left);
        int rHeight = height(root.right);

        if(Math.Abs(lHeight-rHeight)>1){
            return false;
        }

        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    int height(TreeNode root){
        if(root == null){
            return 0;
        }
        int lHeight = height(root.left);
        int rHeight = height(root.right);
        return Math.Max(lHeight,rHeight) +1;
    }
}