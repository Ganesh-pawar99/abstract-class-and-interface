using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_implimentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // base type refereence variable can point to derived class object
            // interface ka object nahi bana sakate.

            IA a = new A();
            a.print();

            Console.ReadLine();
        }
    }
    public interface IA
    {
       void print();
    }
    // interface ko use karane ke liye hume usako impliment karana hoga
    // for impliment we need to inherite.
    public class A : IA
    {
        public void print()
        {
            Console.WriteLine("A");
        }
    }
}
