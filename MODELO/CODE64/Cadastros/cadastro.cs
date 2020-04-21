using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    public class cadastro
    {
        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        

        public cadastro(string nome, string fone)
        {
            //comando sql -- sqlcommand
            cmd.CommandText = "insert into cliente (nome, fone) values (@nome, @fone)";

            //parametros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@fone", fone);


            try
            {
                //conectar -- conexao
                cmd.Connection = conexao.conectar();

                //executar comadno
                cmd.ExecuteNonQuery();

                //deconectar
                conexao.desconectar();

                //mostrar msg erro ou yes
                this.mensagem = "cadastrado com sucesso";



            }
            catch (SqlException e)
            {

                this.mensagem = "Erro ao tentar conexão com o BD";
            }
          
            
            
        }
    }
}
