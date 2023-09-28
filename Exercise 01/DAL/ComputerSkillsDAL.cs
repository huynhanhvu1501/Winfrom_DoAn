using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class ComputerSkillsDAL : DBConnection
    {
        public List<ComputerSkillsBEL> ReadComputerSkills()
        {
            return ComputerSkillss.ToList();
        }
        public void DeleteComputerSkills(ComputerSkillsBEL computerSkills)
        {
        }
        public void NewComputerSkills(ComputerSkillsBEL computerSkills)
        {
            if (!this.ComputerSkillss.Any(a => a.ComputerSkillsId == computerSkills.ComputerSkillsId))
            {
                this.ComputerSkillss.Add(computerSkills);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditComputerSkills(ComputerSkillsBEL computerSkills)
        {
        }
    }
}
