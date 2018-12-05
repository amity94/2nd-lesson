using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            question1();
        }

        private static void question1()
        {
            Console.WriteLine("enter number of students in class");
            int students = int.Parse(Console.ReadLine());

            int[] gradesarray = new int[students];
            for (int i = 0; i < gradesarray.Length; i++)
            {
                gradesarray[i] = int.Parse(Console.ReadLine());
            }


            int sum = 0;
            for (int i = 0; i < gradesarray.Length; i++)
            {
                sum = sum + gradesarray[i];

            }
            double avarage = sum / gradesarray.Length;
            Console.WriteLine("the avarage was" + avarage);
        }

         






    }

}
