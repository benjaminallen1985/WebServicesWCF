﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PunClient.WCFPunService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pun", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    [System.SerializableAttribute()]
    public partial class Pun : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Jokek__BackingFieldField;
        
        private int PunIDk__BackingFieldField;
        
        private string Titlek__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Joke>k__BackingField", IsRequired=true)]
        public string Jokek__BackingField {
            get {
                return this.Jokek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Jokek__BackingFieldField, value) != true)) {
                    this.Jokek__BackingFieldField = value;
                    this.RaisePropertyChanged("Jokek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<PunID>k__BackingField", IsRequired=true)]
        public int PunIDk__BackingField {
            get {
                return this.PunIDk__BackingFieldField;
            }
            set {
                if ((this.PunIDk__BackingFieldField.Equals(value) != true)) {
                    this.PunIDk__BackingFieldField = value;
                    this.RaisePropertyChanged("PunIDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Title>k__BackingField", IsRequired=true)]
        public string Titlek__BackingField {
            get {
                return this.Titlek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Titlek__BackingFieldField, value) != true)) {
                    this.Titlek__BackingFieldField = value;
                    this.RaisePropertyChanged("Titlek__BackingField");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFPunService.IPunService")]
    public interface IPunService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/GetPuns", ReplyAction="http://tempuri.org/IPunService/GetPunsResponse")]
        PunClient.WCFPunService.Pun[] GetPuns();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/GetPuns", ReplyAction="http://tempuri.org/IPunService/GetPunsResponse")]
        System.Threading.Tasks.Task<PunClient.WCFPunService.Pun[]> GetPunsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/GetPunByID", ReplyAction="http://tempuri.org/IPunService/GetPunByIDResponse")]
        PunClient.WCFPunService.Pun GetPunByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/GetPunByID", ReplyAction="http://tempuri.org/IPunService/GetPunByIDResponse")]
        System.Threading.Tasks.Task<PunClient.WCFPunService.Pun> GetPunByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/CreatePun", ReplyAction="http://tempuri.org/IPunService/CreatePunResponse")]
        void CreatePun(PunClient.WCFPunService.Pun pun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/CreatePun", ReplyAction="http://tempuri.org/IPunService/CreatePunResponse")]
        System.Threading.Tasks.Task CreatePunAsync(PunClient.WCFPunService.Pun pun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/UpdatePun", ReplyAction="http://tempuri.org/IPunService/UpdatePunResponse")]
        void UpdatePun(PunClient.WCFPunService.Pun pun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/UpdatePun", ReplyAction="http://tempuri.org/IPunService/UpdatePunResponse")]
        System.Threading.Tasks.Task UpdatePunAsync(PunClient.WCFPunService.Pun pun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/DeletePun", ReplyAction="http://tempuri.org/IPunService/DeletePunResponse")]
        void DeletePun(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPunService/DeletePun", ReplyAction="http://tempuri.org/IPunService/DeletePunResponse")]
        System.Threading.Tasks.Task DeletePunAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPunServiceChannel : PunClient.WCFPunService.IPunService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PunServiceClient : System.ServiceModel.ClientBase<PunClient.WCFPunService.IPunService>, PunClient.WCFPunService.IPunService {
        
        public PunServiceClient() {
        }
        
        public PunServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PunServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PunServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PunServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PunClient.WCFPunService.Pun[] GetPuns() {
            return base.Channel.GetPuns();
        }
        
        public System.Threading.Tasks.Task<PunClient.WCFPunService.Pun[]> GetPunsAsync() {
            return base.Channel.GetPunsAsync();
        }
        
        public PunClient.WCFPunService.Pun GetPunByID(int id) {
            return base.Channel.GetPunByID(id);
        }
        
        public System.Threading.Tasks.Task<PunClient.WCFPunService.Pun> GetPunByIDAsync(int id) {
            return base.Channel.GetPunByIDAsync(id);
        }
        
        public void CreatePun(PunClient.WCFPunService.Pun pun) {
            base.Channel.CreatePun(pun);
        }
        
        public System.Threading.Tasks.Task CreatePunAsync(PunClient.WCFPunService.Pun pun) {
            return base.Channel.CreatePunAsync(pun);
        }
        
        public void UpdatePun(PunClient.WCFPunService.Pun pun) {
            base.Channel.UpdatePun(pun);
        }
        
        public System.Threading.Tasks.Task UpdatePunAsync(PunClient.WCFPunService.Pun pun) {
            return base.Channel.UpdatePunAsync(pun);
        }
        
        public void DeletePun(int id) {
            base.Channel.DeletePun(id);
        }
        
        public System.Threading.Tasks.Task DeletePunAsync(int id) {
            return base.Channel.DeletePunAsync(id);
        }
    }
}
