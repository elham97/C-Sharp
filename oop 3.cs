using System.Security.Cryptography.X509Certificates;

namespace oop3
{
    internal class Program
    {
        // creat method
        // cnt= size ,, pattren = what print like * ^# 
        

        public static void printLine( int cnt, string pattren)
        {
           for(int i=0; i <= cnt; i++ )
            {
                Console.Write( pattren); ;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("please insert the first name");
            x = int.Parse(Console.ReadLine());
            printLine(7, "^*");

            Console.WriteLine("please insert the secind name");
            y = int.Parse(Console.ReadLine());
            printLine(5,"@");

            Console.WriteLine("please insert the first name");
            z = int.Parse(Console.ReadLine());
            printLine(9, "$"); 
        }
    }
} 

        // creat method
        // cnt= size ,, pattren = what print like * ^# 

  /*      
public static void printLine( int cnt= 4, string pattren= "$$")
{
   for(int i=0; i <= cnt; i++ )
    {
        Console.Write( pattren); ;
    }
    Console.WriteLine();
}
static void Main(string[] args)
{
    int x, y, z;
    Console.WriteLine("please insert the first name");
    x = int.Parse(Console.ReadLine());
    printLine(pattren: "^*");

    Console.WriteLine("please insert the secind name");
    y = int.Parse(Console.ReadLine());
    printLine();

    Console.WriteLine("please insert the first name");
    z = int.Parse(Console.ReadLine());
    printLine(12, "@");
}
}
} 
        /* swap ****************
        public static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            swap(ref x, ref y);
            Console.WriteLine("A is" + x);
            Console.WriteLine("A is" + y);
        } */
        /*
        public static void SumMul(int x, int y, out int s, out int m)
        {
            s = x + y;
            m = x * y;
        static void Main(string[] args)
            {
                int a = 6, b = 7, Sresult, Mresult;
                SumMul(a, b, out Sresult, out Mresult);
                Console.WriteLine($"sum : {Sresult}");
                Console.WriteLine($"Multiplication : {Mresult}");
                


      /*  
        static void Main(string[] args)
        { 
            calculator calc = new calculator();
            int a = 10, b = 15;
            double c = 10.6, d = 12.5;
            string f = "welcome", e = "student";
            Console.WriteLine(calc.add(a, b));
            Console.WriteLine(calc.add(c, d));
            Console.WriteLine(calc.add(f, e));
            
            calculator calc = new calculator();
            int a = 10, b = 15;
            double c = 10.6, d = 12.5;
            string f = "welcome", e = "student";
            Console.WriteLine(calc.add(a, b));
            Console.WriteLine(calc.add(c, d));
            Console.WriteLine(calc.add(f, e)); 

            {
               /* person per = new person();
                per.Id = 1;
                per.age = 20;
                per.firstName = "Elham";
                per.lastName = "Alhinai"; */
                
            

       


