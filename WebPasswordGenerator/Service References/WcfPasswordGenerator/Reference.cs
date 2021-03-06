﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeradorSenhasWeb.WcfPasswordGenerator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfPasswordGenerator.IPasswordGenerator")]
    public interface IPasswordGenerator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPasswordGenerator/GetPasswords", ReplyAction="http://tempuri.org/IPasswordGenerator/GetPasswordsResponse")]
        string[] GetPasswords(string characters, int minSize, int maxSize, int numberPasswords);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPasswordGeneratorChannel : GeradorSenhasWeb.WcfPasswordGenerator.IPasswordGenerator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PasswordGeneratorClient : System.ServiceModel.ClientBase<GeradorSenhasWeb.WcfPasswordGenerator.IPasswordGenerator>, GeradorSenhasWeb.WcfPasswordGenerator.IPasswordGenerator {
        
        public PasswordGeneratorClient() {
        }
        
        public PasswordGeneratorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PasswordGeneratorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PasswordGeneratorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PasswordGeneratorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetPasswords(string characters, int minSize, int maxSize, int numberPasswords) {
            return base.Channel.GetPasswords(characters, minSize, maxSize, numberPasswords);
        }
    }
}
