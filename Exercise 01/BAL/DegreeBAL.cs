using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class DegreeBAL
    {
        DegreeDAL dal = new DegreeDAL();
        public List<DegreeBEL> ReadDegreeList()
        {
            List<DegreeBEL> lstDegree = dal.ReadDegree();
            return lstDegree;
        }
        public void NewDegree(DegreeBEL degree)
        {
            if (!ReadDegreeList().Any(a => a.DegreeId == degree.DegreeId))
            {
                dal.NewDegree(degree);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteDegree(DegreeBEL degree)
        {
            dal.DeleteDegree(degree);
        }
        public void EditDegree(DegreeBEL degree)
        {
            dal.EditDegree(degree);
        }
    }
}
