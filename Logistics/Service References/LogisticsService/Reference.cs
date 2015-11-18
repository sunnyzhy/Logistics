﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistics.LogisticsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LogisticsService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UserLogin", ReplyAction="http://tempuri.org/IService1/UserLoginResponse")]
        System.Data.DataSet UserLogin(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UserLogin", ReplyAction="http://tempuri.org/IService1/UserLoginResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserLoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifyPassword", ReplyAction="http://tempuri.org/IService1/ModifyPasswordResponse")]
        int ModifyPassword(string userName, string password, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifyPassword", ReplyAction="http://tempuri.org/IService1/ModifyPasswordResponse")]
        System.Threading.Tasks.Task<int> ModifyPasswordAsync(string userName, string password, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProject", ReplyAction="http://tempuri.org/IService1/AddProjectResponse")]
        int AddProject(string userName, string projectName, string projectUses, string machineType, string projectAddress, string customerName, string customerTel, float price, string projectStatus, string projectType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProject", ReplyAction="http://tempuri.org/IService1/AddProjectResponse")]
        System.Threading.Tasks.Task<int> AddProjectAsync(string userName, string projectName, string projectUses, string machineType, string projectAddress, string customerName, string customerTel, float price, string projectStatus, string projectType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBuild", ReplyAction="http://tempuri.org/IService1/GetBuildResponse")]
        System.Data.DataSet GetBuild(string firstLetter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBuild", ReplyAction="http://tempuri.org/IService1/GetBuildResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetBuildAsync(string firstLetter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProject", ReplyAction="http://tempuri.org/IService1/GetProjectResponse")]
        System.Data.DataSet GetProject(string projectStatus, string customerName, string customerTel, string projectAddress, string projectType, string machineType, string startDate, string endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProject", ReplyAction="http://tempuri.org/IService1/GetProjectResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetProjectAsync(string projectStatus, string customerName, string customerTel, string projectAddress, string projectType, string machineType, string startDate, string endDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Logistics.LogisticsService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Logistics.LogisticsService.IService1>, Logistics.LogisticsService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet UserLogin(string userName, string password) {
            return base.Channel.UserLogin(userName, password);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserLoginAsync(string userName, string password) {
            return base.Channel.UserLoginAsync(userName, password);
        }
        
        public int ModifyPassword(string userName, string password, string newPassword) {
            return base.Channel.ModifyPassword(userName, password, newPassword);
        }
        
        public System.Threading.Tasks.Task<int> ModifyPasswordAsync(string userName, string password, string newPassword) {
            return base.Channel.ModifyPasswordAsync(userName, password, newPassword);
        }
        
        public int AddProject(string userName, string projectName, string projectUses, string machineType, string projectAddress, string customerName, string customerTel, float price, string projectStatus, string projectType) {
            return base.Channel.AddProject(userName, projectName, projectUses, machineType, projectAddress, customerName, customerTel, price, projectStatus, projectType);
        }
        
        public System.Threading.Tasks.Task<int> AddProjectAsync(string userName, string projectName, string projectUses, string machineType, string projectAddress, string customerName, string customerTel, float price, string projectStatus, string projectType) {
            return base.Channel.AddProjectAsync(userName, projectName, projectUses, machineType, projectAddress, customerName, customerTel, price, projectStatus, projectType);
        }
        
        public System.Data.DataSet GetBuild(string firstLetter) {
            return base.Channel.GetBuild(firstLetter);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetBuildAsync(string firstLetter) {
            return base.Channel.GetBuildAsync(firstLetter);
        }
        
        public System.Data.DataSet GetProject(string projectStatus, string customerName, string customerTel, string projectAddress, string projectType, string machineType, string startDate, string endDate) {
            return base.Channel.GetProject(projectStatus, customerName, customerTel, projectAddress, projectType, machineType, startDate, endDate);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetProjectAsync(string projectStatus, string customerName, string customerTel, string projectAddress, string projectType, string machineType, string startDate, string endDate) {
            return base.Channel.GetProjectAsync(projectStatus, customerName, customerTel, projectAddress, projectType, machineType, startDate, endDate);
        }
    }
}
