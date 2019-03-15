using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工信息表
    /// </summary>
   public class Employee
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        public int E_Id { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public string E_Name { get; set; }
        /// <summary>
        /// 员工性别
        /// </summary>
        public int E_Sex { get; set; }
        /// <summary>
        /// 员工年龄
        /// </summary>
        public int E_Age { get; set; }
        /// <summary>
        /// 员工身份证号
        /// </summary>
        public string E_IDCard { get; set; }
        /// <summary>
        /// 员工家庭住址
        /// </summary>
        public string E_Address { get; set; }

        /// <summary>
        /// 员工入职日期
        /// </summary>
        public DateTime E_StartTime { get; set; }
        /// <summary>
        /// 员工离职日期
        /// </summary>
        public DateTime E_EndTime { get; set; }

        /// <summary>
        /// 员工职位ID
        /// </summary>
        public int P_Id { get; set; }
        /// <summary>
        /// 员工联系方式
        /// </summary>
        public string E_Phone { get; set; }
    }
}
