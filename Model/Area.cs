using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 区
    /// </summary>
   public class Area
    {
        /// <summary>
        /// 区ID
        /// </summary>
        public int Area_Id { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        public string Area_Name { get; set; }

        /// <summary>
        /// 市ID
        /// </summary>
        public int City_Id { get; set; }
    }
}
