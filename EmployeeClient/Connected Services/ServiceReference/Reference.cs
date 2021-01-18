﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        EmployeeClient.ServiceReference.HelloWorldResponse HelloWorld(EmployeeClient.ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.HelloWorldResponse> HelloWorldAsync(EmployeeClient.ServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        EmployeeClient.ServiceReference.LoginResponse Login(EmployeeClient.ServiceReference.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.LoginResponse> LoginAsync(EmployeeClient.ServiceReference.LoginRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginProcess", ReplyAction="*")]
        EmployeeClient.ServiceReference.LoginProcessResponse LoginProcess(EmployeeClient.ServiceReference.LoginProcessRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginProcess", ReplyAction="*")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.LoginProcessResponse> LoginProcessAsync(EmployeeClient.ServiceReference.LoginProcessRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEmployeeID", ReplyAction="*")]
        EmployeeClient.ServiceReference.GetEmployeeIDResponse GetEmployeeID(EmployeeClient.ServiceReference.GetEmployeeIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEmployeeID", ReplyAction="*")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.GetEmployeeIDResponse> GetEmployeeIDAsync(EmployeeClient.ServiceReference.GetEmployeeIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubmitHolidayRequest", ReplyAction="*")]
        void SubmitHolidayRequest(int EmployeeID, System.DateTime startdate, System.DateTime enddate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubmitHolidayRequest", ReplyAction="*")]
        System.Threading.Tasks.Task SubmitHolidayRequestAsync(int EmployeeID, System.DateTime startdate, System.DateTime enddate);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(EmployeeClient.ServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(EmployeeClient.ServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(EmployeeClient.ServiceReference.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(EmployeeClient.ServiceReference.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(bool LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginProcessRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginProcess", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.LoginProcessRequestBody Body;
        
        public LoginProcessRequest() {
        }
        
        public LoginProcessRequest(EmployeeClient.ServiceReference.LoginProcessRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginProcessRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginProcessRequestBody() {
        }
        
        public LoginProcessRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginProcessResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginProcessResponse", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.LoginProcessResponseBody Body;
        
        public LoginProcessResponse() {
        }
        
        public LoginProcessResponse(EmployeeClient.ServiceReference.LoginProcessResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginProcessResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LoginProcessResult;
        
        public LoginProcessResponseBody() {
        }
        
        public LoginProcessResponseBody(bool LoginProcessResult) {
            this.LoginProcessResult = LoginProcessResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEmployeeIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetEmployeeID", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.GetEmployeeIDRequestBody Body;
        
        public GetEmployeeIDRequest() {
        }
        
        public GetEmployeeIDRequest(EmployeeClient.ServiceReference.GetEmployeeIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetEmployeeIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public GetEmployeeIDRequestBody() {
        }
        
        public GetEmployeeIDRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEmployeeIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetEmployeeIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public EmployeeClient.ServiceReference.GetEmployeeIDResponseBody Body;
        
        public GetEmployeeIDResponse() {
        }
        
        public GetEmployeeIDResponse(EmployeeClient.ServiceReference.GetEmployeeIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetEmployeeIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.Nullable<int> GetEmployeeIDResult;
        
        public GetEmployeeIDResponseBody() {
        }
        
        public GetEmployeeIDResponseBody(System.Nullable<int> GetEmployeeIDResult) {
            this.GetEmployeeIDResult = GetEmployeeIDResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : EmployeeClient.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<EmployeeClient.ServiceReference.WebServiceSoap>, EmployeeClient.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmployeeClient.ServiceReference.HelloWorldResponse EmployeeClient.ServiceReference.WebServiceSoap.HelloWorld(EmployeeClient.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            EmployeeClient.ServiceReference.HelloWorldRequest inValue = new EmployeeClient.ServiceReference.HelloWorldRequest();
            inValue.Body = new EmployeeClient.ServiceReference.HelloWorldRequestBody();
            EmployeeClient.ServiceReference.HelloWorldResponse retVal = ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.HelloWorldResponse> EmployeeClient.ServiceReference.WebServiceSoap.HelloWorldAsync(EmployeeClient.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.HelloWorldResponse> HelloWorldAsync() {
            EmployeeClient.ServiceReference.HelloWorldRequest inValue = new EmployeeClient.ServiceReference.HelloWorldRequest();
            inValue.Body = new EmployeeClient.ServiceReference.HelloWorldRequestBody();
            return ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmployeeClient.ServiceReference.LoginResponse EmployeeClient.ServiceReference.WebServiceSoap.Login(EmployeeClient.ServiceReference.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public bool Login(string username, string password) {
            EmployeeClient.ServiceReference.LoginRequest inValue = new EmployeeClient.ServiceReference.LoginRequest();
            inValue.Body = new EmployeeClient.ServiceReference.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            EmployeeClient.ServiceReference.LoginResponse retVal = ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.LoginResponse> EmployeeClient.ServiceReference.WebServiceSoap.LoginAsync(EmployeeClient.ServiceReference.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.LoginResponse> LoginAsync(string username, string password) {
            EmployeeClient.ServiceReference.LoginRequest inValue = new EmployeeClient.ServiceReference.LoginRequest();
            inValue.Body = new EmployeeClient.ServiceReference.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmployeeClient.ServiceReference.LoginProcessResponse EmployeeClient.ServiceReference.WebServiceSoap.LoginProcess(EmployeeClient.ServiceReference.LoginProcessRequest request) {
            return base.Channel.LoginProcess(request);
        }
        
        public bool LoginProcess(string username, string password) {
            EmployeeClient.ServiceReference.LoginProcessRequest inValue = new EmployeeClient.ServiceReference.LoginProcessRequest();
            inValue.Body = new EmployeeClient.ServiceReference.LoginProcessRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            EmployeeClient.ServiceReference.LoginProcessResponse retVal = ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).LoginProcess(inValue);
            return retVal.Body.LoginProcessResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.LoginProcessResponse> EmployeeClient.ServiceReference.WebServiceSoap.LoginProcessAsync(EmployeeClient.ServiceReference.LoginProcessRequest request) {
            return base.Channel.LoginProcessAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.LoginProcessResponse> LoginProcessAsync(string username, string password) {
            EmployeeClient.ServiceReference.LoginProcessRequest inValue = new EmployeeClient.ServiceReference.LoginProcessRequest();
            inValue.Body = new EmployeeClient.ServiceReference.LoginProcessRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).LoginProcessAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EmployeeClient.ServiceReference.GetEmployeeIDResponse EmployeeClient.ServiceReference.WebServiceSoap.GetEmployeeID(EmployeeClient.ServiceReference.GetEmployeeIDRequest request) {
            return base.Channel.GetEmployeeID(request);
        }
        
        public System.Nullable<int> GetEmployeeID(string username, string password) {
            EmployeeClient.ServiceReference.GetEmployeeIDRequest inValue = new EmployeeClient.ServiceReference.GetEmployeeIDRequest();
            inValue.Body = new EmployeeClient.ServiceReference.GetEmployeeIDRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            EmployeeClient.ServiceReference.GetEmployeeIDResponse retVal = ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).GetEmployeeID(inValue);
            return retVal.Body.GetEmployeeIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.GetEmployeeIDResponse> EmployeeClient.ServiceReference.WebServiceSoap.GetEmployeeIDAsync(EmployeeClient.ServiceReference.GetEmployeeIDRequest request) {
            return base.Channel.GetEmployeeIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.GetEmployeeIDResponse> GetEmployeeIDAsync(string username, string password) {
            EmployeeClient.ServiceReference.GetEmployeeIDRequest inValue = new EmployeeClient.ServiceReference.GetEmployeeIDRequest();
            inValue.Body = new EmployeeClient.ServiceReference.GetEmployeeIDRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((EmployeeClient.ServiceReference.WebServiceSoap)(this)).GetEmployeeIDAsync(inValue);
        }
        
        public void SubmitHolidayRequest(int EmployeeID, System.DateTime startdate, System.DateTime enddate) {
            base.Channel.SubmitHolidayRequest(EmployeeID, startdate, enddate);
        }
        
        public System.Threading.Tasks.Task SubmitHolidayRequestAsync(int EmployeeID, System.DateTime startdate, System.DateTime enddate) {
            return base.Channel.SubmitHolidayRequestAsync(EmployeeID, startdate, enddate);
        }
    }
}