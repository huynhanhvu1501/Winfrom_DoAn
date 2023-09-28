using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class JobTitleBAL
    {
        JobTitleDAL dal = new JobTitleDAL();
        public List<JobTitleBEL> ReadJobTitleList()
        {
            List<JobTitleBEL> lstJobTitle = dal.ReadJobTitle();
            return lstJobTitle;
        }
        public void NewJobTitle(JobTitleBEL jobTitle)
        {
            if (!ReadJobTitleList().Any(a => a.JobTitleId == jobTitle.JobTitleId))
            {
                dal.NewJobTitle(jobTitle);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteJobTitle(JobTitleBEL jobTitle)
        {
            dal.DeleteJobTitle(jobTitle);
        }
        public void EditJobTitle(JobTitleBEL jobTitle)
        {
            dal.EditJobTitle(jobTitle);
        }
    }
}
