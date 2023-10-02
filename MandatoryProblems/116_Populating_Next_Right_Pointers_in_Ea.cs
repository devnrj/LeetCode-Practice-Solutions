/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Queue<Node> queue = new Queue<Node>();
        if(root!=null){
            queue.Enqueue(root);
        }
        while(queue.Count>0){
            int count = queue.Count;
            for(int i = count ; i>0; i--){
                Node node = queue.Dequeue();
                if(i>1){
                    node.next = queue.Peek();
                }
                if(node.left!=null){
                    queue.Enqueue(node.left);
                }
                if(node.right!=null){
                    queue.Enqueue(node.right);
                }
            }
        }

        return root;
    }
}