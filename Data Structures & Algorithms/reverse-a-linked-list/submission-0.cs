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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null)
        {
            return head;
        }
        var temp = head;
        List<int> list = new();
        while (temp != null)
        {
            list.Add(temp.val);
            temp = temp.next;
        }

        ListNode newHead = new ListNode(list[^1]);
        temp = newHead;
        for (int i = 2; i <= list.Count; i++)
        {
            // temp.val = ;
            temp.next = new ListNode(list[^i]);
            temp = temp.next;
        }
        return newHead;
    }
}
