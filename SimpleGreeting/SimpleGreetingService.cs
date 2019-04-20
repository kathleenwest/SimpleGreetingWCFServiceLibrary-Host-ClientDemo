using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleGreeting
{
    /// <summary>
    /// SimpleGreetingService
    /// Implements the SimpleGreetingService Interface
    /// </summary>
    public class SimpleGreetingService : ISimpleGreetingService
    {
        /// <summary>
        /// GreetMe
        /// Implements the interface by returning a simple
        /// greeting to a person's name
        /// </summary>
        /// <param name="name">name (string) of the person</param>
        /// <returns>a greeting(string)</returns>
        public string GreetMe(string name = "Stranger")
        {
            return $"Hello, {name}. Have a wonderful day! - Kathleen";

        } // end of method

    } // end of class
} // end of namespace
