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
        ListNode head = default;
        if(list1 is not null && list2 is not null )
        {
            if(list1.val < list2.val)
                {
                    head = list1;
                    list1 = list1.next;
                }
                else
                {
                    head = list2;
                    list2 = list2.next;
                }
        }else if (list2 is not null)
        {
            return list2;
        }else
        {
            return list1;
        }
        var temp = head;
        while(list1 is not null && list2 is not null)
        {
            if(list1.val < list2.val)
            {
                temp.next = list1;
                list1 = list1.next;
            }
            else
            {
                temp.next = list2;
                list2 = list2.next;
            }
            temp=temp.next;
        }
        while(list1 is not null)
        {
            temp.next = list1;
            list1 = list1.next;
            temp= temp.next;
        }
        while(list2 is not null)
        {
            temp.next = list2;
            list2 = list2.next;
            temp= temp.next;
        }
        return head;
    }
}