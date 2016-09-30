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
        SqlConnection connect;

        public DataBase()
        {
            connect = new SqlConnection(@"Server = DONNETPROGRAMMI; DataBase= PRODUCT_DB ; Integrated Security = true"); 
        }
        public void Open()
        {
            if (connect.State == ConnectionState.Open) return;
            connect.Open();
            
        }

        public void Close()
        {
            if (connect.State == ConnectionState.Closed)
                return;
            connect.Close();
        }

        public DataTable SelectData(string Procedure, SqlParameter[] Param=null)
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandText = Procedure;
            Command.CommandType = CommandType.StoredProcedure;
            Command.Connection = connect;

            if (Param != null)
            {
                for (int i = 0; i < Param.Length; i++)
                {
                    Command.Parameters.Add(Param[i]);
                }
            }

          SqlDataAdapter  Adapter = new SqlDataAdapter(Command);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            return Table;
        }


        public void Execute(string Procedure,SqlParameter [] Param=null)
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandText = Procedure;
            Command.CommandType = CommandType.StoredProcedure;
            Command.Connection = connect;

            if(Param != null)
            {
                Command.Parameters.AddRange(Param);
            }

            connect.Open();
            Command.ExecuteNonQuery();
            connect.Close();
        }

    }
}
