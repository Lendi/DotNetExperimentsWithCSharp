using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnDatabBindControls.DataLayer
{
    public class EmployeeDAO
    {
        public List<Employee> GetEmployees() {
            using (Model1DataContext obj = new Model1DataContext()) {
                return obj.Employees.ToList();
            } 
        }

        public List<Employee> GetEmpById(int eid) {
            using (Model1DataContext obj = new Model1DataContext()) {
                return obj.Employees.Where(i => i.Eid == eid).ToList();
            }
        }

        public void AddEmployee(Employee objEmployee) {
            using (Model1DataContext obj = new Model1DataContext())
            {
                obj.Employees.InsertOnSubmit(objEmployee);
                obj.SubmitChanges();
            }
        
        
        }

        public void UpdateEmployee(int eid, string ename, string desig, decimal sal, DateTime hiredate, string did)
        {
            using (Model1DataContext obj = new Model1DataContext())
            {
                Employee e1 = obj.Employees.SingleOrDefault(i => i.Eid == eid);
                e1.Ename = ename;
                e1.Sal = sal;
                e1.Desig = desig;
                obj.SubmitChanges();
            }


        }

        public void DeleteEmployee(int eid) {
            using (Model1DataContext obj = new Model1DataContext()) {
                Employee objEmployee = obj.Employees.SingleOrDefault(i => i.Eid == eid);
                obj.Employees.DeleteOnSubmit(objEmployee);
                obj.SubmitChanges();
            }
        
        }

        public void UpdateImage(int eid, string profilepic) {
            using (Model1DataContext obj = new Model1DataContext())
            {
                Employee e1 = obj.Employees.SingleOrDefault(i => i.Eid == eid);
                e1.ProfilePic = profilepic;
                obj.SubmitChanges();
            }
        
        
        }

        //public List<string> GetDeptId() {
        //    using (Model1DataContext obj = new Model1DataContext())
        //    {
        //        return obj.Employees.Select(i => i.Did).Distinct().ToList();
        //    }
        //}


    }
}