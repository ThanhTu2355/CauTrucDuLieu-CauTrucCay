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
        //them nut vao cay nhi phan tim kiem
        public void ThemNode(ref TreeNode root, int x)
        {
            if(root == null)
            {
                TreeNode p = new TreeNode(x);
                root = p;
            }else if(root.info>x)
                ThemNode(ref root.left, x);
            else if(root.info<x)
                ThemNode(ref root.right, x);
        }
        //phuong thuc tao cay
        public void TaoCay()
        {
            Console.Write("Cho biet so nut trong cay : ");
            int n = int.Parse(Console.ReadLine());
            for(int i= 1; i<=n; i++)
            {
                Console.Write("Nhap gia tri node thu {0} :",i);
                int x = int.Parse(Console.ReadLine());
                ThemNode(ref root, x);
            }
        }
        //tim kiem nut co gia tri x trong cay
        public TreeNode TimKiem(TreeNode root, int x)
        {
            TreeNode kq = null;
            if (root != null) 
            {
                if (root.info == x)
                    kq = root;
                else if(root.info>x)
                    kq=TimKiem(root.left, x);
                else if (root.info<x)
                    kq = TimKiem(root.right, x);
            }
            return kq;
        }
    }
}
