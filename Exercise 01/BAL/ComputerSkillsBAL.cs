using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class ComputerSkillsBAL
    {
        ComputerSkillsDAL dal = new ComputerSkillsDAL();
        public List<ComputerSkillsBEL> ReadComputerSkillsList()
        {
            List<ComputerSkillsBEL> lstComputerSkills = dal.ReadComputerSkills();
            return lstComputerSkills;
        }
        public void NewComputerSkills(ComputerSkillsBEL computerSkills)
        {
            if (!ReadComputerSkillsList().Any(a => a.ComputerSkillsId == computerSkills.ComputerSkillsId))
            {
                dal.NewComputerSkills(computerSkills);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteComputerSkills(ComputerSkillsBEL computerSkills)
        {
            dal.DeleteComputerSkills(computerSkills);
        }
        public void EditComputerSkills(ComputerSkillsBEL computerSkills)
        {
            dal.EditComputerSkills(computerSkills);
        }
    }
}
