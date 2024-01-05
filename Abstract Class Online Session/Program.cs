using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Online_Session
{

    /*public abstract class student


    {
        // public abstract void show();  // there it gives error because abstract method contain in only
        // abstract class so make student as a abstract
        //   public abstract void show() { } // it also give error because abstract not contain a body

    }*/



  public  abstract class Person
    {
        public string firstname;
        public string lastname;
        public int age;
        // hum constants bhi abstract me likh sakate he 
        public static string InstituteName = "Zeal college";
       private long _mobileNumber;
        public long MyProperty
        {
            set
            {
                this._mobileNumber = value;
            }
            get
            {
                return this._mobileNumber;
                // hum abstract class me property bhi likh sakate he.
                
            }
            // abstract class can have constructor or distructor.
           
        }

        public abstract void PrintDetail();
       
        // in abstract class there are we can create abstract + concrete method
        // so ye abstract class ko body nahi he to jab hum isko student me implement karane jayenge 
        // tab ye nahi hoga kyuki usake liye hume student ko bhi abstract banana padega or hum vo karate je
        // tab hum fir uska object create nahi kar sakate.
        // isi liye hum ise drived class me body dete he
        // body dene ke bad hume mendatory us method ko override karana he.

    }


    // here we do hirarachical inheritance   A
    //                                      /  \
    //                                     B    C


  public  class Student  : Person{
        // so we can declare its oen fields 
        public int rollnumber;
        public int fees;
    public override void PrintDetail()
        {
            Console.WriteLine($"fullname of student is : {this.firstname}  {this.lastname}");
            Console.WriteLine($" student age is {age} " );
            Console.WriteLine($"student mobile number is {this.MyProperty}");
            Console.WriteLine($" student rollnumber is {rollnumber} and fees  : {fees}");
        }


    }
   public class Teacher : Person{
        public string qualification;
        public int salary;
        public override void PrintDetail()
        {
            Console.WriteLine($"fullname of Teacher is : {this.firstname}  {this.lastname}");
            Console.WriteLine($" teacher age is {age} ");
            Console.WriteLine($"teacher mobile number is {this.MyProperty}");
            Console.WriteLine($"teacher Qualification is {qualification} ");
            Console.WriteLine($"teacher salaray is {salary}");

        }

    }
   










    internal class Program
    {
        static void Main(string[] args)
        {


            /*  
             Q. hume class ko abstract banane ki jarurat kyu padati he?
            -> ex: yek school he or school me teacher, student honge to unme kkuch coomom dfeilds hogi 
               jaise mobile number,subject,rollnumber,gender tab hume ye do no me bhi likhana padega 
            par hum yek person nam ka class create karenge or usme ye common feilds likh lenge

                                  PERSON (base class)
                                  / \
                                 /   \ 
                                /     \
                           student     teacher

            isme hum person ko student and teacher me inherite kar denge  tab vo coomon feild child class 
             ko accesesible hongi
            but person ka hum object nahi create kar sakate , kyuki person yek to student he ya teacher
            so hum pweson ko abstract banayenge kyuki uska object nahi banata.



             */

            //   student sc= new student();  we can not create object of abstract class.

            Student ganesh = new Student();
            ganesh.firstname = "ganesh";
            ganesh.lastname = "pawar";
            ganesh.age = 24;
            ganesh.MyProperty = 9011154265;
            ganesh.rollnumber = 1;
            ganesh.fees=50000;
            ganesh.PrintDetail();
            Console.WriteLine("---------------------------------");
            
            Teacher suraj= new Teacher();
            suraj.firstname = "suraj";
            suraj.lastname = "pawar";
            suraj.age = 26;
            suraj.MyProperty = 8698685512;
            suraj.qualification = "BE.Machanical";
            suraj.salary = 85000;
            suraj.PrintDetail();
            Console.ReadLine();
           
       
    }
    }
}
