using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class ForeignLanguageDAL : DBConnection
    {
        public List<ForeignLanguageBEL> ReadForeignLanguage()
        {
            return ForeignLanguages.ToList();
        }
        public void DeleteForeignLanguage(ForeignLanguageBEL foreignLanguage)
        {
        }
        public void NewForeignLanguage(ForeignLanguageBEL foreignLanguage)
        {
            if (!this.ForeignLanguages.Any(a => a.ForeignLanguageId == foreignLanguage.ForeignLanguageId))
            {
                this.ForeignLanguages.Add(foreignLanguage);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditForeignLanguage(ForeignLanguageBEL foreignLanguage)
        {
        }
    }
}
