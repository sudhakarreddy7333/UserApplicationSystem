﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserApplicationSystem.UserApplicationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserAccessData", Namespace="http://schemas.datacontract.org/2004/07/UserApplicationSystem.Services.DataContra" +
        "cts")]
    [System.SerializableAttribute()]
    public partial class UserAccessData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTypeField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTypeField, value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseMessageDataOfUserApplicationDatajbgNRuBV", Namespace="http://schemas.datacontract.org/2004/07/UserApplicationSystem.Services.DataContra" +
        "cts")]
    [System.SerializableAttribute()]
    public partial class ResponseMessageDataOfUserApplicationDatajbgNRuBV : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UserApplicationSystem.UserApplicationService.UserApplicationData DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public UserApplicationSystem.UserApplicationService.UserApplicationData Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserApplicationData", Namespace="http://schemas.datacontract.org/2004/07/UserApplicationSystem.Services.DataContra" +
        "cts")]
    [System.SerializableAttribute()]
    public partial class UserApplicationData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationStatusField;
        
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
        public int ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((this.ApplicationIdField.Equals(value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationStatus {
            get {
                return this.ApplicationStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationStatusField, value) != true)) {
                    this.ApplicationStatusField = value;
                    this.RaisePropertyChanged("ApplicationStatus");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserApplicationService.IUserApplicationService")]
    public interface IUserApplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserApplicationService/GenerateApplicationToken", ReplyAction="http://tempuri.org/IUserApplicationService/GenerateApplicationTokenResponse")]
        UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV GenerateApplicationToken(UserApplicationSystem.UserApplicationService.UserAccessData user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserApplicationService/GenerateApplicationToken", ReplyAction="http://tempuri.org/IUserApplicationService/GenerateApplicationTokenResponse")]
        System.Threading.Tasks.Task<UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV> GenerateApplicationTokenAsync(UserApplicationSystem.UserApplicationService.UserAccessData user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserApplicationService/GetApplicationStatus", ReplyAction="http://tempuri.org/IUserApplicationService/GetApplicationStatusResponse")]
        UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV GetApplicationStatus(int applicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserApplicationService/GetApplicationStatus", ReplyAction="http://tempuri.org/IUserApplicationService/GetApplicationStatusResponse")]
        System.Threading.Tasks.Task<UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV> GetApplicationStatusAsync(int applicationId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserApplicationServiceChannel : UserApplicationSystem.UserApplicationService.IUserApplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserApplicationServiceClient : System.ServiceModel.ClientBase<UserApplicationSystem.UserApplicationService.IUserApplicationService>, UserApplicationSystem.UserApplicationService.IUserApplicationService {
        
        public UserApplicationServiceClient() {
        }
        
        public UserApplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserApplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserApplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserApplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV GenerateApplicationToken(UserApplicationSystem.UserApplicationService.UserAccessData user) {
            return base.Channel.GenerateApplicationToken(user);
        }
        
        public System.Threading.Tasks.Task<UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV> GenerateApplicationTokenAsync(UserApplicationSystem.UserApplicationService.UserAccessData user) {
            return base.Channel.GenerateApplicationTokenAsync(user);
        }
        
        public UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV GetApplicationStatus(int applicationId) {
            return base.Channel.GetApplicationStatus(applicationId);
        }
        
        public System.Threading.Tasks.Task<UserApplicationSystem.UserApplicationService.ResponseMessageDataOfUserApplicationDatajbgNRuBV> GetApplicationStatusAsync(int applicationId) {
            return base.Channel.GetApplicationStatusAsync(applicationId);
        }
    }
}