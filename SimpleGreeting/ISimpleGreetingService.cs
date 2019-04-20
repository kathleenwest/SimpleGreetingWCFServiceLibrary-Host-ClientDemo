using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleGreeting
{
    /// <summary>
    /// SimpleGreeting Interface
    /// Defines the Service Interface
    /// </summary>
    [ServiceContract]
    public interface ISimpleGreetingService
    {
        /// <summary>
        /// GreetMe
        /// A simple service that greets a visitor by name.
        /// </summary>
        /// <param name="name">Name (string) of the person to be greeted</param>
        /// <returns>Greeting + Name (string)</returns>
        [OperationContract]
        string GreetMe(string name);
    } // end of interface

} // end of namepace
