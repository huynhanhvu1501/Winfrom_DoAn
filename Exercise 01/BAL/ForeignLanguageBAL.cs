using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
   public class ForeignLanguageBAL
    {
        ForeignLanguageDAL dal = new ForeignLanguageDAL();
        public List<ForeignLanguageBEL> ReadForeignLanguageList()
        {
            List<ForeignLanguageBEL> lstForeignLanguage = dal.ReadForeignLanguage();
            return lstForeignLanguage;
        }
        public void NewForeignLanguage(ForeignLanguageBEL foreignLanguage)
        {
            if (!ReadForeignLanguageList().Any(a => a.ForeignLanguageId == foreignLanguage.ForeignLanguageId))
            {
                dal.NewForeignLanguage(foreignLanguage);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteForeignLanguage(ForeignLanguageBEL foreignLanguage)
        {
            dal.DeleteForeignLanguage(foreignLanguage);
        }
        public void EditForeignLanguage(ForeignLanguageBEL foreignLanguage)
        {
            dal.EditForeignLanguage(foreignLanguage);
        }
    }
}
