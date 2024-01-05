using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // -	Note:* With C# version 8 we can write method body inside interface
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               - always we can use interface as a base type.
               - all methods are inconplete
            - it does not have constructor, feilds
            - we can not create interface object
           
                        means mere pass A,B,C,D nam ke class he or A ko baki ke class inherite kar rahe he 
                       tab agar muze sab me yek commom method impliment karana ho to me base class me likhunga or 
                       baki class use inherite karenge.

                       but meze every method ke liye alag impliment karana hoga to 
                       me base class ko interface karunga kyuki usme se kuch bhi implement/purforme nahi karana he.
             */

             IA a = new A();
            a.print();
            IA b = new B();
            b.print();

            // yaha interface ke pass kuch bhi nahi he lekin it give us architecture achive

            // advantages :
            // -- interface have many - many advantages
        // 1. lossly coupled achitechture
      // 2. multiple class  inheritance is not possible but multiple class intrface inheritance possible
            
            Console.ReadLine(); 


        }
    }
    // for naming convention interface name prefix with I.
    public interface IA
    {
        // int id; // we can not write feilds in interface
        //  public IA() { }  // interface can not contain constructor
        // public void print(); // interface can not contain access specifier
        // void print() { } // interface can not contain body 
        // in interface we can only method declaration
        void print();
        // so what is purpose/use of interface
        // --> hum classes ko alag -alag implimentation kar sakate he.
        // isme humne signature declare kiya he 
        // so inherite class alag-alag body de sakate he par signature should be same.
        // matalab architecture / signature same rahega.
        // 


        // hum interface ka  object create kar nahi sakate
        // par interface reference variable point to class of object
        
        




    }
    public class A : IA
    {
        public void print()
        {
            Console.WriteLine("ganesh pawar");
        }
    }
    public class B : IA
    {
        public void print()
        {
            Console.WriteLine("suraj pawar");
        }
    }
}
