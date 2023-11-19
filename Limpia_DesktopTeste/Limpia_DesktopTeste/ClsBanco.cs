using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpia_DesktopTeste
{
    public class ClsBanco
    {
        private static string SQL_STRING = @"Password=12345; Persist Security Info=True; User ID=sa; Initial Catalog=Limpia; Data Source=" + Environment.MachineName + "\\SQLSERVER2022"; // SEBASTIAN MUDA DE SQLEXPRESS PARA SQLSERVER2022 E A BEATRIZ O CONTRÁRIO (SENHA TBM!!);

        //SqlConnection cone = new SqlConnection(@"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Limpia; Data Source=" + Environment.MachineName + "\\SQLEXPRESS");
        private string senha;

        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }

        private static string email;

        public string Nome { get; private set; }
        public string IdCargo { get; private set; }

        public ClsBanco()
        {
            senha = "";
        }
        public LoginResult Login()
        {
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            using (SqlCommand cmd = new SqlCommand("login_funcionario", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
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
            private string idPromo = "";
            private string name = "";
            private string desc = "";
            private string codigoPromo = "";

            private DateTime valid_inic = DateTime.Now;
            private DateTime valid_fim = DateTime.Now;

            private int regiao = 0;
            private int publico = 0;

            public string nome { get => name; set => name = value; }
            public string descricao { get => desc; set => desc = value; }
            public string idpromo { get => idPromo; set => idPromo = value; }
            public string codigo { get => codigoPromo; set => codigoPromo = value; }

            public int region { get => regiao; set => regiao = value; }
            public int publ { get => publico; set => publico = value; }

            public DateTime validade_inic { get => valid_inic; set => valid_inic = value; }
            public DateTime validade_fim { get => valid_fim; set => valid_fim = value; }
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
                        list.Add(new Promo { nome = reader.GetString(3), descricao = reader.GetString(4), idpromo = reader.GetInt32(0).ToString(), validade_inic = reader.GetDateTime(5), validade_fim = reader.GetDateTime(6), codigo = reader.GetString(7), region = reader.GetInt32(8), publ = reader.GetInt32(9) });
                    return list;
                }
            }
        }

        public class ObterInfo
        {
            private string name = "";
            private string idcargo = "";

            public string nome { get => name; set => name = value; }
            public string idCargo { get => idcargo; set => idcargo = value; }
        }
        public async Task<List<ObterInfo>> ObterAsync()
        {
            var list = new List<ObterInfo>();
            try
            {
                using (SqlConnection connection = new SqlConnection(SQL_STRING))
                using (SqlCommand cmd = new SqlCommand("select nome,idcargo from tblfunc where email = @Email", connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    await connection.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var info = new ObterInfo
                            {
                                nome = reader.GetString(0),
                                idCargo = reader.GetInt32(1).ToString()
                            };
                            list.Add(info);
                        }
                    }

                    if (list.Any())
                    {
                        Nome = list[0].nome;
                        IdCargo = list[0].idCargo;
                    }
                }
            }
            catch (SqlException ex)
            {
                
            }
            return list;
        }
    }
}
