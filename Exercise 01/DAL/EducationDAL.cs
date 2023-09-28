using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class EducationDAL : DBConnection
    {
        public List<EducationBEL> ReadEducation()
        {
            return Educations.ToList();
        }
        public void DeleteEducation(EducationBEL education)
        {
        }
        public void NewEducation(EducationBEL education)
        {
            if (!this.Educations.Any(a => a.EducationId == education.EducationId))
            {
                this.Educations.Add(education);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditEducation(EducationBEL education)
        {
        }
    }
}
