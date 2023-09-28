using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    public class DBConnection : DbContext
    {
        public DBConnection()
            : base("name= HRMDB")
        {
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<TypeBEL> Types { get; set; }
        public DbSet<DepartmentBEL> Departments { get; set; }
        public DbSet<JobTitleBEL> JobTitles { get; set; }
        public DbSet<PositionBEL> Positions { get; set; }
        public DbSet<EducationBEL> Educations { get; set; }
        //
        public DbSet<DegreeBEL> Degrees { get; set; }
        public DbSet<ForeignLanguageBEL> ForeignLanguages { get; set; }
        public DbSet<ComputerSkillsBEL> ComputerSkillss { get; set; }
        public DbSet<EthnicityBEL> Ethnicitys { get; set; }
        public DbSet<NationalityBEL> Nationalitys { get; set; }
        public DbSet<ReligionBEL> Religions { get; set; }
    }
}
