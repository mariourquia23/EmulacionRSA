using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebServices_GLT
{
    
    public class RSA_GLT
    {
        
        String connString;
        private String query;

        public Boolean TokenExist(String user, int token)
        {
            connString = "Data Source=74.208.202.242,1433;Initial Catalog=EmulacionRSA;Integrated Security=False;User ID=sa;Password=Firefox0101";
            query = String.Format("select 1 from emulacionrsa.dbo.tokens where usuario ='{0}' and token={1}", user, token);
            SqlDataReader reader = null;
            Boolean result;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand Exec = new SqlCommand(query, conn);
            conn.Open();
            reader = Exec.ExecuteReader();
            //String result = reader.Read().ToString();            
            //int result = Exec.ExecuteNonQuery();
            result = reader.Read();
            conn.Close();

            return result;
                             
        }
        
         





    }
}