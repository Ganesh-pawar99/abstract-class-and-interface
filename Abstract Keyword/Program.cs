using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstract keyword 
            /*
                     abstrcat means a incomplete 
                     -- we can write abstract is a class or method.
                      abstract class:
                      - we can not crrate object of abstract class.
                      - it is always used as a base class.

                     abstract method:
                     - it is a incomplete method.
                     - we can only write declaration we can not write a body to a abstract method (only signature)
                     - t is mendatory to override the abstract method in derived class.

             */
            //Customer sc= new Customer(); 
            // we can't create instance/object of abstract class
            // because it is a incomplete
            // abstract method only we can write inside the abstract class 
            // but abstract class contain both abtract + non abstract method 
            // abstract method == without body
            // non- abstract method == with body.

            // so we do like that 
            Customer sc = new SiverTicket();
            sc.GetAllShowTime();
            sc.TicketAmount();
            Customer sc2 = new PlatinumTicket();
            sc2.GetAllShowTime();
            sc2.TicketAmount();
            Customer sc3 = new GoldenTicket();
            sc3.GetAllShowTime();
            sc3.TicketAmount();

Console.ReadLine();

        }
    }
    public abstract class Customer
    {
        // public void TicketAmount(); // when we do this then compiler says you must declare body
        // becacuse it is not marked as abstract,extern and partial


        // when we create derived class object then automatically call base class constructor
        public Customer (){
            Console.WriteLine(" customer constructor called");}
        public abstract void TicketAmount(); // 'Customer.TicketAmount()' is abstract but it is
                                             // contained in non-abstract type customer
                                             // so for that we can declare class as abstract
    
    // then compiler give the of overloading classes
    // it says that classes are not implement in inherited abstract class 
    // so it is mendatory to override abstract method in derived class.
     
        public void GetAllShowTime()
        {
            Console.WriteLine("\nall time is follows :\n" +
                "9.0 am to 12 am\n" +
                "12 pm to 3 pm\n" +
                "3 pm to 6 pm\n" +
                "6pm to 9 pm\n " +
                "9 pm to 12 pm");
        }
    
    
    } 
    public class SiverTicket :Customer {

        public override void TicketAmount()
        {
            Console.WriteLine("ticket printed for silverticket customer");
        }

    }
    public class GoldenTicket : Customer {

        public override void TicketAmount()
        {
            Console.WriteLine("ticket printed for goldenticket coustomer");
        }



    }
    public class PlatinumTicket : Customer
    {
        public override void TicketAmount()
        {
            Console.WriteLine("ticket printed for platinumticket coustomer");
        }
    }
}
