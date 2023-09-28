using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class TypeBAL
    {
        TypeDAL dal = new TypeDAL();
        public List<TypeBEL> ReadTypeList()
        {
            List<TypeBEL> lstType = dal.ReadType();
            return lstType;
        }
        public void NewType(TypeBEL type)
        {
            if (!ReadTypeList().Any(a => a.TypeId == type.TypeId))
            {
                dal.NewType(type);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeleteType(TypeBEL type)
        {
            dal.DeleteType(type);
        }
        public void EditType(TypeBEL type)
        {
            dal.EditType(type);
        }
    }
}
