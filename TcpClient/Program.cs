using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcpClient.SimpleGreetingServiceReference;

namespace TcpClient
{
    /// <summary>
    /// TcpClient
    /// A simple console application that tests the
    /// SimpleGreetingService by calling the service
    /// using the tcp binding protocol. It prompts the
    /// user to enter their name, call the service,
    /// and return the results from the service to the
    /// user on the console window
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method entry to the program
        /// </summary>
        /// <param name="args">No Input arguments used</param>
        static void Main(string[] args)
        {
            SimpleGreetingServiceClient proxy = new SimpleGreetingServiceClient("netTcpBinding_ISimpleGreetingService");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Calling the Simple Greeting Service...");
            string greeting = proxy.GreetMe(name);
            Console.WriteLine(greeting);

            // Wait on the User Input
            Console.WriteLine();
            Console.WriteLine("Press Enter<> to close the TcpClient Test application...");
            Console.ReadLine();
        } // end of main method
    } // end of class
}
