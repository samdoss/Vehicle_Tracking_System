﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace MySisEvo.FUP_SR {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FUP_SR.FileUploadServisSoap")]
    public interface FileUploadServisSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/DosyaBoyut", ReplyAction="*")]
        System.IAsyncResult BeginDosyaBoyut(MySisEvo.FUP_SR.DosyaBoyutRequest request, System.AsyncCallback callback, object asyncState);
        
        MySisEvo.FUP_SR.DosyaBoyutResponse EndDosyaBoyut(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/Kaydet", ReplyAction="*")]
        System.IAsyncResult BeginKaydet(MySisEvo.FUP_SR.KaydetRequest request, System.AsyncCallback callback, object asyncState);
        
        MySisEvo.FUP_SR.KaydetResponse EndKaydet(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DosyaBoyutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DosyaBoyut", Namespace="http://tempuri.org/", Order=0)]
        public MySisEvo.FUP_SR.DosyaBoyutRequestBody Body;
        
        public DosyaBoyutRequest() {
        }
        
        public DosyaBoyutRequest(MySisEvo.FUP_SR.DosyaBoyutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DosyaBoyutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FileName;
        
        public DosyaBoyutRequestBody() {
        }
        
        public DosyaBoyutRequestBody(string FileName) {
            this.FileName = FileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DosyaBoyutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DosyaBoyutResponse", Namespace="http://tempuri.org/", Order=0)]
        public MySisEvo.FUP_SR.DosyaBoyutResponseBody Body;
        
        public DosyaBoyutResponse() {
        }
        
        public DosyaBoyutResponse(MySisEvo.FUP_SR.DosyaBoyutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DosyaBoyutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long DosyaBoyutResult;
        
        public DosyaBoyutResponseBody() {
        }
        
        public DosyaBoyutResponseBody(long DosyaBoyutResult) {
            this.DosyaBoyutResult = DosyaBoyutResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KaydetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Kaydet", Namespace="http://tempuri.org/", Order=0)]
        public MySisEvo.FUP_SR.KaydetRequestBody Body;
        
        public KaydetRequest() {
        }
        
        public KaydetRequest(MySisEvo.FUP_SR.KaydetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KaydetRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] Data;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string FileName;
        
        public KaydetRequestBody() {
        }
        
        public KaydetRequestBody(byte[] Data, string FileName) {
            this.Data = Data;
            this.FileName = FileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KaydetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KaydetResponse", Namespace="http://tempuri.org/", Order=0)]
        public MySisEvo.FUP_SR.KaydetResponseBody Body;
        
        public KaydetResponse() {
        }
        
        public KaydetResponse(MySisEvo.FUP_SR.KaydetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KaydetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long KaydetResult;
        
        public KaydetResponseBody() {
        }
        
        public KaydetResponseBody(long KaydetResult) {
            this.KaydetResult = KaydetResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FileUploadServisSoapChannel : MySisEvo.FUP_SR.FileUploadServisSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DosyaBoyutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DosyaBoyutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public long Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KaydetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public KaydetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public long Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileUploadServisSoapClient : System.ServiceModel.ClientBase<MySisEvo.FUP_SR.FileUploadServisSoap>, MySisEvo.FUP_SR.FileUploadServisSoap {
        
        private BeginOperationDelegate onBeginDosyaBoyutDelegate;
        
        private EndOperationDelegate onEndDosyaBoyutDelegate;
        
        private System.Threading.SendOrPostCallback onDosyaBoyutCompletedDelegate;
        
        private BeginOperationDelegate onBeginKaydetDelegate;
        
        private EndOperationDelegate onEndKaydetDelegate;
        
        private System.Threading.SendOrPostCallback onKaydetCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public FileUploadServisSoapClient() {
        }
        
        public FileUploadServisSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileUploadServisSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadServisSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadServisSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<DosyaBoyutCompletedEventArgs> DosyaBoyutCompleted;
        
        public event System.EventHandler<KaydetCompletedEventArgs> KaydetCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MySisEvo.FUP_SR.FileUploadServisSoap.BeginDosyaBoyut(MySisEvo.FUP_SR.DosyaBoyutRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDosyaBoyut(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginDosyaBoyut(string FileName, System.AsyncCallback callback, object asyncState) {
            MySisEvo.FUP_SR.DosyaBoyutRequest inValue = new MySisEvo.FUP_SR.DosyaBoyutRequest();
            inValue.Body = new MySisEvo.FUP_SR.DosyaBoyutRequestBody();
            inValue.Body.FileName = FileName;
            return ((MySisEvo.FUP_SR.FileUploadServisSoap)(this)).BeginDosyaBoyut(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MySisEvo.FUP_SR.DosyaBoyutResponse MySisEvo.FUP_SR.FileUploadServisSoap.EndDosyaBoyut(System.IAsyncResult result) {
            return base.Channel.EndDosyaBoyut(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private long EndDosyaBoyut(System.IAsyncResult result) {
            MySisEvo.FUP_SR.DosyaBoyutResponse retVal = ((MySisEvo.FUP_SR.FileUploadServisSoap)(this)).EndDosyaBoyut(result);
            return retVal.Body.DosyaBoyutResult;
        }
        
        private System.IAsyncResult OnBeginDosyaBoyut(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string FileName = ((string)(inValues[0]));
            return this.BeginDosyaBoyut(FileName, callback, asyncState);
        }
        
        private object[] OnEndDosyaBoyut(System.IAsyncResult result) {
            long retVal = this.EndDosyaBoyut(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDosyaBoyutCompleted(object state) {
            if ((this.DosyaBoyutCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DosyaBoyutCompleted(this, new DosyaBoyutCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DosyaBoyutAsync(string FileName) {
            this.DosyaBoyutAsync(FileName, null);
        }
        
        public void DosyaBoyutAsync(string FileName, object userState) {
            if ((this.onBeginDosyaBoyutDelegate == null)) {
                this.onBeginDosyaBoyutDelegate = new BeginOperationDelegate(this.OnBeginDosyaBoyut);
            }
            if ((this.onEndDosyaBoyutDelegate == null)) {
                this.onEndDosyaBoyutDelegate = new EndOperationDelegate(this.OnEndDosyaBoyut);
            }
            if ((this.onDosyaBoyutCompletedDelegate == null)) {
                this.onDosyaBoyutCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDosyaBoyutCompleted);
            }
            base.InvokeAsync(this.onBeginDosyaBoyutDelegate, new object[] {
                        FileName}, this.onEndDosyaBoyutDelegate, this.onDosyaBoyutCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MySisEvo.FUP_SR.FileUploadServisSoap.BeginKaydet(MySisEvo.FUP_SR.KaydetRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginKaydet(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginKaydet(byte[] Data, string FileName, System.AsyncCallback callback, object asyncState) {
            MySisEvo.FUP_SR.KaydetRequest inValue = new MySisEvo.FUP_SR.KaydetRequest();
            inValue.Body = new MySisEvo.FUP_SR.KaydetRequestBody();
            inValue.Body.Data = Data;
            inValue.Body.FileName = FileName;
            return ((MySisEvo.FUP_SR.FileUploadServisSoap)(this)).BeginKaydet(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MySisEvo.FUP_SR.KaydetResponse MySisEvo.FUP_SR.FileUploadServisSoap.EndKaydet(System.IAsyncResult result) {
            return base.Channel.EndKaydet(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private long EndKaydet(System.IAsyncResult result) {
            MySisEvo.FUP_SR.KaydetResponse retVal = ((MySisEvo.FUP_SR.FileUploadServisSoap)(this)).EndKaydet(result);
            return retVal.Body.KaydetResult;
        }
        
        private System.IAsyncResult OnBeginKaydet(object[] inValues, System.AsyncCallback callback, object asyncState) {
            byte[] Data = ((byte[])(inValues[0]));
            string FileName = ((string)(inValues[1]));
            return this.BeginKaydet(Data, FileName, callback, asyncState);
        }
        
        private object[] OnEndKaydet(System.IAsyncResult result) {
            long retVal = this.EndKaydet(result);
            return new object[] {
                    retVal};
        }
        
        private void OnKaydetCompleted(object state) {
            if ((this.KaydetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.KaydetCompleted(this, new KaydetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void KaydetAsync(byte[] Data, string FileName) {
            this.KaydetAsync(Data, FileName, null);
        }
        
        public void KaydetAsync(byte[] Data, string FileName, object userState) {
            if ((this.onBeginKaydetDelegate == null)) {
                this.onBeginKaydetDelegate = new BeginOperationDelegate(this.OnBeginKaydet);
            }
            if ((this.onEndKaydetDelegate == null)) {
                this.onEndKaydetDelegate = new EndOperationDelegate(this.OnEndKaydet);
            }
            if ((this.onKaydetCompletedDelegate == null)) {
                this.onKaydetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnKaydetCompleted);
            }
            base.InvokeAsync(this.onBeginKaydetDelegate, new object[] {
                        Data,
                        FileName}, this.onEndKaydetDelegate, this.onKaydetCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override MySisEvo.FUP_SR.FileUploadServisSoap CreateChannel() {
            return new FileUploadServisSoapClientChannel(this);
        }
        
        private class FileUploadServisSoapClientChannel : ChannelBase<MySisEvo.FUP_SR.FileUploadServisSoap>, MySisEvo.FUP_SR.FileUploadServisSoap {
            
            public FileUploadServisSoapClientChannel(System.ServiceModel.ClientBase<MySisEvo.FUP_SR.FileUploadServisSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDosyaBoyut(MySisEvo.FUP_SR.DosyaBoyutRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("DosyaBoyut", _args, callback, asyncState);
                return _result;
            }
            
            public MySisEvo.FUP_SR.DosyaBoyutResponse EndDosyaBoyut(System.IAsyncResult result) {
                object[] _args = new object[0];
                MySisEvo.FUP_SR.DosyaBoyutResponse _result = ((MySisEvo.FUP_SR.DosyaBoyutResponse)(base.EndInvoke("DosyaBoyut", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginKaydet(MySisEvo.FUP_SR.KaydetRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("Kaydet", _args, callback, asyncState);
                return _result;
            }
            
            public MySisEvo.FUP_SR.KaydetResponse EndKaydet(System.IAsyncResult result) {
                object[] _args = new object[0];
                MySisEvo.FUP_SR.KaydetResponse _result = ((MySisEvo.FUP_SR.KaydetResponse)(base.EndInvoke("Kaydet", _args, result)));
                return _result;
            }
        }
    }
}