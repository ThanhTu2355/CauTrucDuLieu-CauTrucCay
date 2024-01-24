using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucCay
{
    class SearchBinaryTree
    {
        public TreeNode root;

        public SearchBinaryTree()
        {
            root = null;
        }
        //duyet cay
        public void NLR(TreeNode root)
        {
            if(root !=null)
            {
                Console.Write($"{root.info} ");
                NLR(root.left);
                NLR(root.right);
            }
        }
        public void LNR(TreeNode root)
        {
            if (root != null)
            {
                LNR(root.left);
                Console.Write($"{root.info} ");
                LNR(root.right);
            }
        }
        public void LRN(TreeNode root)
        {
            if (root != null)
            {
                LRN(root.left);
                LRN(root.right);
                Console.Write($"{root.info} ");
            }
        }
    }
}
