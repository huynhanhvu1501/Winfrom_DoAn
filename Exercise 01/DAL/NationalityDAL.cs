using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class NationalityDAL : DBConnection
    {
        public List<NationalityBEL> ReadNationality()
        {
            return Nationalitys.ToList();
        }
        public void DeleteNationality(NationalityBEL nationality)
        {
        }
        public void NewNationality(NationalityBEL nationality)
        {
            if (!this.Nationalitys.Any(a => a.NationalityId == nationality.NationalityId))
            {
                this.Nationalitys.Add(nationality);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditNationality(NationalityBEL nationality)
        {
        }
    }
}
