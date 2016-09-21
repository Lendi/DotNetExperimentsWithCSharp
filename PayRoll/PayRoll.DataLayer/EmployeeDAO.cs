using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.DataLayer
{
    public class EmployeeDAO
    {
        PayRollModelDataContext obj = new PayRollModelDataContext();
        //can write actual functionality here


        public List<Employee> GetEmpDetails() {
            return obj.Employees.ToList();        
            //toList converts all objects into List type
        }
        public Employee GetEmpById(int eid) {
            //lambda expression
            Employee objEmployee = obj.Employees.SingleOrDefault(i => i.Eid == eid);
            return objEmployee;
        }
        public void AddEmployee(Employee objEmployee) {
            obj.Employees.InsertOnSubmit(objEmployee);
            obj.SubmitChanges();
        }

        public void DeleteEmployee(int eid)
        {
            Employee objEmployee = obj.Employees.SingleOrDefault(i => i.Eid == eid);
            obj.Employees.DeleteOnSubmit(objEmployee);
            obj.SubmitChanges();
        }

        public void UpdateEmployee(int eid, Employee objEmployee)
        {
            Employee emp = obj.Employees.SingleOrDefault(i => i.Eid == eid);
            emp.Sal = objEmployee.Sal;
            emp.hiredate = objEmployee.hiredate;
            emp.Desig = objEmployee.Desig;
            emp.Ename = objEmployee.Ename;
            emp.Did = objEmployee.Did;
            obj.SubmitChanges();
        }


    }
}
