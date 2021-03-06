﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonsClient.PersonService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://persons.ia5_2/")]
    public partial class FailedLoginException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://persons.ia5_2/")]
    public partial class person : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int ageField;
        
        private bool ageFieldSpecified;
        
        private string birthdayField;
        
        private string[] educationField;
        
        private string lastnameField;
        
        private string nameField;
        
        private string peselField;
        
        private string sexField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
                this.RaisePropertyChanged("age");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ageSpecified {
            get {
                return this.ageFieldSpecified;
            }
            set {
                this.ageFieldSpecified = value;
                this.RaisePropertyChanged("ageSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string birthday {
            get {
                return this.birthdayField;
            }
            set {
                this.birthdayField = value;
                this.RaisePropertyChanged("birthday");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("school", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] education {
            get {
                return this.educationField;
            }
            set {
                this.educationField = value;
                this.RaisePropertyChanged("education");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string lastname {
            get {
                return this.lastnameField;
            }
            set {
                this.lastnameField = value;
                this.RaisePropertyChanged("lastname");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string pesel {
            get {
                return this.peselField;
            }
            set {
                this.peselField = value;
                this.RaisePropertyChanged("pesel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string sex {
            get {
                return this.sexField;
            }
            set {
                this.sexField = value;
                this.RaisePropertyChanged("sex");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://persons.ia5_2/", ConfigurationName="PersonService.PersonManager")]
    public interface PersonManager {
        
        // CODEGEN: Parameter 'person' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/searchByLastnameRequest", ReplyAction="http://persons.ia5_2/PersonManager/searchByLastnameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PersonsClient.PersonService.FailedLoginException), Action="http://persons.ia5_2/PersonManager/searchByLastname/Fault/FailedLoginException", Name="FailedLoginException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="person")]
        PersonsClient.PersonService.searchByLastnameResponse searchByLastname(PersonsClient.PersonService.searchByLastnameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/searchByLastnameRequest", ReplyAction="http://persons.ia5_2/PersonManager/searchByLastnameResponse")]
        System.Threading.Tasks.Task<PersonsClient.PersonService.searchByLastnameResponse> searchByLastnameAsync(PersonsClient.PersonService.searchByLastnameRequest request);
        
        // CODEGEN: Parameter 'person' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/searchByPeselRequest", ReplyAction="http://persons.ia5_2/PersonManager/searchByPeselResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PersonsClient.PersonService.FailedLoginException), Action="http://persons.ia5_2/PersonManager/searchByPesel/Fault/FailedLoginException", Name="FailedLoginException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="person")]
        PersonsClient.PersonService.searchByPeselResponse searchByPesel(PersonsClient.PersonService.searchByPeselRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/searchByPeselRequest", ReplyAction="http://persons.ia5_2/PersonManager/searchByPeselResponse")]
        System.Threading.Tasks.Task<PersonsClient.PersonService.searchByPeselResponse> searchByPeselAsync(PersonsClient.PersonService.searchByPeselRequest request);
        
        // CODEGEN: Parameter 'sessionid' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/loginRequestRequest", ReplyAction="http://persons.ia5_2/PersonManager/loginRequestResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="sessionid")]
        PersonsClient.PersonService.loginRequestResponse loginRequest(PersonsClient.PersonService.loginRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/loginRequestRequest", ReplyAction="http://persons.ia5_2/PersonManager/loginRequestResponse")]
        System.Threading.Tasks.Task<PersonsClient.PersonService.loginRequestResponse> loginRequestAsync(PersonsClient.PersonService.loginRequestRequest request);
        
        // CODEGEN: Parameter 'logoutRequest' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/logoutRequest", ReplyAction="http://persons.ia5_2/PersonManager/logoutResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PersonsClient.PersonService.FailedLoginException), Action="http://persons.ia5_2/PersonManager/logout/Fault/FailedLoginException", Name="FailedLoginException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="logoutRequest")]
        PersonsClient.PersonService.logoutResponse logout(PersonsClient.PersonService.logoutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/logoutRequest", ReplyAction="http://persons.ia5_2/PersonManager/logoutResponse")]
        System.Threading.Tasks.Task<PersonsClient.PersonService.logoutResponse> logoutAsync(PersonsClient.PersonService.logoutRequest request);
        
        // CODEGEN: Parameter 'person' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/searchByNameRequest", ReplyAction="http://persons.ia5_2/PersonManager/searchByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PersonsClient.PersonService.FailedLoginException), Action="http://persons.ia5_2/PersonManager/searchByName/Fault/FailedLoginException", Name="FailedLoginException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="person")]
        PersonsClient.PersonService.searchByNameResponse searchByName(PersonsClient.PersonService.searchByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://persons.ia5_2/PersonManager/searchByNameRequest", ReplyAction="http://persons.ia5_2/PersonManager/searchByNameResponse")]
        System.Threading.Tasks.Task<PersonsClient.PersonService.searchByNameResponse> searchByNameAsync(PersonsClient.PersonService.searchByNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByLastname", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class searchByLastnameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lastname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string token;
        
        public searchByLastnameRequest() {
        }
        
        public searchByLastnameRequest(string lastname, string token) {
            this.lastname = lastname;
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByLastnameResponse", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class searchByLastnameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("person", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PersonsClient.PersonService.person[] person;
        
        public searchByLastnameResponse() {
        }
        
        public searchByLastnameResponse(PersonsClient.PersonService.person[] person) {
            this.person = person;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByPesel", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class searchByPeselRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string pesel;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string token;
        
        public searchByPeselRequest() {
        }
        
        public searchByPeselRequest(string pesel, string token) {
            this.pesel = pesel;
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByPeselResponse", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class searchByPeselResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PersonsClient.PersonService.person person;
        
        public searchByPeselResponse() {
        }
        
        public searchByPeselResponse(PersonsClient.PersonService.person person) {
            this.person = person;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="loginRequest", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class loginRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        public loginRequestRequest() {
        }
        
        public loginRequestRequest(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="loginRequestResponse", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class loginRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sessionid;
        
        public loginRequestResponse() {
        }
        
        public loginRequestResponse(string sessionid) {
            this.sessionid = sessionid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="logout", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class logoutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string token;
        
        public logoutRequest() {
        }
        
        public logoutRequest(string token) {
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="logoutResponse", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class logoutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool logoutRequest;
        
        public logoutResponse() {
        }
        
        public logoutResponse(bool logoutRequest) {
            this.logoutRequest = logoutRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByName", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class searchByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string token;
        
        public searchByNameRequest() {
        }
        
        public searchByNameRequest(string name, string token) {
            this.name = name;
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByNameResponse", WrapperNamespace="http://persons.ia5_2/", IsWrapped=true)]
    public partial class searchByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://persons.ia5_2/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("person", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PersonsClient.PersonService.person[] person;
        
        public searchByNameResponse() {
        }
        
        public searchByNameResponse(PersonsClient.PersonService.person[] person) {
            this.person = person;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PersonManagerChannel : PersonsClient.PersonService.PersonManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonManagerClient : System.ServiceModel.ClientBase<PersonsClient.PersonService.PersonManager>, PersonsClient.PersonService.PersonManager {
        
        public PersonManagerClient() {
        }
        
        public PersonManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PersonsClient.PersonService.searchByLastnameResponse PersonsClient.PersonService.PersonManager.searchByLastname(PersonsClient.PersonService.searchByLastnameRequest request) {
            return base.Channel.searchByLastname(request);
        }
        
        public PersonsClient.PersonService.person[] searchByLastname(string lastname, string token) {
            PersonsClient.PersonService.searchByLastnameRequest inValue = new PersonsClient.PersonService.searchByLastnameRequest();
            inValue.lastname = lastname;
            inValue.token = token;
            PersonsClient.PersonService.searchByLastnameResponse retVal = ((PersonsClient.PersonService.PersonManager)(this)).searchByLastname(inValue);
            return retVal.person;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PersonsClient.PersonService.searchByLastnameResponse> PersonsClient.PersonService.PersonManager.searchByLastnameAsync(PersonsClient.PersonService.searchByLastnameRequest request) {
            return base.Channel.searchByLastnameAsync(request);
        }
        
        public System.Threading.Tasks.Task<PersonsClient.PersonService.searchByLastnameResponse> searchByLastnameAsync(string lastname, string token) {
            PersonsClient.PersonService.searchByLastnameRequest inValue = new PersonsClient.PersonService.searchByLastnameRequest();
            inValue.lastname = lastname;
            inValue.token = token;
            return ((PersonsClient.PersonService.PersonManager)(this)).searchByLastnameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PersonsClient.PersonService.searchByPeselResponse PersonsClient.PersonService.PersonManager.searchByPesel(PersonsClient.PersonService.searchByPeselRequest request) {
            return base.Channel.searchByPesel(request);
        }
        
        public PersonsClient.PersonService.person searchByPesel(string pesel, string token) {
            PersonsClient.PersonService.searchByPeselRequest inValue = new PersonsClient.PersonService.searchByPeselRequest();
            inValue.pesel = pesel;
            inValue.token = token;
            PersonsClient.PersonService.searchByPeselResponse retVal = ((PersonsClient.PersonService.PersonManager)(this)).searchByPesel(inValue);
            return retVal.person;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PersonsClient.PersonService.searchByPeselResponse> PersonsClient.PersonService.PersonManager.searchByPeselAsync(PersonsClient.PersonService.searchByPeselRequest request) {
            return base.Channel.searchByPeselAsync(request);
        }
        
        public System.Threading.Tasks.Task<PersonsClient.PersonService.searchByPeselResponse> searchByPeselAsync(string pesel, string token) {
            PersonsClient.PersonService.searchByPeselRequest inValue = new PersonsClient.PersonService.searchByPeselRequest();
            inValue.pesel = pesel;
            inValue.token = token;
            return ((PersonsClient.PersonService.PersonManager)(this)).searchByPeselAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PersonsClient.PersonService.loginRequestResponse PersonsClient.PersonService.PersonManager.loginRequest(PersonsClient.PersonService.loginRequestRequest request) {
            return base.Channel.loginRequest(request);
        }
        
        public string loginRequest(string username, string password) {
            PersonsClient.PersonService.loginRequestRequest inValue = new PersonsClient.PersonService.loginRequestRequest();
            inValue.username = username;
            inValue.password = password;
            PersonsClient.PersonService.loginRequestResponse retVal = ((PersonsClient.PersonService.PersonManager)(this)).loginRequest(inValue);
            return retVal.sessionid;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PersonsClient.PersonService.loginRequestResponse> PersonsClient.PersonService.PersonManager.loginRequestAsync(PersonsClient.PersonService.loginRequestRequest request) {
            return base.Channel.loginRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<PersonsClient.PersonService.loginRequestResponse> loginRequestAsync(string username, string password) {
            PersonsClient.PersonService.loginRequestRequest inValue = new PersonsClient.PersonService.loginRequestRequest();
            inValue.username = username;
            inValue.password = password;
            return ((PersonsClient.PersonService.PersonManager)(this)).loginRequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PersonsClient.PersonService.logoutResponse PersonsClient.PersonService.PersonManager.logout(PersonsClient.PersonService.logoutRequest request) {
            return base.Channel.logout(request);
        }
        
        public bool logout(string token) {
            PersonsClient.PersonService.logoutRequest inValue = new PersonsClient.PersonService.logoutRequest();
            inValue.token = token;
            PersonsClient.PersonService.logoutResponse retVal = ((PersonsClient.PersonService.PersonManager)(this)).logout(inValue);
            return retVal.logoutRequest;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PersonsClient.PersonService.logoutResponse> PersonsClient.PersonService.PersonManager.logoutAsync(PersonsClient.PersonService.logoutRequest request) {
            return base.Channel.logoutAsync(request);
        }
        
        public System.Threading.Tasks.Task<PersonsClient.PersonService.logoutResponse> logoutAsync(string token) {
            PersonsClient.PersonService.logoutRequest inValue = new PersonsClient.PersonService.logoutRequest();
            inValue.token = token;
            return ((PersonsClient.PersonService.PersonManager)(this)).logoutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PersonsClient.PersonService.searchByNameResponse PersonsClient.PersonService.PersonManager.searchByName(PersonsClient.PersonService.searchByNameRequest request) {
            return base.Channel.searchByName(request);
        }
        
        public PersonsClient.PersonService.person[] searchByName(string name, string token) {
            PersonsClient.PersonService.searchByNameRequest inValue = new PersonsClient.PersonService.searchByNameRequest();
            inValue.name = name;
            inValue.token = token;
            PersonsClient.PersonService.searchByNameResponse retVal = ((PersonsClient.PersonService.PersonManager)(this)).searchByName(inValue);
            return retVal.person;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PersonsClient.PersonService.searchByNameResponse> PersonsClient.PersonService.PersonManager.searchByNameAsync(PersonsClient.PersonService.searchByNameRequest request) {
            return base.Channel.searchByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<PersonsClient.PersonService.searchByNameResponse> searchByNameAsync(string name, string token) {
            PersonsClient.PersonService.searchByNameRequest inValue = new PersonsClient.PersonService.searchByNameRequest();
            inValue.name = name;
            inValue.token = token;
            return ((PersonsClient.PersonService.PersonManager)(this)).searchByNameAsync(inValue);
        }
    }
}
