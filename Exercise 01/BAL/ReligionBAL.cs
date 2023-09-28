using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class ReligionBAL
    {
        ReligionDAL dal = new ReligionDAL();
        public List<ReligionBEL> ReadReligionList()
        {
            List<ReligionBEL> lstReligion = dal.ReadReligion();
            return lstReligion;
        }
        public void NewReligion(ReligionBEL religion)
        {
            if (!ReadReligionList().Any(a => a.ReligionId == religion.ReligionId))
            {
                dal.NewReligion(religion);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteReligion(ReligionBEL religion)
        {
            dal.DeleteReligion(religion);
        }
        public void EditReligion(ReligionBEL religion)
        {
            dal.EditReligion(religion);
        }
    }
}
