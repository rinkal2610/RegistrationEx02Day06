using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppRegistrationExc
{
    public class OurRegistrationExc:Exception
    {
        public OurRegistrationExc(string msg):base(msg) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string username;
            string password;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter user name");
            username = Console.ReadLine();
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            Registration(name,username, password);
            Console.ReadKey();
        }
        public static void Registration(string name,string username, string password) {
            try
            {
                if (username.Length >= 6 && password.Length >= 6)
                    Console.WriteLine($"Hi {name} successfully registered!");
                else
                    Console.WriteLine($"invalid username and password!");
            }
            catch(OurRegistrationExc ex) 
            {
                Console.WriteLine("Exception: "+ex.Message);
            }
            catch (Exception e) { Console.WriteLine("Error: "+e.Message); }
            finally {
                Console.WriteLine("end of code");
                Console.ReadKey();
            }
        }
    }
}
