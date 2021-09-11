using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;




namespace DataAccessLayer
{

    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=localHost\SQLEXPRESS;Initial Catalog=dbo_YazOkulu;Integrated Security=True");
    }
}
