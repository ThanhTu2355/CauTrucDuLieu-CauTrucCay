using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucCay
{
    class TreeNode
    {
        public int info;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            info = x;
            left = null;
            right = null;
        }
    }
}
