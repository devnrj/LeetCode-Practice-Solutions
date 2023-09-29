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
    public bool IsSymmetric(TreeNode root) {
        if(root==null){
            return false;
        }

        return IsSymmetric(root.left,root.right);
    }

    bool IsSymmetric(TreeNode r1, TreeNode r2){
        if(r1 == null || r2 == null){
            return r1 == r2;
        }
        if(r1.val != r2.val){
            return false;
        }

        return IsSymmetric(r1.left,r2.right) && IsSymmetric(r2.left,r1.right);
    }
}