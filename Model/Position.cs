using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 职位表
    /// </summary>
    public class Position
    {
        /// <summary>
        /// 职位编号
        /// </summary>
        public int P_Id { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        public string P_Name { get; set; }

       /// <summary>
       /// 权限（逗号隔开权限）
       /// </summary>
        public string R_Content { get; set; }
    }
}
