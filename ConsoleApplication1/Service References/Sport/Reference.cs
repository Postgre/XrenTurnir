﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.Sport {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Sport.ISportService")]
    public interface ISportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISportService/SetData", ReplyAction="http://tempuri.org/ISportService/SetDataResponse")]
        void SetData(WcfLiblary.Data value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISportService/SetData", ReplyAction="http://tempuri.org/ISportService/SetDataResponse")]
        System.Threading.Tasks.Task SetDataAsync(WcfLiblary.Data value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISportServiceChannel : ConsoleApplication1.Sport.ISportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SportServiceClient : System.ServiceModel.ClientBase<ConsoleApplication1.Sport.ISportService>, ConsoleApplication1.Sport.ISportService {
        
        public SportServiceClient() {
        }
        
        public SportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetData(WcfLiblary.Data value) {
            base.Channel.SetData(value);
        }
        
        public System.Threading.Tasks.Task SetDataAsync(WcfLiblary.Data value) {
            return base.Channel.SetDataAsync(value);
        }
    }
}
