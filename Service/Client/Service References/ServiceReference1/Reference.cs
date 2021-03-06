﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MailInformation", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    [System.SerializableAttribute()]
    public partial class MailInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailOfRecipientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string smtpServerField;
        
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
        public string emailOfRecipient {
            get {
                return this.emailOfRecipientField;
            }
            set {
                if ((object.ReferenceEquals(this.emailOfRecipientField, value) != true)) {
                    this.emailOfRecipientField = value;
                    this.RaisePropertyChanged("emailOfRecipient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string smtpServer {
            get {
                return this.smtpServerField;
            }
            set {
                if ((object.ReferenceEquals(this.smtpServerField, value) != true)) {
                    this.smtpServerField = value;
                    this.RaisePropertyChanged("smtpServer");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJsonDoc", ReplyAction="http://tempuri.org/IService1/GetJsonDocResponse")]
        void GetJsonDoc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJsonDoc", ReplyAction="http://tempuri.org/IService1/GetJsonDocResponse")]
        System.Threading.Tasks.Task GetJsonDocAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTimeOfUpdate", ReplyAction="http://tempuri.org/IService1/GetTimeOfUpdateResponse")]
        string GetTimeOfUpdate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTimeOfUpdate", ReplyAction="http://tempuri.org/IService1/GetTimeOfUpdateResponse")]
        System.Threading.Tasks.Task<string> GetTimeOfUpdateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendMessage", ReplyAction="http://tempuri.org/IService1/SendMessageResponse")]
        void SendMessage(Client.ServiceReference1.MailInformation mInf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendMessage", ReplyAction="http://tempuri.org/IService1/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(Client.ServiceReference1.MailInformation mInf);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
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
        
        public void GetJsonDoc() {
            base.Channel.GetJsonDoc();
        }
        
        public System.Threading.Tasks.Task GetJsonDocAsync() {
            return base.Channel.GetJsonDocAsync();
        }
        
        public string GetTimeOfUpdate() {
            return base.Channel.GetTimeOfUpdate();
        }
        
        public System.Threading.Tasks.Task<string> GetTimeOfUpdateAsync() {
            return base.Channel.GetTimeOfUpdateAsync();
        }
        
        public void SendMessage(Client.ServiceReference1.MailInformation mInf) {
            base.Channel.SendMessage(mInf);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(Client.ServiceReference1.MailInformation mInf) {
            return base.Channel.SendMessageAsync(mInf);
        }
    }
}
