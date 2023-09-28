using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class TypeDAL : DBConnection
    {
        public List<TypeBEL> ReadType()
        {
            return Types.ToList();
        }
        public void DeleteType(TypeBEL type)
        {
        }
        public void NewType(TypeBEL type)
        {
            if (!this.Types.Any(a => a.TypeId == type.TypeId))
            {
                this.Types.Add(type);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditType(TypeBEL type)
        {
        }
    }
}
