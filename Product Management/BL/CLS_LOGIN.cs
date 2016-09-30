using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataBase Dal = new DAL.DataBase();

            SqlParameter[] Param = new SqlParameter[2];

            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;

            Param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            Param[1].Value = PWD;

            DataTable Dt = new DataTable();
            Dt = Dal.SelectData("SP_LOGIN", Param);

            return Dt;
        }
    }
}
