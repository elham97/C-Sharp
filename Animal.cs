using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
/*  Base class => Animal ==>> string name , int age , void move()
 *  & derive class => ( cat , dog) 
 * 
 */

namespace Inheritance
{
    class Animal
    {
        public string name;
        public int age;
        public void move() // method move
        {
            Console.WriteLine("Hello animal i am moving");
        }

    }
}
     class Cat : Animal
    {
    public string gender;
        public void sound()
        {
            Console.WriteLine("meaw");
        }

    }

     class dog : Animal
{
    public string category;
    public void sound()
    {
        Console.WriteLine("wofe");
    }
}