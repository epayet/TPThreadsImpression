﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34011
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServeurImpressionThreads.WebServiceImpression {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Document", Namespace="http://schemas.datacontract.org/2004/07/ServiceImpression.Data")]
    [System.SerializableAttribute()]
    public partial class Document : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
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
        public byte[] Contenu {
            get {
                return this.ContenuField;
            }
            set {
                if ((object.ReferenceEquals(this.ContenuField, value) != true)) {
                    this.ContenuField = value;
                    this.RaisePropertyChanged("Contenu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Imprimante", Namespace="http://schemas.datacontract.org/2004/07/ServiceImpression.Data")]
    [System.SerializableAttribute()]
    public partial class Imprimante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.Document> DocumentsEnAttenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ServeurImpressionThreads.WebServiceImpression.Etat EtatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PagesParMinuteField;
        
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
        public System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.Document> DocumentsEnAttente {
            get {
                return this.DocumentsEnAttenteField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentsEnAttenteField, value) != true)) {
                    this.DocumentsEnAttenteField = value;
                    this.RaisePropertyChanged("DocumentsEnAttente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServeurImpressionThreads.WebServiceImpression.Etat Etat {
            get {
                return this.EtatField;
            }
            set {
                if ((this.EtatField.Equals(value) != true)) {
                    this.EtatField = value;
                    this.RaisePropertyChanged("Etat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float PagesParMinute {
            get {
                return this.PagesParMinuteField;
            }
            set {
                if ((this.PagesParMinuteField.Equals(value) != true)) {
                    this.PagesParMinuteField = value;
                    this.RaisePropertyChanged("PagesParMinute");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Etat", Namespace="http://schemas.datacontract.org/2004/07/ServiceImpression.Data")]
    public enum Etat : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EN_LIGNE = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HORS_LIGNE = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ERREUR = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceImpression.IWebServiceImpression")]
    public interface IWebServiceImpression {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterDocumentResponse")]
        ServeurImpressionThreads.WebServiceImpression.Imprimante AjouterDocument(ServeurImpressionThreads.WebServiceImpression.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterDocumentResponse")]
        System.Threading.Tasks.Task<ServeurImpressionThreads.WebServiceImpression.Imprimante> AjouterDocumentAsync(ServeurImpressionThreads.WebServiceImpression.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerDocumentResponse")]
        void SupprimerDocument(ServeurImpressionThreads.WebServiceImpression.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerDocumentResponse")]
        System.Threading.Tasks.Task SupprimerDocumentAsync(ServeurImpressionThreads.WebServiceImpression.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetImprimantes", ReplyAction="http://tempuri.org/IWebServiceImpression/GetImprimantesResponse")]
        System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.Imprimante> GetImprimantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetImprimantes", ReplyAction="http://tempuri.org/IWebServiceImpression/GetImprimantesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.Imprimante>> GetImprimantesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterImprimanteResponse")]
        void AjouterImprimante(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterImprimanteResponse")]
        System.Threading.Tasks.Task AjouterImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerImprimanteResponse")]
        void SupprimerImprimante(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerImprimanteResponse")]
        System.Threading.Tasks.Task SupprimerImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetDocumentNbPages", ReplyAction="http://tempuri.org/IWebServiceImpression/GetDocumentNbPagesResponse")]
        int GetDocumentNbPages(ServeurImpressionThreads.WebServiceImpression.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetDocumentNbPages", ReplyAction="http://tempuri.org/IWebServiceImpression/GetDocumentNbPagesResponse")]
        System.Threading.Tasks.Task<int> GetDocumentNbPagesAsync(ServeurImpressionThreads.WebServiceImpression.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpression", ReplyAction="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpressionResponse")]
        float GetTempsPrevuPourImpression(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante, ServeurImpressionThreads.WebServiceImpression.Document document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpression", ReplyAction="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpressionResponse")]
        System.Threading.Tasks.Task<float> GetTempsPrevuPourImpressionAsync(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante, ServeurImpressionThreads.WebServiceImpression.Document document);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebServiceImpressionChannel : ServeurImpressionThreads.WebServiceImpression.IWebServiceImpression, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceImpressionClient : System.ServiceModel.ClientBase<ServeurImpressionThreads.WebServiceImpression.IWebServiceImpression>, ServeurImpressionThreads.WebServiceImpression.IWebServiceImpression {
        
        public WebServiceImpressionClient() {
        }
        
        public WebServiceImpressionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceImpressionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceImpressionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceImpressionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServeurImpressionThreads.WebServiceImpression.Imprimante AjouterDocument(ServeurImpressionThreads.WebServiceImpression.Document document) {
            return base.Channel.AjouterDocument(document);
        }
        
        public System.Threading.Tasks.Task<ServeurImpressionThreads.WebServiceImpression.Imprimante> AjouterDocumentAsync(ServeurImpressionThreads.WebServiceImpression.Document document) {
            return base.Channel.AjouterDocumentAsync(document);
        }
        
        public void SupprimerDocument(ServeurImpressionThreads.WebServiceImpression.Document document) {
            base.Channel.SupprimerDocument(document);
        }
        
        public System.Threading.Tasks.Task SupprimerDocumentAsync(ServeurImpressionThreads.WebServiceImpression.Document document) {
            return base.Channel.SupprimerDocumentAsync(document);
        }
        
        public System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.Imprimante> GetImprimantes() {
            return base.Channel.GetImprimantes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.Imprimante>> GetImprimantesAsync() {
            return base.Channel.GetImprimantesAsync();
        }
        
        public void AjouterImprimante(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante) {
            base.Channel.AjouterImprimante(imprimante);
        }
        
        public System.Threading.Tasks.Task AjouterImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante) {
            return base.Channel.AjouterImprimanteAsync(imprimante);
        }
        
        public void SupprimerImprimante(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante) {
            base.Channel.SupprimerImprimante(imprimante);
        }
        
        public System.Threading.Tasks.Task SupprimerImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante) {
            return base.Channel.SupprimerImprimanteAsync(imprimante);
        }
        
        public int GetDocumentNbPages(ServeurImpressionThreads.WebServiceImpression.Document document) {
            return base.Channel.GetDocumentNbPages(document);
        }
        
        public System.Threading.Tasks.Task<int> GetDocumentNbPagesAsync(ServeurImpressionThreads.WebServiceImpression.Document document) {
            return base.Channel.GetDocumentNbPagesAsync(document);
        }
        
        public float GetTempsPrevuPourImpression(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante, ServeurImpressionThreads.WebServiceImpression.Document document) {
            return base.Channel.GetTempsPrevuPourImpression(imprimante, document);
        }
        
        public System.Threading.Tasks.Task<float> GetTempsPrevuPourImpressionAsync(ServeurImpressionThreads.WebServiceImpression.Imprimante imprimante, ServeurImpressionThreads.WebServiceImpression.Document document) {
            return base.Channel.GetTempsPrevuPourImpressionAsync(imprimante, document);
        }
    }
}