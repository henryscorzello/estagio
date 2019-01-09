using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Now
{
    public class Calc
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;

        public void Main(string[] args)
        {
            double n1, n2, n3, n4, n5;
            double m1, m2, m3, m4;

            n1 = n2 = n3 = n4 = n5 = 0;
            
            m1 = ((n1 * 1) + (n2 * 1.2) + (n3 * 1.4)) / 3.6;
            m2 = (((n1 * 1) + (n2 * 1.2) + (n3 * 1.4) / 3.6)) + (n4 / 2);
            //Aprovado direto
            m3 = n1 + n2 + n3 + (n5 * 2) / 5;
            //Aprovado indireto
            m4 = n1 + n2 + n3 + n4 + (n5 * 2) / 6;

            //Condições
            if (m1 > 6)
            {
                //escreve no banco APROVADO 
                cmd.CommandText = "INSERT INTO Table (Nome, Nota_1) VALUES(Aprovado, @m1)";                
                try
                {
                    cmd.Connection = conexao.conectar();
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                }
                catch (SqlException e)
                {
                    this.mensagem = "erro";
                }
                //Executa m3
            }

            if (m1 < 4)
            {
                //escreve no banco REPROVADO
            }

            if (m1 > 4 && m1 < 6)
            {
                //Executa m2
            }

            if (m2 >= 5)
            {
                //Executa m4
            }
        }
    }
}