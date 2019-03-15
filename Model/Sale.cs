using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工销售表
    /// </summary>
   public class Sale
    {
       /// <summary>
       /// 销售编号
       /// </summary>
        public int S_Id { get; set; }

       /// <summary>
       /// 员工编号
       /// </summary>
        public int E_Id { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int U_Id { get; set; }

        /// <summary>
        /// 房屋编号
        /// </summary>
        public int H_Id { get; set; }

        /// <summary>
        /// 销售时间
        /// </summary>
        public DateTime S_SaleTime { get; set; }


    }
}
