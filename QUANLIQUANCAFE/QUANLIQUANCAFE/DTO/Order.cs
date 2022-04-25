using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Order
    {
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        public Order(DataRow dr)
        {
            TenMon = dr["TenMon"].ToString();
            SoLuong = (int)dr["SoLuong"];
            ThanhTien = (int)dr["DonGia"] * SoLuong;
        }
    }
}
