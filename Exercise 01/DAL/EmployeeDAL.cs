using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_01.DAL
{
    public class EmployeeDAL :DBConnection
        
    {
        public List<Employee> ReadAllEmployee()
        {
            return employees.ToList();
        }
        public void DeleteEmployee(Employee emp)
        {
            var deleteEmployee = this.employees.Where(c => c.EmployeeId == emp.EmployeeId).FirstOrDefault();
            this.employees.Remove(deleteEmployee);
            this.SaveChanges();
        }
        public void NewEmployee(Employee emp)
        {
            if (!this.employees.Any(c => c.EmployeeId == emp.EmployeeId))
            {
                var type = this.Types.Where(m => m.TypeId == emp.Type.TypeId).FirstOrDefault();
                emp.Type = type;

                var depart = this.Departments.Where(m => m.DepartmentId == emp.Department.DepartmentId).FirstOrDefault();
                emp.Department = depart;
                var jobTitle = this.JobTitles.Where(m => m.JobTitleId == emp.JobTitle.JobTitleId).FirstOrDefault();
                emp.JobTitle = jobTitle;
                var position = this.Positions.Where(m => m.PositionId == emp.Position.PositionId).FirstOrDefault();
                emp.Position = position;

                var education = this.Educations.Where(m => m.EducationId == emp.Education.EducationId).FirstOrDefault();
                emp.Education = education;
                //
                var degree = this.Degrees.Where(m => m.DegreeId == emp.Degree.DegreeId).FirstOrDefault();
                emp.Degree = degree;
                //
                var foreignLanguage = this.ForeignLanguages.Where(m => m.ForeignLanguageId == emp.ForeignLanguage.ForeignLanguageId).FirstOrDefault();
                emp.ForeignLanguage = foreignLanguage;
                //
                var computerSkills = this.ComputerSkillss.Where(m => m.ComputerSkillsId == emp.ComputerSkills.ComputerSkillsId).FirstOrDefault();
                emp.ComputerSkills = computerSkills;
                //
                var ethnicity = this.Ethnicitys.Where(m => m.EthnicityId == emp.Ethnicity.EthnicityId).FirstOrDefault();
                emp.Ethnicity = ethnicity;
                //
                var nationality = this.Nationalitys.Where(m => m.NationalityId == emp.Nationality.NationalityId).FirstOrDefault();
                emp.Nationality = nationality;
                //
                var religion = this.Religions.Where(m => m.ReligionId == emp.Religion.ReligionId).FirstOrDefault();
                emp.Religion = religion;
                //
                this.employees.Add(emp);
                this.SaveChanges();
            }
        }
        
        public void EditEmployee(Employee emp)
        {
            var editEmployee = this.employees.FirstOrDefault(c => c.EmployeeId == emp.EmployeeId);
            if (editEmployee != null)
            {
                this.Entry(editEmployee).CurrentValues.SetValues(emp);
                this.SaveChanges();
            }
            else
            {
               
            }
        }
    }
}
