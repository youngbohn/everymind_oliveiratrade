using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEverymind.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=THIAGO_NT\SQLEXPRESS;Initial Catalog=loginOliveiraTrade;Integrated Security=True";
        }
            public SqlConnection conectar()
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                con.Open();
               
                }
            return con;
        }

            public void desconectar()
            {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            }
    }
    }

