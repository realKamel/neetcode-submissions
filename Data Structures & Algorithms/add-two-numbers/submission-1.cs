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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        long result1 = 0;
long result2 = 0;
int multiplier = 1;
while (l1 is not null)
{
	result1 = result1 + (l1.val* multiplier) ;
	multiplier *= 10;
	l1 = l1.next;
}
multiplier = 1;
while (l2 is not null)
{
	result2 = result2 + (l2.val * multiplier);
	multiplier *= 10;
	l2 = l2.next;
}
result1 += result2;
if(result1 == 0)
{
    return new ListNode(0);
}
var digits = new List<int>();
while (result1 > 0)
{
	digits.Add((int)result1 % 10);
	result1 /= 10;
}
var head = new ListNode(digits[0]);
var temp = head;
for (int i = 1; i < digits.Count; i++)
{
	temp.next = new ListNode(digits[i]);
	temp = temp.next;
}
return head;
    }
}
