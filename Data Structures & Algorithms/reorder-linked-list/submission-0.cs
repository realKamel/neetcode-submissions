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
    public void ReorderList(ListNode head) {
                if (head is null || head.next is null)
        {
            return;
        }
        var tempHead = head;
        var backingList = new List<ListNode>();

        while (tempHead is not null)
        {
            backingList.Add(tempHead);
            tempHead = tempHead.next;
        }
        var writer = head;
        var pointer = 1;
        var side = true;
        for (var i = 0; i < backingList.Count; i++)
        {
            if (side)
            {
                writer.next = backingList[^pointer];
                writer = writer.next;
            }
            else
            {
                writer.next = backingList[pointer];
                writer = writer.next;
                pointer++;
            }
            side = !side;
        }
        writer.next = null;
        while (head is not null)
        {
            System.Console.Write(head.val);
            head = head.next;
        }
    }
}
