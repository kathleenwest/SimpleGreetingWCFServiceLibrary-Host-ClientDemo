﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TcpClient.SimpleGreetingServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimpleGreetingServiceReference.ISimpleGreetingService")]
    public interface ISimpleGreetingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleGreetingService/GreetMe", ReplyAction="http://tempuri.org/ISimpleGreetingService/GreetMeResponse")]
        string GreetMe(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleGreetingService/GreetMe", ReplyAction="http://tempuri.org/ISimpleGreetingService/GreetMeResponse")]
        System.Threading.Tasks.Task<string> GreetMeAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleGreetingServiceChannel : TcpClient.SimpleGreetingServiceReference.ISimpleGreetingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleGreetingServiceClient : System.ServiceModel.ClientBase<TcpClient.SimpleGreetingServiceReference.ISimpleGreetingService>, TcpClient.SimpleGreetingServiceReference.ISimpleGreetingService {
        
        public SimpleGreetingServiceClient() {
        }
        
        public SimpleGreetingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleGreetingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleGreetingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleGreetingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GreetMe(string name) {
            return base.Channel.GreetMe(name);
        }
        
        public System.Threading.Tasks.Task<string> GreetMeAsync(string name) {
            return base.Channel.GreetMeAsync(name);
        }
    }
}
