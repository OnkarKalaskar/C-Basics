using C_BasicsPractice;

namespace DelegatePractice
{
    public delegate void VoidDelegate();

    public delegate int CalculateDelegate(int num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //DELEGATE SIMPLE
            //delegate instantiation
            VoidDelegate del = Print1;
            del += Print2;
            TrialClass.callingDelegate(del);

            //DELEGATE SIMPLE PARAMETRISED
            //delegate parameterised
            CalculateDelegate calDel = calSum;
     
            Console.WriteLine("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());

            //calling method where delegate is called
            TrialClass.callingAddition(num1, num2, calSum);

            //DELEGATE WITH OOPS
            Student student = new Student(1, "gdf", "sdfs", "d");
            DelegateMethods delegates = new DelegateMethods();
            delegates.CallingShowDetailsMethod(student);

            Console.ReadLine();
        }

        private static void Print1()
        {
            Console.WriteLine("method 1 called!!");
        }

        private static void Print2()
        {
            Console.WriteLine("method 2 called!!");
        }

        public static int calSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    public static class TrialClass
    {
        public static void callingDelegate(VoidDelegate voidDel)
        {
            voidDel();
        }

        public static void callingAddition(int num1, int num2, CalculateDelegate calDel)
        {
            Console.WriteLine("Addition is : " + calDel(num1, num2));
        }

       

    }

}
