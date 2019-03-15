using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 权限表
    /// </summary>
   public class Role
    {
      /// <summary>
      /// 权限编号
      /// </summary>
        public int R_Id { get; set; }

       /// <summary>
       /// 权限名称
       /// </summary>
        public string R_Name { get; set; }
    }
}
