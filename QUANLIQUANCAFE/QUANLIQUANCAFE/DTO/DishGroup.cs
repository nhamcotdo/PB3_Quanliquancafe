using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class DishGroup
    {
        public DishGroup(string groupID, string groupName)
        {
            this.GroupID = groupID;
            this.GroupName = groupName;
        }
        public DishGroup(DataRow row)
        {
            this.GroupID = row["GroupID"].ToString();
            this.GroupName = row["GroupName"].ToString();

        }

        private string groupID;
        public string GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }
        private string groupName;
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
    }
}