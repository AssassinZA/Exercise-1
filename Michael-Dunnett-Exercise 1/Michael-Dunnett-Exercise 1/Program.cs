using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael_Dunnett_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Michael D

            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };


            //A.
            Console.WriteLine("Elements that are in both List1 and List2");

            var list3 = list1.Intersect(list2);

            Console.WriteLine(string.Join(" ", list3));
            
            //B.
            Console.WriteLine("\nElements that are in List1 but not List2");

            var list4 = list1.Except(list2).ToArray();

            Console.WriteLine(string.Join(" ", list4));

            //C.
            Console.WriteLine("\nElements that are in List2 but not List1");

            var list5 = list2.Except(list1).ToArray();

            Console.WriteLine(string.Join(" ", list5));


            Console.WriteLine("\nPlease press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}
