using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class MergeTwoSortedLinkedLists
    {
        // The logic is to merge two sorted linked lists into a single sorted linked list by comparing the nodes of the two lists
        // We will use a dummy node to keep track of the head of the merged list
        // We will use a tail node to keep track of the last node of the merged list
        // We will loop through the two lists and compare the nodes
        // If the first list node is smaller than the second list node, we will append the first list node to the tail
        // If the second list node is smaller than the first list node, we will append the second list node to the tail
        // We will move the tail node to the next node
        // We will move the first list node to the next node if it is smaller
        // We will move the second list node to the next node if it is smaller
        // If the first list is missing, we will append the second list to the tail
        // If the second list is missing, we will append the first list to the tail
        // We will return the dummy node.next, which is the head of the merged list
        // The time complexity is O(n + m), where n is the number of nodes in the first list and m is the number of nodes in the second list
        public static ListNode Execute(ListNode list1, ListNode list2)
        {
            // If the first list is missing just return the second list
            if (list1 == null)
            {
                return list2;
            }

            // If the second list is missing just return the first list
            if (list2 == null)
            {
                return list1;
            }

            // Initialize the dummy node
            var dummy = new ListNode();

            // Initialize the tail node, which will be used to append the nodes
            var tail = dummy;

            while (list1 != null && list2 != null)
            {
                // If the first list node is smaller than the second list node
                if (list1.val < list2.val)
                {
                    // Append the first list node to the tail
                    tail.next = list1;

                    // Move the first list node to the next node
                    list1 = list1.next;
                }
                else
                {
                    // Append the second list node to the tail
                    tail.next = list2;

                    // Move the second list node to the next node
                    list2 = list2.next;
                }

                // Move the tail node to the next node
                tail = tail.next;
            }

            // If the first list is missing just append the second list
            if (list1 != null)
            {
                tail.next = list1;
            }

            // If the second list is missing just append the first list
            if (list2 != null)
            {
                tail.next = list2;
            }

            // Return the dummy node, which is the head of the merged list
            return dummy.next;
        }
    }
}