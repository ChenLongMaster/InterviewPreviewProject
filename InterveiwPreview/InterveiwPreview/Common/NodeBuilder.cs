using System;
using System.Collections.Generic;
using System.Text;

namespace InterveiwPreview.Common
{
    public class NodeBuilder
    {
        public static ListNode NodeBuilderReverse(int[] nodeArray,int post)
        {
            ListNode nextNode = new ListNode(nodeArray[post]);
            ListNode rootNode = null;
            for (int i = nodeArray.Length - 1; i >= 0; i--)
            {
                rootNode = new ListNode(nodeArray[i]);
                rootNode.next = nextNode;
                nextNode = rootNode;
            }
            return rootNode;
        }
    }
}
