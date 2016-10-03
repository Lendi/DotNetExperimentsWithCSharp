using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CalculateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculate" in both code and config file together.
    [ServiceContract]
    public interface ICalculate
    {
        //[OperationContract]
        //void DoWork();
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Mul(int a, int b);

        [OperationContract]
        [FaultContract(typeof(string))]
        int Div(int a, int b);

        //implementing functionality in service class

    }
}
