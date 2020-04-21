using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    public class conexao      
    {
        SqlConnection con = new SqlConnection();


        //construtor
        public conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-126NEK2\CODE64;Initial Catalog=CODE64_LOTERIA;Integrated Security=True; User Id=sa; Password=toca11";
        }
      

        //metodo conect
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //metodo desconect
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                   
            }
        }
    }
}
