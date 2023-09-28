using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class DepartmentDAL : DBConnection
    {
        public List<DepartmentBEL> ReadDepartment()
        {
            return Departments.ToList();
        }
        public void DeleteDepartment(DepartmentBEL depart)
        {
        }
        public void NewDepartment(DepartmentBEL depart)
        {
            if (!this.Departments.Any(a => a.DepartmentId == depart.DepartmentId))
            {
                this.Departments.Add(depart);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditDepartment(DepartmentBEL depart)
        {
        }
    }
}
