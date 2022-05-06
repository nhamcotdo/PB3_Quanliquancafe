using QUANLIQUANCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLIQUANCAFE.DAL
{
    //Nhâm
    public class DBHelper
    {
        private static DBHelper instance;

        String connectionSTR = @"Data Source=DESKTOP-NHL5EFL\SQLEXPRESS;Initial Catalog=PBL3;User ID=nhamcotdo;Password=06042002";//Nhâm



        SqlConnection cnn;
        private DBHelper()
        {
            cnn = new SqlConnection(connectionSTR);
        }

        public static DBHelper Instance
        {
            get { if (instance == null) instance = new DBHelper(); return instance; }
            private set { instance = value; }
        }

        public void ExecuteDB(string query, SqlParameter[] sqlParameter = null)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            if (sqlParameter != null)
            {
                cmd.Parameters.AddRange(sqlParameter);
            }
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable GetRecords(string sql, SqlParameter[] sqlParameter = null)
        {
            DataTable data = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (sqlParameter != null)
            {
                cmd.Parameters.AddRange(sqlParameter);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cnn.Close();
            return data;
        }


































































































































































        //ĐỨc//219




















































































































































        //Linh//370





































































































































































    }
}//537
