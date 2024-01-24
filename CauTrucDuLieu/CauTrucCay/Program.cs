using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucCay
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchBinaryTree tree = new SearchBinaryTree();
            tree.TaoCay();
            Console.WriteLine("Ket qua duyet cay : ");
            Console.Write("NLR");
            tree.NLR(tree.root);

            Console.Write("\nLNR");
            tree.LNR(tree.root);

            Console.Write("\nLRN");
            tree.LRN(tree.root);

            Console.Write("\nNhap gia tri can tim : ");
            int x = int.Parse(Console.ReadLine());
            TreeNode kq = tree.TimKiem(tree.root,x);
            if(kq == null)
            {
                Console.WriteLine($"{x} khong xuat hien trong cay ");
            }else
            {
                Console.WriteLine($"{x} xuat hien trong cay ");
            }

            Console.ReadLine();
        }
    }
}
