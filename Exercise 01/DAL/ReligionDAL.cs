using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class ReligionDAL : DBConnection
    {
        public List<ReligionBEL> ReadReligion()
        {
            return Religions.ToList();
        }
        public void DeleteReligion(ReligionBEL religion)
        {
        }
        public void NewReligion(ReligionBEL religion)
        {
            if (!this.Religions.Any(a => a.ReligionId == religion.ReligionId))
            {
                this.Religions.Add(religion);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditReligion(ReligionBEL religion)
        {
        }
    }
}
