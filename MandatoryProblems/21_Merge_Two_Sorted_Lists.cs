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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        ListNode head = null,temp = null;
        while(list1!=null || list2 != null){
            if(list2 == null || (list1 != null && list1.val <= list2.val)){
                if(head==null){
                    head = new ListNode(list1.val,null);
                    temp = head;
                }else{
                    temp.next = new ListNode(list1.val,null);
                    temp = temp.next;
                }
                list1 = list1.next;
            }else{
                if(head==null){
                    head = new ListNode(list2.val,null);
                    temp = head;
                }else{
                    temp.next = new ListNode(list2.val,null);
                    temp = temp.next;
                    
                }
                list2 = list2.next;
            }
        }

        return head;
    }
}