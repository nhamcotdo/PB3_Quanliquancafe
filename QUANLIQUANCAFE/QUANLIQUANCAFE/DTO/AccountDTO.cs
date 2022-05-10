using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class AccountDTO
    {
        public string StaffID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }
        public AccountDTO(DataRow dr)
        {
            StaffID = dr["StaffID"].ToString();
            Account = dr["Account"].ToString();
            Password = dr["Password"].ToString();
            Role = Convert.ToBoolean(dr["Role"].ToString());
        }
    }
}
