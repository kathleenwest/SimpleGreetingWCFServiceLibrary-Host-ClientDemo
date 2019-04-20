using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using SimpleGreeting;

namespace ServiceHostApplication
{
    /// <summary>
    /// ServiceHostApplication
    /// The ServiceHostApplication is a simple console application
    /// that manages the start and stop of the SimpleGreetingService
    /// Instead of using IIS to manage the service, this application
    /// spins up an instance using references to the simple greeting
    /// service library and the framework service model libraries.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry method to the Program
        /// </summary>
        /// <param name="args">No input arguments used</param>
        static void Main(string[] args)
        {
            // Defined ServiceHost object outside the Try Block
            ServiceHost host = null;

            // trys to start the SimpleGreetingService
            try
            {
                // Spins up the SimpleGreetingService
                Console.WriteLine("Service Starting...");
                host = new ServiceHost(typeof(SimpleGreetingService));
                host.Open();
                Console.WriteLine("Service Started...");

                // Wait for the user to stop the service
                Console.WriteLine("Press Enter<> to Stop Service...");
                Console.ReadLine();
            } // end of try

            // catches exceptions
            catch (Exception ex)
            {
                Console.WriteLine("An error occured {0}", ex.Message);
            } // end of catch

            // Closes the Service Properly
            finally
            {
                if(host != null)
                {
                    host.Close();
                }
            } // end of finally

            // Wait for User to Close the Application
            Console.WriteLine("Press Enter<> to Quit...");
            Console.ReadLine();
        } // end of main method

    } // end of class
} // end of namespace
