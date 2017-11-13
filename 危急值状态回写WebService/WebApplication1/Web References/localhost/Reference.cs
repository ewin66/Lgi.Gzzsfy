﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace LangJia.Service.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback CrisisAddOperationCompleted;
        
        private System.Threading.SendOrPostCallback CrisisUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback CrisisStatusFeedbackOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::LangJia.Service.Properties.Settings.Default.LangJia_Service_localhost_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event CrisisAddCompletedEventHandler CrisisAddCompleted;
        
        /// <remarks/>
        public event CrisisUpdateCompletedEventHandler CrisisUpdateCompleted;
        
        /// <remarks/>
        public event CrisisStatusFeedbackCompletedEventHandler CrisisStatusFeedbackCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CrisisAdd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response CrisisAdd(Request req) {
            object[] results = this.Invoke("CrisisAdd", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void CrisisAddAsync(Request req) {
            this.CrisisAddAsync(req, null);
        }
        
        /// <remarks/>
        public void CrisisAddAsync(Request req, object userState) {
            if ((this.CrisisAddOperationCompleted == null)) {
                this.CrisisAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCrisisAddOperationCompleted);
            }
            this.InvokeAsync("CrisisAdd", new object[] {
                        req}, this.CrisisAddOperationCompleted, userState);
        }
        
        private void OnCrisisAddOperationCompleted(object arg) {
            if ((this.CrisisAddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CrisisAddCompleted(this, new CrisisAddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CrisisUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response CrisisUpdate(Request req) {
            object[] results = this.Invoke("CrisisUpdate", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void CrisisUpdateAsync(Request req) {
            this.CrisisUpdateAsync(req, null);
        }
        
        /// <remarks/>
        public void CrisisUpdateAsync(Request req, object userState) {
            if ((this.CrisisUpdateOperationCompleted == null)) {
                this.CrisisUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCrisisUpdateOperationCompleted);
            }
            this.InvokeAsync("CrisisUpdate", new object[] {
                        req}, this.CrisisUpdateOperationCompleted, userState);
        }
        
        private void OnCrisisUpdateOperationCompleted(object arg) {
            if ((this.CrisisUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CrisisUpdateCompleted(this, new CrisisUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CrisisStatusFeedback", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response CrisisStatusFeedback(Request req) {
            object[] results = this.Invoke("CrisisStatusFeedback", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void CrisisStatusFeedbackAsync(Request req) {
            this.CrisisStatusFeedbackAsync(req, null);
        }
        
        /// <remarks/>
        public void CrisisStatusFeedbackAsync(Request req, object userState) {
            if ((this.CrisisStatusFeedbackOperationCompleted == null)) {
                this.CrisisStatusFeedbackOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCrisisStatusFeedbackOperationCompleted);
            }
            this.InvokeAsync("CrisisStatusFeedback", new object[] {
                        req}, this.CrisisStatusFeedbackOperationCompleted, userState);
        }
        
        private void OnCrisisStatusFeedbackOperationCompleted(object arg) {
            if ((this.CrisisStatusFeedbackCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CrisisStatusFeedbackCompleted(this, new CrisisStatusFeedbackCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/crisisValue/")]
    public partial class Request {
        
        private RequestHeader requestHeaderField;
        
        private string requestBodyField;
        
        /// <remarks/>
        public RequestHeader requestHeader {
            get {
                return this.requestHeaderField;
            }
            set {
                this.requestHeaderField = value;
            }
        }
        
        /// <remarks/>
        public string requestBody {
            get {
                return this.requestBodyField;
            }
            set {
                this.requestBodyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/crisisValue/")]
    public partial class RequestHeader {
        
        private string senderField;
        
        private string receiverField;
        
        private string requestTimeField;
        
        private string msgTypeField;
        
        private string msgIdField;
        
        private string msgPriorityField;
        
        private string msgVersionField;
        
        /// <remarks/>
        public string sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        public string receiver {
            get {
                return this.receiverField;
            }
            set {
                this.receiverField = value;
            }
        }
        
        /// <remarks/>
        public string requestTime {
            get {
                return this.requestTimeField;
            }
            set {
                this.requestTimeField = value;
            }
        }
        
        /// <remarks/>
        public string msgType {
            get {
                return this.msgTypeField;
            }
            set {
                this.msgTypeField = value;
            }
        }
        
        /// <remarks/>
        public string msgId {
            get {
                return this.msgIdField;
            }
            set {
                this.msgIdField = value;
            }
        }
        
        /// <remarks/>
        public string msgPriority {
            get {
                return this.msgPriorityField;
            }
            set {
                this.msgPriorityField = value;
            }
        }
        
        /// <remarks/>
        public string msgVersion {
            get {
                return this.msgVersionField;
            }
            set {
                this.msgVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/crisisValue/")]
    public partial class ResponseHeader {
        
        private string senderField;
        
        private string receiverField;
        
        private string requestTimeField;
        
        private string msgTypeField;
        
        private string msgIdField;
        
        private string msgPriorityField;
        
        private string msgVersionField;
        
        private string errCodeField;
        
        private string errMessageField;
        
        /// <remarks/>
        public string sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        public string receiver {
            get {
                return this.receiverField;
            }
            set {
                this.receiverField = value;
            }
        }
        
        /// <remarks/>
        public string requestTime {
            get {
                return this.requestTimeField;
            }
            set {
                this.requestTimeField = value;
            }
        }
        
        /// <remarks/>
        public string msgType {
            get {
                return this.msgTypeField;
            }
            set {
                this.msgTypeField = value;
            }
        }
        
        /// <remarks/>
        public string msgId {
            get {
                return this.msgIdField;
            }
            set {
                this.msgIdField = value;
            }
        }
        
        /// <remarks/>
        public string msgPriority {
            get {
                return this.msgPriorityField;
            }
            set {
                this.msgPriorityField = value;
            }
        }
        
        /// <remarks/>
        public string msgVersion {
            get {
                return this.msgVersionField;
            }
            set {
                this.msgVersionField = value;
            }
        }
        
        /// <remarks/>
        public string errCode {
            get {
                return this.errCodeField;
            }
            set {
                this.errCodeField = value;
            }
        }
        
        /// <remarks/>
        public string errMessage {
            get {
                return this.errMessageField;
            }
            set {
                this.errMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/crisisValue/")]
    public partial class Response {
        
        private ResponseHeader responseHeaderField;
        
        private string responseBodyField;
        
        /// <remarks/>
        public ResponseHeader responseHeader {
            get {
                return this.responseHeaderField;
            }
            set {
                this.responseHeaderField = value;
            }
        }
        
        /// <remarks/>
        public string responseBody {
            get {
                return this.responseBodyField;
            }
            set {
                this.responseBodyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void CrisisAddCompletedEventHandler(object sender, CrisisAddCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CrisisAddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CrisisAddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void CrisisUpdateCompletedEventHandler(object sender, CrisisUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CrisisUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CrisisUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void CrisisStatusFeedbackCompletedEventHandler(object sender, CrisisStatusFeedbackCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CrisisStatusFeedbackCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CrisisStatusFeedbackCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591