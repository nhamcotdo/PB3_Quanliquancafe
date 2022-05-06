using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DTO
{
    public class Food
    {
        public Food(string dishID, string dishName, int price, string groupID, string sizeID)
        {
            this.DishID = dishID;
            this.DishName = dishName;
            this.Price = price;
            this.GroupID = groupID;
        }
        public Food(DataRow row)
        {
            this.DishID = row["DishID"].ToString();
            this.DishName = row["DishName"].ToString();
            this.Price = (int)row["Price"];
            this.GroupID = row["GroupID"].ToString();
        }

        private string dishID;
        public string DishID
        {
            get { return dishID; }
            set { dishID = value; }
        }
        private string dishName;
        public string DishName
        {
            get { return dishName; }
            set { dishName = value; }

        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string groupID;
        public string GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }
        private string sizeID;
        public string SizeID
        {
            get { return sizeID; }
            set { sizeID = value; }
        }
    }
}