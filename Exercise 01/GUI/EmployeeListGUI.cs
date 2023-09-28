using Exercise_01.BAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace Exercise_01.GUI
{
    public partial class EmployeeListGUI : Form
    {
        EmployeeBAL employeeBAL = new EmployeeBAL();
        public EmployeeListGUI()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            List<Employee> employeeList = new List<Employee>();
            Employee emp = new Employee
            {
                BirthDay = DateTime.Today,
                CIDDateOfIssua = DateTime.Today,
                HireDate = DateTime.Today,
                LaborBookIssuedDate = DateTime.Today
            };
            EmployeeGUI employeeGUI = new EmployeeGUI(emp);

            employeeGUI.ShowDialog();
            dgvEmployee.Rows.Add(emp.EmployeeId, emp.EmployeeName, emp.Gender, emp.Married, emp.Phone, emp.Alias, emp.Email, emp.BirthDay, emp.Birthplace, emp.CIDNumber, emp.CIDDateOfIssua, emp.CIDPlaceOfIssua, emp.HomeTown, emp.PermanerAddress, emp.TemporaryAddress, emp.ImageData,
                   emp.Type.TypeNamee, emp.HireDate, emp.Department.DepartmentName, emp.JobTitle.JobTitleName, emp.Position.PositionName, emp.BasicSalary, emp.Coefficient, emp.SalaryLevel, emp.Allowance, emp.LaborBookNumber, emp.LaborBookIssuedDate, emp.LaborBookIssuedPlace, emp.BankAccountNumber, emp.BankName, emp.Education.EducationName, emp.Degree.DegreeName, emp.ForeignLanguage.ForeignLanguageName, emp.ComputerSkills.ComputerSkillsName, emp.Ethnicity.EthnicityName, emp.Nationality.NationalityName, emp.Religion.ReligionName);
            employeeList.Add(emp);
        }


        private void EmployeeListGUI_Load(object sender, EventArgs e)
        {
            List<Employee> ListEmployee = employeeBAL.ReadAllEmployee();
            foreach (Employee emp in ListEmployee)
            {
                dgvEmployee.Rows.Add(emp.EmployeeId, emp.EmployeeName, emp.Gender, emp.Married, emp.Phone, emp.Alias, emp.Email, emp.BirthDay, emp.Birthplace, emp.CIDNumber, emp.CIDDateOfIssua, emp.CIDPlaceOfIssua, emp.HomeTown, emp.PermanerAddress, emp.TemporaryAddress, emp.ImageData,
                    emp.Type.TypeNamee, emp.HireDate, emp.Department.DepartmentName, emp.JobTitle.JobTitleName, emp.Position.PositionName, emp.BasicSalary, emp.Coefficient, emp.SalaryLevel, emp.Allowance, emp.LaborBookNumber, emp.LaborBookIssuedDate, emp.LaborBookIssuedPlace, emp.BankAccountNumber, emp.BankName, emp.Education.EducationName, emp.Degree.DegreeName, emp.ForeignLanguage.ForeignLanguageName, emp.ComputerSkills.ComputerSkillsName, emp.Ethnicity.EthnicityName, emp.Nationality.NationalityName, emp.Religion.ReligionName);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployee.CurrentRow;
            if (row != null)
            {
                Employee emp = new Employee();
                emp.EmployeeId = row.Cells[0].Value.ToString();
                emp.EmployeeName = row.Cells[1].Value.ToString();
                emp.Gender = Convert.ToBoolean(row.Cells[2].Value); // Giả sử cột Gender là boolean
                emp.Married = Convert.ToBoolean(row.Cells[3].Value); // Giả sử cột Married là boolean
                emp.Phone = row.Cells[4].Value.ToString();
                emp.Alias = row.Cells[5].Value.ToString();
                emp.Email = row.Cells[6].Value.ToString();
                emp.BirthDay = Convert.ToDateTime(row.Cells[7].Value); // Giả sử cột BirthDay là ngày tháng
                emp.Birthplace = row.Cells[8].Value.ToString();
                emp.CIDNumber = row.Cells[9].Value.ToString();
                emp.CIDDateOfIssua = Convert.ToDateTime(row.Cells[10].Value); // Giả sử cột CIDDateOfIssua là ngày tháng
                emp.CIDPlaceOfIssua = row.Cells[11].Value.ToString();
                emp.HomeTown = row.Cells[12].Value.ToString();
                emp.PermanerAddress = row.Cells[13].Value.ToString();
                emp.TemporaryAddress = row.Cells[14].Value.ToString();
                emp.ImageData = (byte[])row.Cells[15].Value;
                emp.Type.TypeNamee = row.Cells[16].Value.ToString();
                emp.HireDate = Convert.ToDateTime(row.Cells[17].Value);
                emp.Department.DepartmentName = row.Cells[18].Value.ToString();
                emp.JobTitle.JobTitleName = row.Cells[19].Value.ToString();
                emp.Position.PositionName = row.Cells[20].Value.ToString();
                emp.BasicSalary = Convert.ToDecimal(row.Cells[21].Value);
                emp.Coefficient = Convert.ToDecimal(row.Cells[22].Value);
                emp.SalaryLevel = Convert.ToDecimal(row.Cells[23].Value);
                emp.Allowance = Convert.ToDecimal(row.Cells[24].Value);
                emp.LaborBookNumber = row.Cells[25].Value.ToString();
                emp.LaborBookIssuedDate = Convert.ToDateTime(row.Cells[26].Value);
                emp.LaborBookIssuedPlace = row.Cells[27].Value.ToString();
                emp.BankAccountNumber = row.Cells[28].Value.ToString();
                emp.BankName = row.Cells[29].Value.ToString();
                emp.Education.EducationName = row.Cells[30].Value.ToString();
                emp.Degree.DegreeName = row.Cells[31].Value.ToString();
                emp.ForeignLanguage.ForeignLanguageName = row.Cells[32].Value.ToString();
                emp.ComputerSkills.ComputerSkillsName = row.Cells[33].Value.ToString();
                emp.Ethnicity.EthnicityName = row.Cells[34].Value.ToString();
                emp.Nationality.NationalityName = row.Cells[35].Value.ToString();
                emp.Religion.ReligionName = row.Cells[36].Value.ToString();

                EmployeeGUI employeeGUI = new EmployeeGUI(emp);
                if (employeeGUI.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật thông tin sau khi form EmployeeGUI đóng
                    employeeBAL.EditEmployee(emp);
                    row.Cells[1].Value = emp.EmployeeName;
                    row.Cells[2].Value = emp.Gender;
                    row.Cells[3].Value = emp.Married;
                    row.Cells[4].Value = emp.Phone;
                    row.Cells[5].Value = emp.Alias;
                    row.Cells[6].Value = emp.Email;
                    row.Cells[7].Value = emp.BirthDay;
                    row.Cells[8].Value = emp.Birthplace;
                    row.Cells[9].Value = emp.CIDNumber;
                    row.Cells[10].Value = emp.CIDDateOfIssua;
                    row.Cells[11].Value = emp.CIDPlaceOfIssua;
                    row.Cells[12].Value = emp.HomeTown;
                    row.Cells[13].Value = emp.PermanerAddress;
                    row.Cells[14].Value = emp.TemporaryAddress;
                    row.Cells[15].Value = emp.ImageData;
                    row.Cells[16].Value = emp.Type.TypeNamee;
                    row.Cells[17].Value = emp.HireDate;
                    row.Cells[18].Value = emp.Department.DepartmentName;
                    row.Cells[19].Value = emp.JobTitle.JobTitleName;
                    row.Cells[20].Value = emp.Position.PositionName;
                    row.Cells[21].Value = emp.BasicSalary;
                    row.Cells[22].Value = emp.Coefficient;
                    row.Cells[23].Value = emp.SalaryLevel;
                    row.Cells[24].Value = emp.Allowance;
                    row.Cells[25].Value = emp.LaborBookNumber;
                    row.Cells[26].Value = emp.LaborBookIssuedDate;
                    row.Cells[27].Value = emp.LaborBookIssuedPlace;
                    row.Cells[28].Value = emp.BankAccountNumber;
                    row.Cells[29].Value = emp.BankName;
                    row.Cells[30].Value = emp.Education.EducationName;
                    row.Cells[31].Value = emp.Degree.DegreeName;
                    row.Cells[32].Value = emp.ForeignLanguage.ForeignLanguageName;
                    row.Cells[33].Value = emp.ComputerSkills.ComputerSkillsName;
                    row.Cells[34].Value = emp.Ethnicity.EthnicityName;
                    row.Cells[35].Value = emp.Nationality.NationalityName;
                    row.Cells[36].Value = emp.Religion.ReligionName;
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvEmployee.CurrentRow;

            if (selectedRow != null)
            {
                object employeeIdToDeleteObject = selectedRow.Cells[0].Value;

                if (employeeIdToDeleteObject != null)
                {
                    string employeeIdToDelete = employeeIdToDeleteObject.ToString();

                    DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên có ID: " + employeeIdToDelete + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        Employee empToDelete = new Employee { EmployeeId = employeeIdToDelete };

                        if (employeeBAL != null)
                        {
                            employeeBAL.DeleteEmployee(empToDelete);

                            dgvEmployee.Rows.Remove(selectedRow);

                            MessageBox.Show("Nhân viên có ID: " + employeeIdToDelete + " đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi trong việc truy cập dịch vụ quản lý nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xác định ID của nhân viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

