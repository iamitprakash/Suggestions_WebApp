﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Suggestions_WebApp.SuggestionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Idea", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Idea : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreatedbyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Current_StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Expected_DureationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifiedbyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime createdat1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string createdby1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string current_Status1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string description1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string docs1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string expected_Dureation1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime modifiedat1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string modifiedby1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string title1Field;
        
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
        public System.DateTime Createdat {
            get {
                return this.CreatedatField;
            }
            set {
                if ((this.CreatedatField.Equals(value) != true)) {
                    this.CreatedatField = value;
                    this.RaisePropertyChanged("Createdat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Createdby {
            get {
                return this.CreatedbyField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatedbyField, value) != true)) {
                    this.CreatedbyField = value;
                    this.RaisePropertyChanged("Createdby");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Current_Status {
            get {
                return this.Current_StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.Current_StatusField, value) != true)) {
                    this.Current_StatusField = value;
                    this.RaisePropertyChanged("Current_Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Docs {
            get {
                return this.DocsField;
            }
            set {
                if ((object.ReferenceEquals(this.DocsField, value) != true)) {
                    this.DocsField = value;
                    this.RaisePropertyChanged("Docs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Expected_Dureation {
            get {
                return this.Expected_DureationField;
            }
            set {
                if ((object.ReferenceEquals(this.Expected_DureationField, value) != true)) {
                    this.Expected_DureationField = value;
                    this.RaisePropertyChanged("Expected_Dureation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Modifiedat {
            get {
                return this.ModifiedatField;
            }
            set {
                if ((this.ModifiedatField.Equals(value) != true)) {
                    this.ModifiedatField = value;
                    this.RaisePropertyChanged("Modifiedat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modifiedby {
            get {
                return this.ModifiedbyField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifiedbyField, value) != true)) {
                    this.ModifiedbyField = value;
                    this.RaisePropertyChanged("Modifiedby");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="createdat")]
        public System.DateTime createdat1 {
            get {
                return this.createdat1Field;
            }
            set {
                if ((this.createdat1Field.Equals(value) != true)) {
                    this.createdat1Field = value;
                    this.RaisePropertyChanged("createdat1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="createdby")]
        public string createdby1 {
            get {
                return this.createdby1Field;
            }
            set {
                if ((object.ReferenceEquals(this.createdby1Field, value) != true)) {
                    this.createdby1Field = value;
                    this.RaisePropertyChanged("createdby1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="current_Status")]
        public string current_Status1 {
            get {
                return this.current_Status1Field;
            }
            set {
                if ((object.ReferenceEquals(this.current_Status1Field, value) != true)) {
                    this.current_Status1Field = value;
                    this.RaisePropertyChanged("current_Status1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="description")]
        public string description1 {
            get {
                return this.description1Field;
            }
            set {
                if ((object.ReferenceEquals(this.description1Field, value) != true)) {
                    this.description1Field = value;
                    this.RaisePropertyChanged("description1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="docs")]
        public string docs1 {
            get {
                return this.docs1Field;
            }
            set {
                if ((object.ReferenceEquals(this.docs1Field, value) != true)) {
                    this.docs1Field = value;
                    this.RaisePropertyChanged("docs1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="expected_Dureation")]
        public string expected_Dureation1 {
            get {
                return this.expected_Dureation1Field;
            }
            set {
                if ((object.ReferenceEquals(this.expected_Dureation1Field, value) != true)) {
                    this.expected_Dureation1Field = value;
                    this.RaisePropertyChanged("expected_Dureation1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="modifiedat")]
        public System.DateTime modifiedat1 {
            get {
                return this.modifiedat1Field;
            }
            set {
                if ((this.modifiedat1Field.Equals(value) != true)) {
                    this.modifiedat1Field = value;
                    this.RaisePropertyChanged("modifiedat1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="modifiedby")]
        public string modifiedby1 {
            get {
                return this.modifiedby1Field;
            }
            set {
                if ((object.ReferenceEquals(this.modifiedby1Field, value) != true)) {
                    this.modifiedby1Field = value;
                    this.RaisePropertyChanged("modifiedby1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="title")]
        public string title1 {
            get {
                return this.title1Field;
            }
            set {
                if ((object.ReferenceEquals(this.title1Field, value) != true)) {
                    this.title1Field = value;
                    this.RaisePropertyChanged("title1");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SuggestionService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertIdea", ReplyAction="http://tempuri.org/IService/InsertIdeaResponse")]
        string InsertIdea(Suggestions_WebApp.SuggestionService.Idea userInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertIdea", ReplyAction="http://tempuri.org/IService/InsertIdeaResponse")]
        System.Threading.Tasks.Task<string> InsertIdeaAsync(Suggestions_WebApp.SuggestionService.Idea userInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        Suggestions_WebApp.SuggestionService.CompositeType GetDataUsingDataContract(Suggestions_WebApp.SuggestionService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Suggestions_WebApp.SuggestionService.CompositeType> GetDataUsingDataContractAsync(Suggestions_WebApp.SuggestionService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Suggestions_WebApp.SuggestionService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Suggestions_WebApp.SuggestionService.IService>, Suggestions_WebApp.SuggestionService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string InsertIdea(Suggestions_WebApp.SuggestionService.Idea userInfo) {
            return base.Channel.InsertIdea(userInfo);
        }
        
        public System.Threading.Tasks.Task<string> InsertIdeaAsync(Suggestions_WebApp.SuggestionService.Idea userInfo) {
            return base.Channel.InsertIdeaAsync(userInfo);
        }
        
        public Suggestions_WebApp.SuggestionService.CompositeType GetDataUsingDataContract(Suggestions_WebApp.SuggestionService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Suggestions_WebApp.SuggestionService.CompositeType> GetDataUsingDataContractAsync(Suggestions_WebApp.SuggestionService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
