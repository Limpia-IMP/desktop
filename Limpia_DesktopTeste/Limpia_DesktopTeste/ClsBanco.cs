using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Limpia_DesktopTeste
{
    class ClsBanco
    {
        private static string SQL_STRING = @"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Limpia; Data Source=" + Environment.MachineName + "\\SQLEXPRESS"; // SEBASTIAN MUDA DE SQLEXPRESS PARA SQLSERVER2022 E A BEATRIZ O CONTRÁRIO (SENHA TBM!!);

        //SqlConnection cone = new SqlConnection(@"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Limpia; Data Source=" + Environment.MachineName + "\\SQLEXPRESS");
        private string senha;

        public string Senha { get => senha; set => senha = value; }
        public string Id { get => id; set => id = value; }
        public string IdPromo { get => idPromo; set => idPromo = value; }

        private string id;

        public ClsBanco()
        {
            senha = "";
            id = "";
        }
        public LoginResult Login()
        {
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            using (SqlCommand cmd = new SqlCommand("login_funcionario", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", id);
                cmd.Parameters.AddWithValue("@senha", senha); // Consider hashing this

                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        string message = rdr["message"].ToString();
                        return new LoginResult
                        {
                            IsSuccessful = message == "Login efetuado com sucesso",
                            Message = message
                        };
                    }
                    else
                    {
                        return new LoginResult
                        {
                            IsSuccessful = false,
                            Message = "Erro desconhecido."
                        };
                    }
                }
            }
        }
        public class LoginResult
        {
            public bool IsSuccessful { get; set; }
            public string Message { get; set; }
        }

        public class Promo
        {
            public string nome { get; set; }
            public string descricao { get; set; }

            public string idpromo { get; set; }

            public string validade { get; set; }
        }
        public List<Promo> Promo_Ofertas() {
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            using (SqlCommand cmd = new SqlCommand("select * from tblpromo", connection))
            {
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<Promo>();
                    while (reader.Read())
                        list.Add(new Promo { nome = reader.GetString(3), descricao = reader.GetString(4), idpromo = reader.GetInt32(0).ToString() });
                    return list;
                }
            }
        }

        private string idPromo = "";
    }
}
