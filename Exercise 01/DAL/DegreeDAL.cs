using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class DegreeDAL : DBConnection
    {
        public List<DegreeBEL> ReadDegree()
        {
            return Degrees.ToList();
        }
        public void DeleteDegree(DegreeBEL degree)
        {
        }
        public void NewDegree(DegreeBEL degree)
        {
            if (!this.Degrees.Any(a => a.DegreeId == degree.DegreeId))
            {
                this.Degrees.Add(degree);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditDegree(DegreeBEL degree)
        {
        }
    }
}
