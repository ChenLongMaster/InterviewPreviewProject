using InterveiwPreview.Common;
using System.Collections.Generic;

namespace InterveiwPreview.Functions
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> nodeSeen = new HashSet<ListNode>();
            while (head != null)
            {
                if (nodeSeen.Contains(head))
                {
                    return true;
                }
                nodeSeen.Add(head);
                head = head.next;
            }
            return false;
        }
    }
}
