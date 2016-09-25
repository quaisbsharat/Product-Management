using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Product_Management.DAL
{
    class DataBase
    {
        SqlConnection connect = new SqlConnection(@"Server = DESKTOP-DSMH34A; DataBase= PRODUCT_DB ; Integrated Security = true");
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataTable Table = new DataTable();

        public void Open()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void Close()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }

        public DataTable SelectData(string Procedure , SqlParameter [] Param)
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandText = Procedure;
            Command.CommandType = CommandType.StoredProcedure;
            Command.Connection = connect;

            if(Param != null)
            {
                for(int i = 0; i< Param.Length; i++)
                {
                    Command.Parameters.Add(Param[i]);
                }
            }


        }

    }
}
