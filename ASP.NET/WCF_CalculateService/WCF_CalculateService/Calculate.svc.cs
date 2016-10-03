using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CalculateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculate" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculate.svc or Calculate.svc.cs at the Solution Explorer and start debugging.
    public class Calculate : ICalculate
    {
        //public void DoWork()
        //{
        //}
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            try {
                return a / b;
            }
            catch (Exception ex) {
                throw new FaultException(ex.Message);
            }
            
        }
    }
}
