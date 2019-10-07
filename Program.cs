using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace stackProblemSolution
{
    public class Program
    {

        static void Main(string[] args)
        {
            StackOperation MyClass = new StackOperation();
            //using (var db = new Model2())
            //{
            //    //var st = new stack();
                
            //    stack s = new stack()
            //    {
            //        elementlists = MyClass.elementlists
            //    };
            //    db.stacks.Add(s);
            //    db.SaveChanges();
            //}
            Console.WriteLine("Enter the number of operations to be performed\n");
            EnterTheInput: int N = Convert.ToInt32(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("Enter the valid input");
                goto EnterTheInput;
            }

            //List<int> listElements = new List<int>();

            

            for (int index = 0; index < N; index++)
            {
                Console.WriteLine("1.enter one to add an element \n");
                Console.WriteLine("2.enter two to remove the element on top \n");
                Console.WriteLine("3.enter three to print maximum element in the stack\n");
                int option = int.Parse(Console.ReadLine());
                // enterTheUserInput();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter the element to add");
                        var val = Console.ReadLine();
                        MyClass.Push(Int32.Parse(val));
                        break;
                    case 2:
                        Console.WriteLine("top element is deleted");
                        MyClass.Pop();        //using list
                        break;
                    case 3:
                        Console.WriteLine("maximum element is {0}", MyClass.printMaximumElement());//to find maximum element in the stack
                            break;
                    default:
                        Console.WriteLine("enter valid operation");
                        break;
                }
            }
            

            Console.ReadKey();
        }
    }

    //public class stack
    //{
    //    public List<int> listElements { get; set; }

    //}
    //public class stackContext:DbContext
    //{
    //    public stackContext() :base()
    //    {

    //    }
    //    public DbSet<stack> stacks { get; set; }
    //}
}
