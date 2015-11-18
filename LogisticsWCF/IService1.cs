﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LogisticsWCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet UserLogin(string userName, string password);

        [OperationContract]
        int ModifyPassword(string userName, string password,string newPassword);

        [OperationContract]
        int AddProject(string userName, string projectName, string projectUses, string machineType, string projectAddress, string customerName, string customerTel, float price, string projectStatus, string projectType);

        [OperationContract]
        DataSet GetBuild(string firstLetter);

        [OperationContract]
        DataSet GetProject(string projectStatus, string customerName, string customerTel, string projectAddress, string projectType, string machineType, string startDate, string endDate);
        // TODO: 在此添加您的服务操作
    }


    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
