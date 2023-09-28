using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class EthnicityDAL : DBConnection
    {
        public List<EthnicityBEL> ReadEthnicity()
        {
            return Ethnicitys.ToList();
        }
        public void DeleteEthnicity(EthnicityBEL ethnicity)
        {
        }
        public void NewEthnicity(EthnicityBEL ethnicity)
        {
            if (!this.Ethnicitys.Any(a => a.EthnicityId == ethnicity.EthnicityId))
            {
                this.Ethnicitys.Add(ethnicity);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditEthnicity(EthnicityBEL ethnicity)
        {
        }
    }
}
