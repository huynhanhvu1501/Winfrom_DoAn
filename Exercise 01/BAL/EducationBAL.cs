using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class EducationBAL
    {
        EducationDAL dal = new EducationDAL();
        public List<EducationBEL> ReadEducationList()
        {
            List<EducationBEL> lstEducation = dal.ReadEducation();
            return lstEducation;
        }
        public void NewEducation(EducationBEL education)
        {
            if (!ReadEducationList().Any(a => a.EducationId == education.EducationId))
            {
                dal.NewEducation(education);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteEducation(EducationBEL education)
        {
            dal.DeleteEducation(education);
        }
        public void EditEducation(EducationBEL education)
        {
            dal.EditEducation(education);
        }
    }
}
