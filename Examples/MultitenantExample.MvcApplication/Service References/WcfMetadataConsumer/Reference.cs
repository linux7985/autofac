﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultitenantExample.MvcApplication.WcfMetadataConsumer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfMetadataConsumer.IMetadataConsumer")]
    public interface IMetadataConsumer {
        
        // CODEGEN: Generating message contract since the operation GetServiceInfo is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetadataConsumer/GetServiceInfo", ReplyAction="http://tempuri.org/IMetadataConsumer/GetServiceInfoResponse")]
        MultitenantExample.MvcApplication.WcfMetadataConsumer.GetServiceInfoResponse GetServiceInfo(MultitenantExample.MvcApplication.WcfMetadataConsumer.GetServiceInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetServiceInfoRequest {
        
        public GetServiceInfoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetServiceInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetServiceInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Guid DependencyInstanceId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string DependencyTypeName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string ServiceImplementationTypeName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string TenantId;
        
        public GetServiceInfoResponse() {
        }
        
        public GetServiceInfoResponse(System.Guid DependencyInstanceId, string DependencyTypeName, string ServiceImplementationTypeName, string TenantId) {
            this.DependencyInstanceId = DependencyInstanceId;
            this.DependencyTypeName = DependencyTypeName;
            this.ServiceImplementationTypeName = ServiceImplementationTypeName;
            this.TenantId = TenantId;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMetadataConsumerChannel : MultitenantExample.MvcApplication.WcfMetadataConsumer.IMetadataConsumer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MetadataConsumerClient : System.ServiceModel.ClientBase<MultitenantExample.MvcApplication.WcfMetadataConsumer.IMetadataConsumer>, MultitenantExample.MvcApplication.WcfMetadataConsumer.IMetadataConsumer {
        
        public MetadataConsumerClient() {
        }
        
        public MetadataConsumerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MetadataConsumerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetadataConsumerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetadataConsumerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MultitenantExample.MvcApplication.WcfMetadataConsumer.GetServiceInfoResponse MultitenantExample.MvcApplication.WcfMetadataConsumer.IMetadataConsumer.GetServiceInfo(MultitenantExample.MvcApplication.WcfMetadataConsumer.GetServiceInfoRequest request) {
            return base.Channel.GetServiceInfo(request);
        }
        
        public System.Guid GetServiceInfo(out string DependencyTypeName, out string ServiceImplementationTypeName, out string TenantId) {
            MultitenantExample.MvcApplication.WcfMetadataConsumer.GetServiceInfoRequest inValue = new MultitenantExample.MvcApplication.WcfMetadataConsumer.GetServiceInfoRequest();
            MultitenantExample.MvcApplication.WcfMetadataConsumer.GetServiceInfoResponse retVal = ((MultitenantExample.MvcApplication.WcfMetadataConsumer.IMetadataConsumer)(this)).GetServiceInfo(inValue);
            DependencyTypeName = retVal.DependencyTypeName;
            ServiceImplementationTypeName = retVal.ServiceImplementationTypeName;
            TenantId = retVal.TenantId;
            return retVal.DependencyInstanceId;
        }
    }
}
