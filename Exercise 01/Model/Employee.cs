using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Model
{
    public class Employee
    {
        [Key, Column(TypeName = "varchar"),MaxLength(50)]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool? Gender { get; set; }
        public bool? Married { get; set; }
        public string Phone { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public string Birthplace { get; set; }
        public string CIDNumber { get; set; }
        public DateTime CIDDateOfIssua { get; set; }
        public string CIDPlaceOfIssua { get; set; }
        public string HomeTown { get; set; }
        public string PermanerAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public byte[] ImageData { get; set; }


        public string TypeId { get; set; }//loại nv
        public virtual TypeBEL Type { get; set; }
        public DateTime HireDate { get; set; }  // Ngày vào làm (kiểu ngày tháng)

        public string DepartmentId { get; set; }  // Phòng ban làm (kiểu chuỗi)
        public virtual DepartmentBEL Department { get; set; }

        public string JobTitleId { get; set; }  // Công việc (kiểu chuỗi)
        public virtual JobTitleBEL JobTitle { get; set; }

        public string PositionId { get; set; }  // Chức vụ (kiểu chuỗi)
        public virtual PositionBEL Position { get; set; }

        public decimal BasicSalary { get; set; }  // Mức lương cơ bản (kiểu số thập phân)

        public decimal Coefficient { get; set; }  // Hệ số (kiểu số thập phân)

        public decimal SalaryLevel { get; set; }  // Mức lương (kiểu số thập phân)

        public decimal Allowance { get; set; }  // Phụ cấp (kiểu số thập phân)

        public string LaborBookNumber { get; set; }  // Số sổ lao động (kiểu chuỗi)

        public DateTime LaborBookIssuedDate { get; set; }  // Ngày làm sổ (kiểu ngày tháng)

        public string LaborBookIssuedPlace { get; set; }  // Nơi cấp sổ (kiểu chuỗi)

        public string BankAccountNumber { get; set; }  // Số tài khoản ngân hàng (kiểu chuỗi)

        public string BankName { get; set; }  // Tên ngân hàng (kiểu chuỗi)

        public string EducationId { get; set; }  // Học vấn (kiểu chuỗi)
        public virtual EducationBEL Education { get; set; }

        public string DegreeId { get; set; }  // Bằng cấp (kiểu chuỗi)
        public virtual DegreeBEL Degree { get; set; }

        public string ForeignLanguageId { get; set; }  // Ngoại ngữ (kiểu chuỗi)
        public virtual ForeignLanguageBEL ForeignLanguage { get; set; }

        public string ComputerSkillsId { get; set; }  // Tin học (kiểu chuỗi)
        public virtual ComputerSkillsBEL ComputerSkills { get; set; }

        public string EthnicityId { get; set; }  // Dân tộc (kiểu chuỗi)
        public virtual EthnicityBEL Ethnicity { get; set; }

        public string NationalityId { get; set; }  // Quốc tịch (kiểu chuỗi)
        public virtual NationalityBEL Nationality { get; set; }

        public string ReligionId { get; set; }  // Tôn giáo (kiểu chuỗi)
        public virtual ReligionBEL Religion { get; set; }
    }
    //1
    public class TypeBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string TypeId { get; set; }
        public string TypeNamee { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    //
    public class DepartmentBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class JobTitleBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class PositionBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string PositionId { get; set; }
        public string PositionName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class EducationBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string EducationId { get; set; }
        public string EducationName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class DegreeBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string DegreeId { get; set; }
        public string DegreeName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class ForeignLanguageBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string ForeignLanguageId { get; set; }
        public string ForeignLanguageName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class ComputerSkillsBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string ComputerSkillsId { get; set; }
        public string ComputerSkillsName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class EthnicityBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string EthnicityId { get; set; }
        public string EthnicityName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class NationalityBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string NationalityId { get; set; }
        public string NationalityName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
    public class ReligionBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string ReligionId { get; set; }
        public string ReligionName { get; set; }
        public virtual List<Employee> employee { get; set; } = new List<Employee>();
    }
}
