using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 房屋信息
    /// </summary>
   public class HouseInfo
    {
        /// <summary>
        /// 房屋编号
        /// </summary>
        public int H_Id { get; set; }
        /// <summary>
        /// 房屋名称
        /// </summary>
        public string H_Name { get; set; }
        /// <summary>
        /// 房屋价格
        /// </summary>
        public Double H_Price { get; set; }
        /// <summary>
        /// 房屋大小
        /// </summary>
        public Double H_Size { get; set; }
        /// <summary>
        /// 房屋户型
        /// </summary>
        public int Apartment_Id { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public int Prov_Id { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public int City_Id { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public int Area_Id { get; set; }

        /// <summary>
        /// 房子详细地址
        /// </summary>
        public string H_Address { get; set; }
       /// <summary>
       /// 房子状态  0:空房 1:预约 2:售出
       /// </summary>
        public int H_State { get; set; }

       /// <summary>
       /// 具体信息
       /// </summary>
        public string H_Detailed { get; set; }
        /// <summary>
        /// 房子型号（几室几厅）
        /// </summary>
        public string H_HomeType { get; set; }
    }
}
