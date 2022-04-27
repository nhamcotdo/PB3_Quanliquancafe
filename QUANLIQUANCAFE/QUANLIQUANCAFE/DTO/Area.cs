using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Area
    {
        public string AreaID { get; set; }
        public string AreaName { get; set; }
        public bool Status { get; set; }
        public Area(DataRow dr)
        {
            AreaID = dr["AreaID"].ToString();
            AreaName = dr["AreaName"].ToString();
        }
    }
}
