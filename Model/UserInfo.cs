using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int U_Id { get; set; }
        /// <summary>
        /// 用户名称（昵称）
        /// </summary>
        public string U_Name { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string U_Number{ get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string U_Pwd { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string U_Email { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string U_Phone { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string U_Img { get; set; }
        /// <summary>
        /// 用户职业信息
        /// </summary>
        public string U_Message { get; set; }
     
    }
}
