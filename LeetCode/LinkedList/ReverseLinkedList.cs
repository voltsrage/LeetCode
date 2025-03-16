using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class ReverseLinkedList
    {
        /// <summary>
        /// The logic is to reverse a linked list by changing the next pointer of each node to point to the previous node
        /// This is done by keeping track of the previous node, the current node, and the next node
        /// We will loop through the linked list and reverse the current node by changing the next pointer to point to the previous node
        /// We will move the previous node to the current node
        /// We will move the current node to the next node
        /// We will return the previous node, which is the new head of the linked list
        /// The time complexity is O(n), where n is the number of nodes in the linked list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode Execute(ListNode head)
        {
            // If the head is missing just return an null 
            if(head == null)
            {
                return null;
            }

            // Initialize the prev node to null
            ListNode prev = null;

            // Initialize the current node to the head
            ListNode current = head;

            // Loop through the linked list
            while (current != null) 
            {
                // Save the next node, so we don't lose it
                ListNode next = current.next;

                // Reverse the current node
                current.next = prev;

                // Move the prev node to the current node
                prev = current;

                // Move the current node to the next node   
                current = next;
            }

            // Return the prev node, which is the new head
            return prev;
        }
    }
}
