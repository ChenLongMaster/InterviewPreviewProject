using InterveiwPreview.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterveiwPreview.Functions.Algorithm
{
    public class BinaryTree
    {
        public TreeNode root;

        public BinaryTree()
        {
            this.root = null;
        }

        public void InsertTreeFromList (int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                InsertTree(arr[i]);
            }
        }

        public void InsertTree(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else
            {
                root.Insert(value);
            }
        } 

        public TreeNode Search(int searchNodeValue, TreeNode root = null)
        {
            
            TreeNode currentNode = root == null ? this.root : root;

            if(searchNodeValue == currentNode.data)
            {
                return root;
            }

            if(searchNodeValue < currentNode.data)
            {
                currentNode = Search(searchNodeValue, currentNode.left);
            }
            else
            {
                currentNode = Search(searchNodeValue, currentNode.right);
            }

            return currentNode;
        }

        //private bool Remove(TreeNode<T> node, T value)
        //{
        //    if (node == null)
        //        return false;

        //    if (node.Value.Equals(value))
        //    {
        //        if (node.IsLeaf) // no children
        //        {
        //            if (node.Parent.LeftChild == node)
        //                node.Parent.LeftChild = null;
        //            else
        //                node.Parent.RightChild = null;

        //            node.Parent = null;
        //        }
        //        else if (node.HasLeftChild && node.HasRightChild)   // 2 children
        //        {
        //            // Tìm successor node
        //            Y2BinaryTreeNode<T> replacementNode = node.RightChild;

        //            while (replacementNode.HasLeftChild)
        //            {
        //                replacementNode = replacementNode.LeftChild;
        //            }
        //            node.Value = replacementNode.Value;

        //            Remove(replacementNode, replacementNode.Value);
        //        }
        //        else    // one child
        //        {
        //            Y2BinaryTreeNode<T> subNode;

        //            if (node.HasLeftChild)
        //                subNode = node.LeftChild;
        //            else
        //                subNode = node.RightChild;

        //            if (Root == (subNode))
        //                Root = subNode;

        //            subNode.Parent = node.Parent;

        //            if (node.Parent.LeftChild == node)
        //                node.Parent.LeftChild = subNode;
        //            else
        //                node.Parent.RightChild = subNode;
        //        }
        //        Count--;
        //        return true;
        //    }
        //    else
        //    {
        //        if (node.Value.CompareTo(value) > 0)
        //            return Remove(node.LeftChild, value);
        //        else
        //            return Remove(node.RightChild, value);
        //    }
        //}
    }
}
