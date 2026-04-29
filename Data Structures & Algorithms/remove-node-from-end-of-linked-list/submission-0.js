/**
 * Definition for singly-linked list.
 * class ListNode {
 *     constructor(val = 0, next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

class Solution {
    /**
     * @param {ListNode} head
     * @param {number} n
     * @return {ListNode}
     */
    removeNthFromEnd(head, n) {
         let fast = head,
    delayedSteps = 0;

  while (fast && fast.next !== null && delayedSteps < n) {
    fast = fast.next;
    delayedSteps++;
  }
  if (delayedSteps === 0) {
    // means that we have one node and will be removed
    // if it pass this cond we have 1 or more
    return null;
  }
  if (delayedSteps === n - 1) {
    return head.next;
  }
  let slow = head;
  while (fast && fast.next !== null) {
    fast = fast.next;
    slow = slow.next;
  }
  if (slow?.next) {
    slow.next = slow.next.next;
  }
  return head;
    }
}
