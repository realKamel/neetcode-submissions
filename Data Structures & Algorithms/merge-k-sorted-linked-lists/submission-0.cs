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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0)
        {
            return null;
        }
        var queue = new PriorityQueue<int,int>();
        foreach(var l in lists)
        {
            var currentList = l;
            while(currentList is not null)
            {
                queue.Enqueue(currentList.val,currentList.val);
                currentList = currentList.next;
            }
        }
        
        ListNode head = default;
        if(queue.TryDequeue(out var e, out _))
        {
            head = new ListNode(e);
        }
        var temp = head;
        while(queue.TryDequeue(out var value,out _))
        {
            temp.next = new ListNode(value);
            temp = temp.next;
        }
        return head;
    }
}
