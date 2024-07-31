using Dll;
namespace ConsoleAppforDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1=new Class1();
            Class2 obj2=new Class2();

            Console.WriteLine("Enter two numbers :");
            int pn1=Convert.ToInt32(Console.ReadLine());
            int pn2 = Convert.ToInt32(Console.ReadLine());
            obj1.add();
            Console.WriteLine("The add result is :"+obj1.presult);
            obj1.sub();
            Console.WriteLine("The sub  result is :" + obj1.presult);
           // obj1.divide();
           // Console.WriteLine("The divide  result is :" + obj1.presult);
            obj1.mul();
            Console.WriteLine("The mul result is :" + obj1.presult);
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square result is :" + obj2.Square(n));
            Console.WriteLine("The cube result is :" + obj2.cube(n));
            Console.Read();
        }
    }
}