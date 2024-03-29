﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TRDServiceTester.TRDWCFServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TRDWCFServices.ICanvasserPortalServices")]
    public interface ICanvasserPortalServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICanvasserPortalServices/isUserCredentailsValid", ReplyAction="http://tempuri.org/ICanvasserPortalServices/isUserCredentailsValidResponse")]
        bool isUserCredentailsValid(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICanvasserPortalServices/isUserCredentailsValid", ReplyAction="http://tempuri.org/ICanvasserPortalServices/isUserCredentailsValidResponse")]
        System.Threading.Tasks.Task<bool> isUserCredentailsValidAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICanvasserPortalServices/testDBConnections", ReplyAction="http://tempuri.org/ICanvasserPortalServices/testDBConnectionsResponse")]
        string testDBConnections(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICanvasserPortalServices/testDBConnections", ReplyAction="http://tempuri.org/ICanvasserPortalServices/testDBConnectionsResponse")]
        System.Threading.Tasks.Task<string> testDBConnectionsAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICanvasserPortalServicesChannel : TRDServiceTester.TRDWCFServices.ICanvasserPortalServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CanvasserPortalServicesClient : System.ServiceModel.ClientBase<TRDServiceTester.TRDWCFServices.ICanvasserPortalServices>, TRDServiceTester.TRDWCFServices.ICanvasserPortalServices {
        
        public CanvasserPortalServicesClient() {
        }
        
        public CanvasserPortalServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CanvasserPortalServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CanvasserPortalServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CanvasserPortalServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool isUserCredentailsValid(string username, string password) {
            return base.Channel.isUserCredentailsValid(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> isUserCredentailsValidAsync(string username, string password) {
            return base.Channel.isUserCredentailsValidAsync(username, password);
        }
        
        public string testDBConnections(string value) {
            return base.Channel.testDBConnections(value);
        }
        
        public System.Threading.Tasks.Task<string> testDBConnectionsAsync(string value) {
            return base.Channel.testDBConnectionsAsync(value);
        }
    }
}
