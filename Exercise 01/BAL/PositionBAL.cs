using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
   
    public class PositionBAL
    {
        PositionDAL dal = new PositionDAL();
        public List<PositionBEL> ReadPositionList()
        {
            List<PositionBEL> lstPosition = dal.ReadPosition();
            return lstPosition;
        }
        public void NewPosition(PositionBEL position)
        {
            if (!ReadPositionList().Any(a => a.PositionId == position.PositionId))
            {
                dal.NewPosition(position);
            }
            else
            {
                // Xử lý thông báo lỗi hoặc cách khác tùy theo nhu cầu
            }
        }
        public void DeletePosition(PositionBEL position)
        {
            dal.DeletePosition(position);
        }
        public void EditPosition(PositionBEL position)
        {
            dal.EditPosition(position);
        }
    }
}
