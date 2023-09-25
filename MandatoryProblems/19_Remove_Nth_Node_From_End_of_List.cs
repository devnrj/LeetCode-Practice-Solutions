/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null || n <= 0) {
            return null;
        }

        ListNode hare = head, tortoise = head;

        for (int i = 0; i < n; i++) {
            if (hare == null) {
                break;
            }
            hare = hare.next;
        }

        if (hare == null) {
            return head.next;
        }

        while (hare.next != null) {
            hare = hare.next;
            tortoise = tortoise.next;
        }

        tortoise.next = tortoise.next.next;

        return head;

    }
}