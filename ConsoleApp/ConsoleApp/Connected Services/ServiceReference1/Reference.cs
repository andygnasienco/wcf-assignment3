﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VegetableDetails", Namespace="http://schemas.datacontract.org/2004/07/agnasiencoA3")]
    [System.SerializableAttribute()]
    public partial class VegetableDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Veg_IDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Veg_ID {
            get {
                return this.Veg_IDField;
            }
            set {
                if ((this.Veg_IDField.Equals(value) != true)) {
                    this.Veg_IDField = value;
                    this.RaisePropertyChanged("Veg_ID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertVegDet", ReplyAction="http://tempuri.org/IService1/InsertVegDetResponse")]
        string InsertVegDet(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertVegDet", ReplyAction="http://tempuri.org/IService1/InsertVegDetResponse")]
        System.Threading.Tasks.Task<string> InsertVegDetAsync(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVegetables", ReplyAction="http://tempuri.org/IService1/GetVegetablesResponse")]
        System.Collections.Generic.List<ConsoleApp.ServiceReference1.VegetableDetails> GetVegetables();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVegetables", ReplyAction="http://tempuri.org/IService1/GetVegetablesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ConsoleApp.ServiceReference1.VegetableDetails>> GetVegetablesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteVegDet", ReplyAction="http://tempuri.org/IService1/DeleteVegDetResponse")]
        string DeleteVegDet(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteVegDet", ReplyAction="http://tempuri.org/IService1/DeleteVegDetResponse")]
        System.Threading.Tasks.Task<string> DeleteVegDetAsync(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateVegDet", ReplyAction="http://tempuri.org/IService1/UpdateVegDetResponse")]
        string UpdateVegDet(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateVegDet", ReplyAction="http://tempuri.org/IService1/UpdateVegDetResponse")]
        System.Threading.Tasks.Task<string> UpdateVegDetAsync(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleApp.ServiceReference1.IService1>, ConsoleApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertVegDet(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails) {
            return base.Channel.InsertVegDet(vegetableDetails);
        }
        
        public System.Threading.Tasks.Task<string> InsertVegDetAsync(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails) {
            return base.Channel.InsertVegDetAsync(vegetableDetails);
        }
        
        public System.Collections.Generic.List<ConsoleApp.ServiceReference1.VegetableDetails> GetVegetables() {
            return base.Channel.GetVegetables();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ConsoleApp.ServiceReference1.VegetableDetails>> GetVegetablesAsync() {
            return base.Channel.GetVegetablesAsync();
        }
        
        public string DeleteVegDet(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails) {
            return base.Channel.DeleteVegDet(vegetableDetails);
        }
        
        public System.Threading.Tasks.Task<string> DeleteVegDetAsync(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails) {
            return base.Channel.DeleteVegDetAsync(vegetableDetails);
        }
        
        public string UpdateVegDet(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails) {
            return base.Channel.UpdateVegDet(vegetableDetails);
        }
        
        public System.Threading.Tasks.Task<string> UpdateVegDetAsync(ConsoleApp.ServiceReference1.VegetableDetails vegetableDetails) {
            return base.Channel.UpdateVegDetAsync(vegetableDetails);
        }
    }
}
