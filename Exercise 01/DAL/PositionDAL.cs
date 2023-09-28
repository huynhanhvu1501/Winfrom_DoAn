using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.DAL
{
    
    public class PositionDAL : DBConnection
    {
        public List<PositionBEL> ReadPosition()
        {
            return Positions.ToList();
        }
        public void DeletePosition(PositionBEL position)
        {
        }
        public void NewPosition(PositionBEL position)
        {
            if (!this.Positions.Any(a => a.PositionId == position.PositionId))
            {
                this.Positions.Add(position);
                this.SaveChanges();
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void EditPosition(PositionBEL position)
        {
        }
    }
}
