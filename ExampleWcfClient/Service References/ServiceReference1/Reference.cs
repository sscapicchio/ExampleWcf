﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExampleWcfClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRecordsKeeper")]
    public interface IRecordsKeeper {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/GetNextAvailableIdentifier", ReplyAction="http://tempuri.org/IRecordsKeeper/GetNextAvailableIdentifierResponse")]
        string GetNextAvailableIdentifier();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/GetNextAvailableIdentifier", ReplyAction="http://tempuri.org/IRecordsKeeper/GetNextAvailableIdentifierResponse")]
        System.Threading.Tasks.Task<string> GetNextAvailableIdentifierAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/AddPerson", ReplyAction="http://tempuri.org/IRecordsKeeper/AddPersonResponse")]
        bool AddPerson(string identifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/AddPerson", ReplyAction="http://tempuri.org/IRecordsKeeper/AddPersonResponse")]
        System.Threading.Tasks.Task<bool> AddPersonAsync(string identifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/AddMoney", ReplyAction="http://tempuri.org/IRecordsKeeper/AddMoneyResponse")]
        double AddMoney(double valueToAdd, string identifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/AddMoney", ReplyAction="http://tempuri.org/IRecordsKeeper/AddMoneyResponse")]
        System.Threading.Tasks.Task<double> AddMoneyAsync(double valueToAdd, string identifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/SubractMoney", ReplyAction="http://tempuri.org/IRecordsKeeper/SubractMoneyResponse")]
        double SubractMoney(double valueToAdd, string identifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/SubractMoney", ReplyAction="http://tempuri.org/IRecordsKeeper/SubractMoneyResponse")]
        System.Threading.Tasks.Task<double> SubractMoneyAsync(double valueToAdd, string identifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/GetBalance", ReplyAction="http://tempuri.org/IRecordsKeeper/GetBalanceResponse")]
        double GetBalance(string identifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordsKeeper/GetBalance", ReplyAction="http://tempuri.org/IRecordsKeeper/GetBalanceResponse")]
        System.Threading.Tasks.Task<double> GetBalanceAsync(string identifier);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRecordsKeeperChannel : ExampleWcfClient.ServiceReference1.IRecordsKeeper, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecordsKeeperClient : System.ServiceModel.ClientBase<ExampleWcfClient.ServiceReference1.IRecordsKeeper>, ExampleWcfClient.ServiceReference1.IRecordsKeeper {
        
        public RecordsKeeperClient() {
        }
        
        public RecordsKeeperClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecordsKeeperClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecordsKeeperClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecordsKeeperClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetNextAvailableIdentifier() {
            return base.Channel.GetNextAvailableIdentifier();
        }
        
        public System.Threading.Tasks.Task<string> GetNextAvailableIdentifierAsync() {
            return base.Channel.GetNextAvailableIdentifierAsync();
        }
        
        public bool AddPerson(string identifier) {
            return base.Channel.AddPerson(identifier);
        }
        
        public System.Threading.Tasks.Task<bool> AddPersonAsync(string identifier) {
            return base.Channel.AddPersonAsync(identifier);
        }
        
        public double AddMoney(double valueToAdd, string identifier) {
            return base.Channel.AddMoney(valueToAdd, identifier);
        }
        
        public System.Threading.Tasks.Task<double> AddMoneyAsync(double valueToAdd, string identifier) {
            return base.Channel.AddMoneyAsync(valueToAdd, identifier);
        }
        
        public double SubractMoney(double valueToAdd, string identifier) {
            return base.Channel.SubractMoney(valueToAdd, identifier);
        }
        
        public System.Threading.Tasks.Task<double> SubractMoneyAsync(double valueToAdd, string identifier) {
            return base.Channel.SubractMoneyAsync(valueToAdd, identifier);
        }
        
        public double GetBalance(string identifier) {
            return base.Channel.GetBalance(identifier);
        }
        
        public System.Threading.Tasks.Task<double> GetBalanceAsync(string identifier) {
            return base.Channel.GetBalanceAsync(identifier);
        }
    }
}
