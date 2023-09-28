using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class EthnicityBAL
    {
        EthnicityDAL dal = new EthnicityDAL();
        public List<EthnicityBEL> ReadEthnicityList()
        {
            List<EthnicityBEL> lstEthnicity = dal.ReadEthnicity();
            return lstEthnicity;
        }
        public void NewEthnicity(EthnicityBEL ethnicity)
        {
            if (!ReadEthnicityList().Any(a => a.EthnicityId == ethnicity.EthnicityId))
            {
                dal.NewEthnicity(ethnicity);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteEthnicity(EthnicityBEL ethnicity)
        {
            dal.DeleteEthnicity(ethnicity);
        }
        public void EditEthnicity(EthnicityBEL ethnicity)
        {
            dal.EditEthnicity(ethnicity);
        }
    }
}
