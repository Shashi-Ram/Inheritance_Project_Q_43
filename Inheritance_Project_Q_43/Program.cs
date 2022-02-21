using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project_Q_43
{
    //Q43 Create 3 classes A,B and C and make add() in A, mult() in B and Sub() in C
    //and invoke all method using one object using Inheritance.
    class A
    {
        public double Num1;
        public double Num2;
        public void common()
        {
            Console.Write("Enter First Number : ");
            this.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Number : ");
            this.Num2 = Convert.ToInt32(Console.ReadLine());
        }

        public double Add()
        {
            //common();
            double Total = Num1 + Num2;
            Console.WriteLine("Addition is : " + Total);
            return Total;
        }
    }
    class B:A
    {
        public double Mult()
        {
            //common();
            double Total = Num1 * Num2;
            Console.WriteLine("Multiplication  is : " + Total);
            return Total;
        }
    }
    class C:B
    {
       
        public double Sub()
        {
            //common();
            double Total = Num1 - Num2;
            Console.WriteLine("Substraction is : " + Total);
            return Total;
        }

    }
    class print:C
    {
        public void printAll()
        {
            common();
            Console.WriteLine("\n....................\n");
            Console.WriteLine("Result......\n");
            Add();
            Mult();
            Sub();
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            print p = new print();
            p.printAll();
            Console.ReadLine();
            
        }
    }
}
