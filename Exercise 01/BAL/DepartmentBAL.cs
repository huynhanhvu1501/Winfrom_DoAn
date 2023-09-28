using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class DepartmentBAL
    {
        DepartmentDAL dal = new DepartmentDAL();
        public List<DepartmentBEL> ReadDepartmentList()
        {
            List<DepartmentBEL> lstDepartment = dal.ReadDepartment();
            return lstDepartment;
        }
        public void NewDepartment(DepartmentBEL depart)
        {
            if (!ReadDepartmentList().Any(a => a.DepartmentId == depart.DepartmentId))
            {
                dal.NewDepartment(depart);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteDepartment(DepartmentBEL depart)
        {
            dal.DeleteDepartment(depart);
        }
        public void EditDepartment(DepartmentBEL depart)
        {
            dal.EditDepartment(depart);
        }
    }
}
