using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Ban
    {
        public string MaBan { get; set; }
        public string MaKV { get; set; }
        public string TenBan { get; set; }
        public bool TrangThai { get; set; }
        public List<string> GopBan { get; set; }

        public Ban(DataRow dr)
        {
            MaBan = dr["MaBan"].ToString();
            MaKV = dr["MaKV"].ToString();
            TenBan = dr["TenBan"].ToString();
            TrangThai = (bool)dr["TrangThai"];
            GopBan = dr["GopBan"].ToString().Split(',').ToList();
        }
    }
}
