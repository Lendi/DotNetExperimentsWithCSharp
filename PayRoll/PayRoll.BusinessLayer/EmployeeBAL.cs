using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayRoll.DataLayer;

namespace PayRoll.BusinessLayer
{
    public class EmployeeBAL
    {
        EmployeeDAO obj = new EmployeeDAO();
        //classes we create in business layer end with BAL -> Business Access Layer
        //method defined in data layer. method called in business layer
        // in business we dont do anything
        //we use Business layer for validating input data and implementing business rules GENERALLY


        public List<Employee> GetEmpDetails()
        {
            return obj.GetEmpDetails();
        }


        public Employee GetEmpById(int eid)
        {
            return obj.GetEmpById(eid);
        }

        public void AddEmployee(Employee objEmployee)
        {
            obj.AddEmployee(objEmployee);
        }

        public void DeleteEmployee(int eid)
        {
            obj.DeleteEmployee(eid);
        }

        public void UpdateEmployee(int eid, Employee objEmployee)
        {
            obj.UpdateEmployee(eid, objEmployee);
        }
    }
}
