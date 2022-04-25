using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class KV
    {
        public string MaKV { get; set; }
        public string TenKV { get; set; }
        public bool TrangThai { get; set; }
        public KV(DataRow dr)
        {
            MaKV = dr["MaKV"].ToString();
            TenKV = dr["TenKV"].ToString();
            TrangThai = (bool)dr["TrangThai"];
        }
    }
}
