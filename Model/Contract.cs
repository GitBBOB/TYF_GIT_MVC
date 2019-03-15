using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 合同表
    /// </summary>
    public class Contract
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int C_Id { get; set; }
        /// <summary>
        /// 合同编号
        /// </summary>
        public string C_Number { get; set; }

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
        /// 签订日期
        /// </summary>
        public DateTime C_SignTime { get; set; }

        /// <summary>
        /// 合同到期日期
        /// </summary>
        public DateTime C_EndTime { get; set; }

        /// <summary>
        /// 电子图片
        /// </summary>
        public string C_Img { get; set; }


    }
}
