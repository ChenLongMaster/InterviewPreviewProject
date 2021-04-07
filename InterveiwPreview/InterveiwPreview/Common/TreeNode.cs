using System;
using System.Collections.Generic;
using System.Text;

namespace InterveiwPreview.Common
{
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value)
        {
            data = value;
            left = null;
            right = null;
        }

        public void Insert(int value)
        {
            if(value > data)
            {
                if(right == null)
                {
                    right = new TreeNode(value);
                }
                else
                {
                    right.Insert(value);
                }
            }
            else
            {
                if (left == null)
                {
                    left = new TreeNode(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
        }
    }
}