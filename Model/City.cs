using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 市
    /// </summary>
   public class City
    {
        /// <summary>
        /// 市ID
        /// </summary>
        public int City_Id { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        public string City_Name { get; set; }
        /// <summary>
        /// 省ID
        /// </summary>
        public int Prov_Id { get; set; }
    }
}
