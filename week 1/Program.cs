using System.ComponentModel;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * here i will print my infomation using String interpolation : 
             */
            string Name;
            Name = "Elham";
            int Age;
            Age = 25;
            string Job = "Teacher";
            Console.WriteLine($"My name is{Name} Iam {Age}  my Job is {Job }");



            // dinamic it will print the last value

            dynamic snt = "Hello word";
            snt = 5;
            snt = -2;
            Console.WriteLine(snt );

            //Comparison Operators Examples

            int o = 9;
            int h = 6;
            bool equal = o == h;
            bool notequal = o != h;
            bool graterthan = o > h;
            bool lessthan = o < h;
            Console.WriteLine( equal);
            Console.WriteLine(notequal);
            Console.WriteLine(graterthan);
            Console.WriteLine(lessthan);

            Console.WriteLine( );

            //  Examples xor operator
            Console.WriteLine(true ^ true);    // output: False becasue similarity 
            Console.WriteLine(true ^ false);   // output: True because different
            Console.WriteLine(false ^ true);   // output: True because different
            Console.WriteLine(false ^ false);  // output: False becasue similarity 
        }
    }
}