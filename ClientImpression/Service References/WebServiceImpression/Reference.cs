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
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentMessage", Namespace="http://schemas.datacontract.org/2004/07/ServeurImpression.Message")]
    [System.SerializableAttribute()]
    public partial class DocumentMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContenuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ImprimanteMessage", Namespace="http://schemas.datacontract.org/2004/07/ServeurImpression.Message")]
    [System.SerializableAttribute()]
    public partial class ImprimanteMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ServeurImpressionThreads.WebServiceImpression.DocumentMessage DocumentEnCoursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.DocumentMessage> DocumentsEnAttenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.DocumentMessage> DocumentsEnErreurField;
        
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
        public ServeurImpressionThreads.WebServiceImpression.DocumentMessage DocumentEnCours {
            get {
                return this.DocumentEnCoursField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentEnCoursField, value) != true)) {
                    this.DocumentEnCoursField = value;
                    this.RaisePropertyChanged("DocumentEnCours");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.DocumentMessage> DocumentsEnAttente {
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
        public System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.DocumentMessage> DocumentsEnErreur {
            get {
                return this.DocumentsEnErreurField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentsEnErreurField, value) != true)) {
                    this.DocumentsEnErreurField = value;
                    this.RaisePropertyChanged("DocumentsEnErreur");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TcpListenerMessage", Namespace="http://schemas.datacontract.org/2004/07/ServeurImpression.Message")]
    [System.SerializableAttribute()]
    public partial class TcpListenerMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddresseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PortField;
        
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
        public string Addresse {
            get {
                return this.AddresseField;
            }
            set {
                if ((object.ReferenceEquals(this.AddresseField, value) != true)) {
                    this.AddresseField = value;
                    this.RaisePropertyChanged("Addresse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Port {
            get {
                return this.PortField;
            }
            set {
                if ((this.PortField.Equals(value) != true)) {
                    this.PortField = value;
                    this.RaisePropertyChanged("Port");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceImpression.IWebServiceImpression")]
    public interface IWebServiceImpression {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterDocumentResponse")]
        ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage AjouterDocument(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterDocumentResponse")]
        System.Threading.Tasks.Task<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage> AjouterDocumentAsync(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerDocumentResponse")]
        void SupprimerDocument(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerDocument", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerDocumentResponse")]
        System.Threading.Tasks.Task SupprimerDocumentAsync(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetImprimantes", ReplyAction="http://tempuri.org/IWebServiceImpression/GetImprimantesResponse")]
        System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage> GetImprimantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetImprimantes", ReplyAction="http://tempuri.org/IWebServiceImpression/GetImprimantesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage>> GetImprimantesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/GetImprimanteResponse")]
        ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage GetImprimante(string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/GetImprimanteResponse")]
        System.Threading.Tasks.Task<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage> GetImprimanteAsync(string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterImprimanteResponse")]
        void AjouterImprimante(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterImprimanteResponse")]
        System.Threading.Tasks.Task AjouterImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerImprimanteResponse")]
        void SupprimerImprimante(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/SupprimerImprimante", ReplyAction="http://tempuri.org/IWebServiceImpression/SupprimerImprimanteResponse")]
        System.Threading.Tasks.Task SupprimerImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetDocumentNbPages", ReplyAction="http://tempuri.org/IWebServiceImpression/GetDocumentNbPagesResponse")]
        int GetDocumentNbPages(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetDocumentNbPages", ReplyAction="http://tempuri.org/IWebServiceImpression/GetDocumentNbPagesResponse")]
        System.Threading.Tasks.Task<int> GetDocumentNbPagesAsync(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpression", ReplyAction="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpressionResponse")]
        float GetTempsPrevuPourImpression(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante, ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpression", ReplyAction="http://tempuri.org/IWebServiceImpression/GetTempsPrevuPourImpressionResponse")]
        System.Threading.Tasks.Task<float> GetTempsPrevuPourImpressionAsync(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante, ServeurImpressionThreads.WebServiceImpression.DocumentMessage document);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterTcpListener", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterTcpListenerResponse")]
        void AjouterTcpListener(ServeurImpressionThreads.WebServiceImpression.TcpListenerMessage listener);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceImpression/AjouterTcpListener", ReplyAction="http://tempuri.org/IWebServiceImpression/AjouterTcpListenerResponse")]
        System.Threading.Tasks.Task AjouterTcpListenerAsync(ServeurImpressionThreads.WebServiceImpression.TcpListenerMessage listener);
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
        
        public ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage AjouterDocument(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            return base.Channel.AjouterDocument(document);
        }
        
        public System.Threading.Tasks.Task<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage> AjouterDocumentAsync(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            return base.Channel.AjouterDocumentAsync(document);
        }
        
        public void SupprimerDocument(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            base.Channel.SupprimerDocument(document);
        }
        
        public System.Threading.Tasks.Task SupprimerDocumentAsync(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            return base.Channel.SupprimerDocumentAsync(document);
        }
        
        public System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage> GetImprimantes() {
            return base.Channel.GetImprimantes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage>> GetImprimantesAsync() {
            return base.Channel.GetImprimantesAsync();
        }
        
        public ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage GetImprimante(string nom) {
            return base.Channel.GetImprimante(nom);
        }
        
        public System.Threading.Tasks.Task<ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage> GetImprimanteAsync(string nom) {
            return base.Channel.GetImprimanteAsync(nom);
        }
        
        public void AjouterImprimante(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante) {
            base.Channel.AjouterImprimante(imprimante);
        }
        
        public System.Threading.Tasks.Task AjouterImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante) {
            return base.Channel.AjouterImprimanteAsync(imprimante);
        }
        
        public void SupprimerImprimante(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante) {
            base.Channel.SupprimerImprimante(imprimante);
        }
        
        public System.Threading.Tasks.Task SupprimerImprimanteAsync(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante) {
            return base.Channel.SupprimerImprimanteAsync(imprimante);
        }
        
        public int GetDocumentNbPages(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            return base.Channel.GetDocumentNbPages(document);
        }
        
        public System.Threading.Tasks.Task<int> GetDocumentNbPagesAsync(ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            return base.Channel.GetDocumentNbPagesAsync(document);
        }
        
        public float GetTempsPrevuPourImpression(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante, ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            return base.Channel.GetTempsPrevuPourImpression(imprimante, document);
        }
        
        public System.Threading.Tasks.Task<float> GetTempsPrevuPourImpressionAsync(ServeurImpressionThreads.WebServiceImpression.ImprimanteMessage imprimante, ServeurImpressionThreads.WebServiceImpression.DocumentMessage document) {
            return base.Channel.GetTempsPrevuPourImpressionAsync(imprimante, document);
        }
        
        public void AjouterTcpListener(ServeurImpressionThreads.WebServiceImpression.TcpListenerMessage listener) {
            base.Channel.AjouterTcpListener(listener);
        }
        
        public System.Threading.Tasks.Task AjouterTcpListenerAsync(ServeurImpressionThreads.WebServiceImpression.TcpListenerMessage listener) {
            return base.Channel.AjouterTcpListenerAsync(listener);
        }
    }
}
