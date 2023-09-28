using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class JobTitleDAL : DBConnection
    {
        public List<JobTitleBEL> ReadJobTitle()
        {
            return JobTitles.ToList();
        }
        public void DeleteJobTitle(JobTitleBEL jobTitle)
        {
        }
        public void NewJobTitle(JobTitleBEL jobTitle)
        {
            if (!this.JobTitles.Any(a => a.JobTitleId == jobTitle.JobTitleId))
            {
                this.JobTitles.Add(jobTitle);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditJobTitle(JobTitleBEL jobTitle)
        {
        }
    }
}
