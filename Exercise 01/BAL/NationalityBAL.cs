using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class NationalityBAL
    {
        NationalityDAL dal = new NationalityDAL();
        public List<NationalityBEL> ReadNationalityList()
        {
            List<NationalityBEL> lstNationality = dal.ReadNationality();
            return lstNationality;
        }
        public void NewNationality(NationalityBEL nationality)
        {
            if (!ReadNationalityList().Any(a => a.NationalityId == nationality.NationalityId))
            {
                dal.NewNationality(nationality);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteNationality(NationalityBEL nationality)
        {
            dal.DeleteNationality(nationality);
        }
        public void EditNationality(NationalityBEL nationality)
        {
            dal.EditNationality(nationality);
        }
    }
}
