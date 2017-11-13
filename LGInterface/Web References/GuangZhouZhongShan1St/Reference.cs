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

namespace LGInterface.GuangZhouZhongShan1St {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="RequestNoteSoapBinding", Namespace="http://www.gzsums.net/requisition/")]
    public partial class RequestNote : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RequisitionFindOperationCompleted;
        
        private System.Threading.SendOrPostCallback RequisitionAddOperationCompleted;
        
        private System.Threading.SendOrPostCallback RequisitionPayInfoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public RequestNote() {
            this.Url = global::LGInterface.Properties.Settings.Default.LGInterface_GuangZhouZhongShan1St_RequestNote;
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
        public event RequisitionFindCompletedEventHandler RequisitionFindCompleted;
        
        /// <remarks/>
        public event RequisitionAddCompletedEventHandler RequisitionAddCompleted;
        
        /// <remarks/>
        public event RequisitionPayInfoCompletedEventHandler RequisitionPayInfoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net/requisition/RequisitionFind", RequestNamespace="http://www.gzsums.net/requisition/", ResponseNamespace="http://www.gzsums.net/requisition/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response RequisitionFind(Request req) {
            object[] results = this.Invoke("RequisitionFind", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void RequisitionFindAsync(Request req) {
            this.RequisitionFindAsync(req, null);
        }
        
        /// <remarks/>
        public void RequisitionFindAsync(Request req, object userState) {
            if ((this.RequisitionFindOperationCompleted == null)) {
                this.RequisitionFindOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequisitionFindOperationCompleted);
            }
            this.InvokeAsync("RequisitionFind", new object[] {
                        req}, this.RequisitionFindOperationCompleted, userState);
        }
        
        private void OnRequisitionFindOperationCompleted(object arg) {
            if ((this.RequisitionFindCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequisitionFindCompleted(this, new RequisitionFindCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net/requisition/RequisitionAdd", RequestNamespace="http://www.gzsums.net/requisition/", ResponseNamespace="http://www.gzsums.net/requisition/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response RequisitionAdd(Request req) {
            object[] results = this.Invoke("RequisitionAdd", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void RequisitionAddAsync(Request req) {
            this.RequisitionAddAsync(req, null);
        }
        
        /// <remarks/>
        public void RequisitionAddAsync(Request req, object userState) {
            if ((this.RequisitionAddOperationCompleted == null)) {
                this.RequisitionAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequisitionAddOperationCompleted);
            }
            this.InvokeAsync("RequisitionAdd", new object[] {
                        req}, this.RequisitionAddOperationCompleted, userState);
        }
        
        private void OnRequisitionAddOperationCompleted(object arg) {
            if ((this.RequisitionAddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequisitionAddCompleted(this, new RequisitionAddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net/requisition/RequisitionPayInfo", RequestNamespace="http://www.gzsums.net/requisition/", ResponseNamespace="http://www.gzsums.net/requisition/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response RequisitionPayInfo(Request req) {
            object[] results = this.Invoke("RequisitionPayInfo", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void RequisitionPayInfoAsync(Request req) {
            this.RequisitionPayInfoAsync(req, null);
        }
        
        /// <remarks/>
        public void RequisitionPayInfoAsync(Request req, object userState) {
            if ((this.RequisitionPayInfoOperationCompleted == null)) {
                this.RequisitionPayInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequisitionPayInfoOperationCompleted);
            }
            this.InvokeAsync("RequisitionPayInfo", new object[] {
                        req}, this.RequisitionPayInfoOperationCompleted, userState);
        }
        
        private void OnRequisitionPayInfoOperationCompleted(object arg) {
            if ((this.RequisitionPayInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequisitionPayInfoCompleted(this, new RequisitionPayInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/requisition/")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/requisition/")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/requisition/")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net/requisition/")]
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
    public delegate void RequisitionFindCompletedEventHandler(object sender, RequisitionFindCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequisitionFindCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RequisitionFindCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void RequisitionAddCompletedEventHandler(object sender, RequisitionAddCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequisitionAddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RequisitionAddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void RequisitionPayInfoCompletedEventHandler(object sender, RequisitionPayInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequisitionPayInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RequisitionPayInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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