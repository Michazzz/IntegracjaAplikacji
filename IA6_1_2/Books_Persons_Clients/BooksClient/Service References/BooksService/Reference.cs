﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BooksClient.BooksService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://books.ia5_1/", ConfigurationName="BooksService.BookManager")]
    public interface BookManager {
        
        // CODEGEN: Parameter 'book' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/searchByTitleRequest", ReplyAction="http://books.ia5_1/BookManager/searchByTitleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="book")]
        BooksClient.BooksService.searchByTitleResponse searchByTitle(BooksClient.BooksService.searchByTitleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/searchByTitleRequest", ReplyAction="http://books.ia5_1/BookManager/searchByTitleResponse")]
        System.Threading.Tasks.Task<BooksClient.BooksService.searchByTitleResponse> searchByTitleAsync(BooksClient.BooksService.searchByTitleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/addBookRequest", ReplyAction="http://books.ia5_1/BookManager/addBookResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        BooksClient.BooksService.addBookResponse addBook(BooksClient.BooksService.addBookRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/addBookRequest", ReplyAction="http://books.ia5_1/BookManager/addBookResponse")]
        System.Threading.Tasks.Task<BooksClient.BooksService.addBookResponse> addBookAsync(BooksClient.BooksService.addBookRequest request);
        
        // CODEGEN: Parameter 'book' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/searchByISBNRequest", ReplyAction="http://books.ia5_1/BookManager/searchByISBNResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="book")]
        BooksClient.BooksService.searchByISBNResponse searchByISBN(BooksClient.BooksService.searchByISBNRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/searchByISBNRequest", ReplyAction="http://books.ia5_1/BookManager/searchByISBNResponse")]
        System.Threading.Tasks.Task<BooksClient.BooksService.searchByISBNResponse> searchByISBNAsync(BooksClient.BooksService.searchByISBNRequest request);
        
        // CODEGEN: Parameter 'book' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/searchByPublisherRequest", ReplyAction="http://books.ia5_1/BookManager/searchByPublisherResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="book")]
        BooksClient.BooksService.searchByPublisherResponse searchByPublisher(BooksClient.BooksService.searchByPublisherRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://books.ia5_1/BookManager/searchByPublisherRequest", ReplyAction="http://books.ia5_1/BookManager/searchByPublisherResponse")]
        System.Threading.Tasks.Task<BooksClient.BooksService.searchByPublisherResponse> searchByPublisherAsync(BooksClient.BooksService.searchByPublisherRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://books.ia5_1/")]
    public partial class book : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] authorsField;
        
        private string isbnField;
        
        private int pagesField;
        
        private bool pagesFieldSpecified;
        
        private string publisherField;
        
        private string titleField;
        
        private int yearField;
        
        private bool yearFieldSpecified;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("author", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] authors {
            get {
                return this.authorsField;
            }
            set {
                this.authorsField = value;
                this.RaisePropertyChanged("authors");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string isbn {
            get {
                return this.isbnField;
            }
            set {
                this.isbnField = value;
                this.RaisePropertyChanged("isbn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int pages {
            get {
                return this.pagesField;
            }
            set {
                this.pagesField = value;
                this.RaisePropertyChanged("pages");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pagesSpecified {
            get {
                return this.pagesFieldSpecified;
            }
            set {
                this.pagesFieldSpecified = value;
                this.RaisePropertyChanged("pagesSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string publisher {
            get {
                return this.publisherField;
            }
            set {
                this.publisherField = value;
                this.RaisePropertyChanged("publisher");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
                this.RaisePropertyChanged("year");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yearSpecified {
            get {
                return this.yearFieldSpecified;
            }
            set {
                this.yearFieldSpecified = value;
                this.RaisePropertyChanged("yearSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByTitle", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class searchByTitleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string title;
        
        public searchByTitleRequest() {
        }
        
        public searchByTitleRequest(string title) {
            this.title = title;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByTitleResponse", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class searchByTitleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("book", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooksClient.BooksService.book[] book;
        
        public searchByTitleResponse() {
        }
        
        public searchByTitleResponse(BooksClient.BooksService.book[] book) {
            this.book = book;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addBook", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class addBookRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooksClient.BooksService.book book;
        
        public addBookRequest() {
        }
        
        public addBookRequest(BooksClient.BooksService.book book) {
            this.book = book;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addBookResponse", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class addBookResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooksClient.BooksService.book book;
        
        public addBookResponse() {
        }
        
        public addBookResponse(BooksClient.BooksService.book book) {
            this.book = book;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByISBN", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class searchByISBNRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string isbn;
        
        public searchByISBNRequest() {
        }
        
        public searchByISBNRequest(string isbn) {
            this.isbn = isbn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByISBNResponse", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class searchByISBNResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooksClient.BooksService.book book;
        
        public searchByISBNResponse() {
        }
        
        public searchByISBNResponse(BooksClient.BooksService.book book) {
            this.book = book;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByPublisher", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class searchByPublisherRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string publisher;
        
        public searchByPublisherRequest() {
        }
        
        public searchByPublisherRequest(string publisher) {
            this.publisher = publisher;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchByPublisherResponse", WrapperNamespace="http://books.ia5_1/", IsWrapped=true)]
    public partial class searchByPublisherResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://books.ia5_1/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("book", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooksClient.BooksService.book[] book;
        
        public searchByPublisherResponse() {
        }
        
        public searchByPublisherResponse(BooksClient.BooksService.book[] book) {
            this.book = book;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BookManagerChannel : BooksClient.BooksService.BookManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookManagerClient : System.ServiceModel.ClientBase<BooksClient.BooksService.BookManager>, BooksClient.BooksService.BookManager {
        
        public BookManagerClient() {
        }
        
        public BookManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BooksClient.BooksService.searchByTitleResponse BooksClient.BooksService.BookManager.searchByTitle(BooksClient.BooksService.searchByTitleRequest request) {
            return base.Channel.searchByTitle(request);
        }
        
        public BooksClient.BooksService.book[] searchByTitle(string title) {
            BooksClient.BooksService.searchByTitleRequest inValue = new BooksClient.BooksService.searchByTitleRequest();
            inValue.title = title;
            BooksClient.BooksService.searchByTitleResponse retVal = ((BooksClient.BooksService.BookManager)(this)).searchByTitle(inValue);
            return retVal.book;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BooksClient.BooksService.searchByTitleResponse> BooksClient.BooksService.BookManager.searchByTitleAsync(BooksClient.BooksService.searchByTitleRequest request) {
            return base.Channel.searchByTitleAsync(request);
        }
        
        public System.Threading.Tasks.Task<BooksClient.BooksService.searchByTitleResponse> searchByTitleAsync(string title) {
            BooksClient.BooksService.searchByTitleRequest inValue = new BooksClient.BooksService.searchByTitleRequest();
            inValue.title = title;
            return ((BooksClient.BooksService.BookManager)(this)).searchByTitleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BooksClient.BooksService.addBookResponse BooksClient.BooksService.BookManager.addBook(BooksClient.BooksService.addBookRequest request) {
            return base.Channel.addBook(request);
        }
        
        public void addBook(ref BooksClient.BooksService.book book) {
            BooksClient.BooksService.addBookRequest inValue = new BooksClient.BooksService.addBookRequest();
            inValue.book = book;
            BooksClient.BooksService.addBookResponse retVal = ((BooksClient.BooksService.BookManager)(this)).addBook(inValue);
            book = retVal.book;
        }
        
        public System.Threading.Tasks.Task<BooksClient.BooksService.addBookResponse> addBookAsync(BooksClient.BooksService.addBookRequest request) {
            return base.Channel.addBookAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BooksClient.BooksService.searchByISBNResponse BooksClient.BooksService.BookManager.searchByISBN(BooksClient.BooksService.searchByISBNRequest request) {
            return base.Channel.searchByISBN(request);
        }
        
        public BooksClient.BooksService.book searchByISBN(string isbn) {
            BooksClient.BooksService.searchByISBNRequest inValue = new BooksClient.BooksService.searchByISBNRequest();
            inValue.isbn = isbn;
            BooksClient.BooksService.searchByISBNResponse retVal = ((BooksClient.BooksService.BookManager)(this)).searchByISBN(inValue);
            return retVal.book;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BooksClient.BooksService.searchByISBNResponse> BooksClient.BooksService.BookManager.searchByISBNAsync(BooksClient.BooksService.searchByISBNRequest request) {
            return base.Channel.searchByISBNAsync(request);
        }
        
        public System.Threading.Tasks.Task<BooksClient.BooksService.searchByISBNResponse> searchByISBNAsync(string isbn) {
            BooksClient.BooksService.searchByISBNRequest inValue = new BooksClient.BooksService.searchByISBNRequest();
            inValue.isbn = isbn;
            return ((BooksClient.BooksService.BookManager)(this)).searchByISBNAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BooksClient.BooksService.searchByPublisherResponse BooksClient.BooksService.BookManager.searchByPublisher(BooksClient.BooksService.searchByPublisherRequest request) {
            return base.Channel.searchByPublisher(request);
        }
        
        public BooksClient.BooksService.book[] searchByPublisher(string publisher) {
            BooksClient.BooksService.searchByPublisherRequest inValue = new BooksClient.BooksService.searchByPublisherRequest();
            inValue.publisher = publisher;
            BooksClient.BooksService.searchByPublisherResponse retVal = ((BooksClient.BooksService.BookManager)(this)).searchByPublisher(inValue);
            return retVal.book;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BooksClient.BooksService.searchByPublisherResponse> BooksClient.BooksService.BookManager.searchByPublisherAsync(BooksClient.BooksService.searchByPublisherRequest request) {
            return base.Channel.searchByPublisherAsync(request);
        }
        
        public System.Threading.Tasks.Task<BooksClient.BooksService.searchByPublisherResponse> searchByPublisherAsync(string publisher) {
            BooksClient.BooksService.searchByPublisherRequest inValue = new BooksClient.BooksService.searchByPublisherRequest();
            inValue.publisher = publisher;
            return ((BooksClient.BooksService.BookManager)(this)).searchByPublisherAsync(inValue);
        }
    }
}