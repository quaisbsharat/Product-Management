using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    class CLS_PRODUCT
    {

        //if not work make instance first (Worked)
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataBase data = new DAL.DataBase();
            DataTable dt = data.SelectData("GET_ALL_CATEGORIES", null);
            return dt;
        }

        public void ADD_PRODUCT(string ID_PRODUCT , string LABEL_PRODUCT , int QTE_IN_STOCK , string PRICE, byte [] IMAGE_PRODUCT ,int ID_CAT)
        {

            DAL.DataBase Data = new DAL.DataBase();

            SqlParameter[] Param = new SqlParameter[6];

            Param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar) ;
            Param[0].Value = ID_PRODUCT;

            Param[1] = new SqlParameter("@LABEL", SqlDbType.VarChar, 30);
            Param[1].Value = LABEL_PRODUCT;

            Param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            Param[2].Value = QTE_IN_STOCK;

            Param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            Param[3].Value = PRICE;

            Param[4] = new SqlParameter("@IMAGE_PRODUCT", SqlDbType.Image);
            Param[4].Value = IMAGE_PRODUCT;

            Param[5] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            Param[5].Value = ID_CAT;

            Data.Execute("ADD_PRODUCT", Param);
        }

        public DataTable VerfiyProductID(string ID)
        {
            DAL.DataBase Data = new DAL.DataBase();

            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            DataTable Table = new DataTable();
            Table = Data.SelectData("VerfiyProductID", Param);
            return Table;
        }
    }
}
