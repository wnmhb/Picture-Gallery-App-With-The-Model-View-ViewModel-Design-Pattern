﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PictureData", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class PictureData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string ImageSource {
            get {
                return this.ImageSourceField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageSourceField, value) != true)) {
                    this.ImageSourceField = value;
                    this.RaisePropertyChanged("ImageSource");
                }
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPictureData", ReplyAction="http://tempuri.org/IService1/GetAllPictureDataResponse")]
        WpfApplication1.ServiceReference1.PictureData[] GetAllPictureData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPageData", ReplyAction="http://tempuri.org/IService1/GetPageDataResponse")]
        WpfApplication1.ServiceReference1.PictureData[] GetPageData(int pageIndex, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPictureDataCount", ReplyAction="http://tempuri.org/IService1/GetPictureDataCountResponse")]
        int GetPictureDataCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPageCount", ReplyAction="http://tempuri.org/IService1/GetPageCountResponse")]
        int GetPageCount(int pageSize);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfApplication1.ServiceReference1.IService1>, WpfApplication1.ServiceReference1.IService1 {
        
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
        
        public WpfApplication1.ServiceReference1.PictureData[] GetAllPictureData() {
            return base.Channel.GetAllPictureData();
        }
        
        public WpfApplication1.ServiceReference1.PictureData[] GetPageData(int pageIndex, int pageSize) {
            return base.Channel.GetPageData(pageIndex, pageSize);
        }
        
        public int GetPictureDataCount() {
            return base.Channel.GetPictureDataCount();
        }
        
        public int GetPageCount(int pageSize) {
            return base.Channel.GetPageCount(pageSize);
        }
    }
}
