using Exercise_01.BAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_01
{
    public partial class EmployeeGUI : Form
    {
        TypeBAL typeBAL = new TypeBAL();
        DepartmentBAL departmentBAL = new DepartmentBAL();
        JobTitleBAL jobTitleBAL = new JobTitleBAL();
        PositionBAL positionBAL = new PositionBAL();
        EducationBAL educationBAL = new EducationBAL();
        DegreeBAL degreeBAL = new DegreeBAL();
        ForeignLanguageBAL foreignLanguageBAL = new ForeignLanguageBAL();
        ComputerSkillsBAL computerSkillsBAL = new ComputerSkillsBAL();
        EthnicityBAL ethnicityBAL = new EthnicityBAL();
        NationalityBAL nationalityBAL = new NationalityBAL();
        ReligionBAL religionBAL = new ReligionBAL();

        Employee emp;
        public EmployeeGUI()
        {
            InitializeComponent();
        }
        public EmployeeGUI(Employee emp) : this()
        {
            this.emp = emp;
        }

        private void EmployeeGUI_Load(object sender, EventArgs e)
        {
            if (emp != null)
            {
                this.tbId.Text = emp.EmployeeId;
                this.tbName.Text = emp.EmployeeName;
                if (emp.Gender.HasValue)
                {
                    this.cbGender.Checked = emp.Gender.Value;
                }

                if (emp.Married.HasValue)
                {
                    this.cbMarried.Checked = emp.Married.Value;
                }
                this.tbPhone.Text = emp.Phone;
                this.tbAlias.Text = emp.Alias;
                this.tbMail.Text = emp.Email;
                this.dtpBirthday.Value = emp.BirthDay;
                this.tbBirthplace.Text = emp.Birthplace;
                this.tbCIDNumber.Text = emp.CIDNumber;
                this.dtpCIDDate.Value = emp.CIDDateOfIssua;
                this.tbCIDPlace.Text = emp.CIDPlaceOfIssua;
                this.tbHomeTown.Text = emp.HomeTown;
                this.tbPerAddress.Text = emp.PermanerAddress;
                this.tbTempAddress.Text = emp.PermanerAddress;
                if (emp.ImageData != null && emp.ImageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(emp.ImageData))
                    {
                        this.pcImage.Image = Image.FromStream(ms);
                    }
                }
                List<TypeBEL> lstType = typeBAL.ReadTypeList();
                foreach (TypeBEL type in lstType)
                {
                    cbType.Items.Add(type);
                }
                cbType.DisplayMember = "TypeNamee";
                //
                this.dtpHireDate.Value = emp.HireDate;
                //

                List<DepartmentBEL> lstDepartment = departmentBAL.ReadDepartmentList();
                foreach (DepartmentBEL depart in lstDepartment)
                {
                    cbDepart.Items.Add(depart);
                }
                cbDepart.DisplayMember = "DepartmentName";
                //
                List<JobTitleBEL> lstJobTitle = jobTitleBAL.ReadJobTitleList();
                foreach (JobTitleBEL jobTitle in lstJobTitle)
                {
                    cbJob.Items.Add(jobTitle);
                }
                cbJob.DisplayMember = "JobTitleName";
                //
                List<PositionBEL> lstPosition = positionBAL.ReadPositionList();
                foreach (PositionBEL position in lstPosition)
                {
                    cbPosi.Items.Add(position);
                }
                cbPosi.DisplayMember = "PositionName";//
                //
                this.tbBasic.Text = emp.BasicSalary.ToString();
                this.tbCoeffi.Text = emp.Coefficient.ToString();
                this.tbSalary.Text = emp.SalaryLevel.ToString();
                this.tbAllowance.Text = emp.Allowance.ToString();
                this.tbLaborBookNumber.Text = emp.LaborBookNumber;
                this.dtpLaborBookIssuedDate.Value = emp.LaborBookIssuedDate;
                this.tbLaborBookIssuedPlace.Text = emp.LaborBookIssuedPlace;
                this.tbBankNumber.Text = emp.BankAccountNumber;
                this.tbBankName.Text = emp.BankName;
                //
                List<EducationBEL> lstEducation = educationBAL.ReadEducationList();
                foreach (EducationBEL education in lstEducation)
                {
                    cbEdu.Items.Add(education);
                }
                cbEdu.DisplayMember = "EducationName";//
                //
                List<DegreeBEL> lstDegree = degreeBAL.ReadDegreeList();
                foreach (DegreeBEL degree in lstDegree)
                {
                    cbDegr.Items.Add(degree);
                }
                cbDegr.DisplayMember = "DegreeName";
                //
                List<ForeignLanguageBEL> lstForeignLanguage = foreignLanguageBAL.ReadForeignLanguageList();
                foreach (ForeignLanguageBEL foreignLanguage in lstForeignLanguage)
                {
                    cbLanguage.Items.Add(foreignLanguage);
                }
                cbLanguage.DisplayMember = "ForeignLanguageName";
                //
                List<ComputerSkillsBEL> lstComputerSkills = computerSkillsBAL.ReadComputerSkillsList();
                foreach (ComputerSkillsBEL computerSkills in lstComputerSkills)
                {
                    cbComputer.Items.Add(computerSkills);
                }
                cbComputer.DisplayMember = "ComputerSkillsName";
                //
                List<EthnicityBEL> lstEthnicity = ethnicityBAL.ReadEthnicityList();
                foreach (EthnicityBEL ethnicity in lstEthnicity)
                {
                    cbEthnic.Items.Add(ethnicity);
                }
                cbEthnic.DisplayMember = "EthnicityName";
                //
                List<NationalityBEL> lstNationality = nationalityBAL.ReadNationalityList();
                foreach (NationalityBEL nationality in lstNationality)
                {
                    cbNationality.Items.Add(nationality);
                }
                cbNationality.DisplayMember = "NationalityName";
                //
                List<ReligionBEL> lstReligion = religionBAL.ReadReligionList();
                foreach (ReligionBEL religion in lstReligion)
                {
                    cbReligion.Items.Add(religion);
                }
                cbReligion.DisplayMember = "ReligionName";
                //


            }
        }
        
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }

            return null;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            emp.EmployeeId = tbId.Text;
            emp.EmployeeName = tbName.Text;
            emp.Gender = cbGender.Checked;
            emp.Married = cbMarried.Checked;
            emp.Phone = tbPhone.Text;
            emp.Alias = tbAlias.Text;
            emp.Email = tbMail.Text;
            emp.BirthDay = dtpBirthday.Value;
            emp.Birthplace = tbBirthplace.Text;
            emp.CIDNumber = tbCIDNumber.Text;
            emp.CIDDateOfIssua = dtpCIDDate.Value;
            emp.CIDPlaceOfIssua = tbCIDPlace.Text;
            emp.HomeTown = tbHomeTown.Text;
            emp.PermanerAddress = tbPerAddress.Text;
            emp.TemporaryAddress = tbTempAddress.Text;

            if (pcImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Lưu hình ảnh với định dạng JPEG
                    System.Drawing.Imaging.ImageCodecInfo jpegEncoder = GetEncoder(ImageFormat.Jpeg);
                    EncoderParameters encoderParameters = new EncoderParameters(1);
                    encoderParameters.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L); // Chất lượng ảnh 100%

                    pcImage.Image.Save(ms, jpegEncoder, encoderParameters);

                    emp.ImageData = ms.ToArray();
                }

            }
            emp.Type = (TypeBEL)cbType.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.TypeId = emp.Type.TypeId; // Gán TypeId cho emp
            //
            emp.HireDate = dtpHireDate.Value;
            //
            emp.Department = (DepartmentBEL)cbDepart.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.DepartmentId = emp.Department.DepartmentId; // Gán TypeId cho emp
            //
            emp.JobTitle = (JobTitleBEL)cbJob.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.JobTitleId = emp.JobTitle.JobTitleId; // Gán TypeId cho emp
            //
            emp.Position = (PositionBEL)cbPosi.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.PositionId = emp.Position.PositionId; // Gán TypeId cho emp
            //
            decimal basicSalary;
            if (decimal.TryParse(tbBasic.Text, out basicSalary))
            {
                emp.BasicSalary = basicSalary;
            }
            else
            {
            }
            //
            decimal coefficient;
            if (decimal.TryParse(tbCoeffi.Text, out coefficient))
            {
                emp.Coefficient = coefficient;
            }
            else
            {
            }
            //
            decimal salaryLevel;
            if (decimal.TryParse(tbSalary.Text, out salaryLevel))
            {
                emp.SalaryLevel = salaryLevel;
            }
            else
            {
            }
            //
            decimal allowance;
            if (decimal.TryParse(tbAllowance.Text, out allowance))
            {
                emp.Allowance = allowance;
            }
            else
            {
            }
            //
            emp.LaborBookNumber = tbLaborBookNumber.Text;
            emp.LaborBookIssuedDate = dtpLaborBookIssuedDate.Value;
            emp.LaborBookIssuedPlace = tbLaborBookIssuedPlace.Text;
            emp.BankAccountNumber = tbBankNumber.Text;
            emp.BankName = tbBankName.Text;
            //
            emp.Education = (EducationBEL)cbEdu.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.EducationId = emp.Education.EducationId; // Gán TypeId cho emp
            //
            emp.Degree = (DegreeBEL)cbDegr.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.DegreeId = emp.Degree.DegreeId; // Gán TypeId cho emp
                                                
            emp.ForeignLanguage = (ForeignLanguageBEL)cbLanguage.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.ForeignLanguageId = emp.ForeignLanguage.ForeignLanguageId; // Gán TypeId cho emp
                                                                           //
            emp.ComputerSkills = (ComputerSkillsBEL)cbComputer.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.ComputerSkillsId = emp.ComputerSkills.ComputerSkillsId; // Gán TypeId cho emp

            emp.Ethnicity = (EthnicityBEL)cbEthnic.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.EthnicityId = emp.Ethnicity.EthnicityId; // Gán TypeId cho emp

            emp.Nationality = (NationalityBEL)cbNationality.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.NationalityId = emp.Nationality.NationalityId; // Gán TypeId cho emp

            emp.Religion = (ReligionBEL)cbReligion.SelectedItem; // Lấy đối tượng Type từ combobox cbType
            emp.ReligionId = emp.Religion.ReligionId; // Gán TypeId cho emp
            //

            // Thêm dòng sau để đặt DialogResult của form là DialogResult.OK
            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho việc nhập ký tự không phải là số và cũng không phải là ký tự điều khiển (như Backspace)
            }
        }
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho việc nhập ký tự không phải là chữ và cũng không phải là ký tự điều khiển (như Backspace)
            }
        }
        private void tbCIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho việc nhập ký tự không phải là chữ và cũng không phải là ký tự điều khiển (như Backspace)
            }
        }

        private void pcImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif;*.jpeg|All Files|*.*"; // Chỉ chấp nhận các loại tệp ảnh
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Nạp hình ảnh vào PictureBox
                        pcImage.Image = new Bitmap(openFileDialog.FileName);

                        // Thay đổi kích thước hình ảnh
                        pcImage.Image = ResizeImage(pcImage.Image, 179, 193);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void tbBankNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }

        private void tbLaborBookNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }

        private void tbBasic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }

        private void tbCoeffi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }

        private void tbAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }

            private void tbLaborBookIssuedPlace_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào
            }
        }
    }
}
