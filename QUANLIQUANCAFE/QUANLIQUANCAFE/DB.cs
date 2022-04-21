using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE
{
    public class DB
    {
        private static DB _Instance;
        public static DB Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DB();
                }
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }

        }

        public List<Ban> GetAllListBan()
        {
            List<Ban> list = new List<Ban>();
            list.Add(new Ban() { MaBan = "0001", MaKV = "001", TenBan = "Bàn 1", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0002", MaKV = "001", TenBan = "Bàn 2", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0003", MaKV = "001", TenBan = "Bàn 3", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0004", MaKV = "002", TenBan = "Bàn 4", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0005", MaKV = "002", TenBan = "Bàn 5", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0006", MaKV = "002", TenBan = "Bàn 6", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0007", MaKV = "003", TenBan = "Bàn 7", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0008", MaKV = "004", TenBan = "Bàn 8", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0009", MaKV = "004", TenBan = "Bàn 9", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0010", MaKV = "004", TenBan = "Bàn 10", TrangThai = true, GopBan = null });
            list.Add(new Ban() { MaBan = "0011", MaKV = "005", TenBan = "Bàn 11", TrangThai = true, GopBan = null });
            // add 30 Ban to random KV

            for (int i = 0; i < 30; i++)
            {
                Random rd = new Random();
                // each loop one random value
                int index = rd.Next(0, list.Count);
                list.Add(new Ban() { MaBan = "00" + (i + 12).ToString(), MaKV = list[index].MaKV, TenBan = "Bàn " + (i + 12).ToString(), TrangThai = index % 2 == 0, GopBan = null });
            }

            return list;
        }
        public List<KV> GetAllListKV()
        {
            List<KV> list = new List<KV>();
            list.Add(new KV() { MaKV = "001", TenKV = "Khu vực 1", TrangThai = true });
            list.Add(new KV() { MaKV = "002", TenKV = "Khu vực 2", TrangThai = true });
            list.Add(new KV() { MaKV = "003", TenKV = "Khu vực 3", TrangThai = true });
            list.Add(new KV() { MaKV = "004", TenKV = "Khu vực 4", TrangThai = true });
            list.Add(new KV() { MaKV = "005", TenKV = "Khu vực 5", TrangThai = true });
            return list;
        }
    }
}
