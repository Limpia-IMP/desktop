    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace Limpia_DesktopTeste
{
    public class ClsBanco
    {
        private static string SQL_STRING = @"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Limpia; Data Source=" + Environment.MachineName + "\\SQLEXPRESS"; // SEBASTIAN MUDA DE SQLEXPRESS PARA SQLSERVER2022 E A BEATRIZ O CONTRÁRIO (SENHA TBM!!);-

        //SqlConnection cone = new SqlConnection(@"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Limpia; Data Source=" + Environment.MachineName + "\\SQLEXPRESS");
        private string senha;

        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }

        private static string email;

        public string Nome { get; private set; }
        public string IdCargo { get; private set; }
        public string status;
        public List<int> idAnuncio = new List<int>();
        public List<int> idDenuncia = new List<int>();
        public string msgCadastro;


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

        public void Cadastrar(string nomeFunc, string emailFunc, string senhaFunc, int codCargo, string rg, string cpf)
        {

            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            using (SqlCommand cmd = new SqlCommand("spCadastroFunc", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nomeFunc);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@idcargo", codCargo);
                cmd.Parameters.AddWithValue("@email", emailFunc);
                cmd.Parameters.AddWithValue("@senha", senhaFunc); // Consider hashing this
                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        msgCadastro = rdr["message"].ToString();
                    }
                }
            }
        }

        public class Avisos
        {
            private int idAviso;
            private int idFunc;
            private string titulo;
            private string texto;
            private DateTime data;

            public int IdAviso { get => idAviso; set => idAviso = value; }
            public int IdFunc { get => idFunc; set => idFunc = value; }
            public string Titulo { get => titulo; set => titulo = value; }
            public string Texto { get => texto; set => texto = value; }
            public DateTime Data { get => data; set => data = value; }
        }

        public List<Avisos> avisosHome()
        {
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            using (SqlCommand cmd = new SqlCommand("select * from tblavisos", connection))
            {
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<Avisos>();
                    while (reader.Read())
                        list.Add(new Avisos {
                            IdAviso = reader.GetInt32(0),
                            IdFunc = reader.GetInt32(1),
                            Titulo = reader.GetString(2),
                            Texto = reader.GetString(3),
                            Data = reader.GetDateTime(4) });
                    return list;
                }
            }
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

        public List<Promo> Promo_Ofertas()
        {
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

        /*idcursos int not null primary key,
    valor decimal not null,
    duracao varchar(10),
    descricao varchar(250),
    categoria varchar(50),
    nome varchar(50)*/

        public class Cursos
        {

            private string idcursos = "";
            private int valor = 0;
            private int duracao = 0;
            private string descri = "";
            private string categoria = "";
            private string nome = "";

            public string Idcursos { get => idcursos; set => idcursos = value; }
            public int Valor { get => valor; set => valor = value; }
            public string Descri { get => descri; set => descri = value; }
            public string Categoria { get => categoria; set => categoria = value; }
            public string Nome { get => nome; set => nome = value; }
            public int Duracao { get => duracao; set => duracao = value; }
        }

        public List<Cursos> cursos()
        {
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            using (SqlCommand cmd = new SqlCommand("select * from tblcursos", connection))
            {
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<Cursos>();
                    while (reader.Read())
                        list.Add(new Cursos { Idcursos = reader.GetString(0), Valor = reader.GetInt32(1), Duracao = reader.GetInt32(2), Descri = reader.GetString(3), Categoria = reader.GetString(4), Nome = reader.GetString(5) });
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
        public List<ObterInfo> ObterAsync()
        {
            var list = new List<ObterInfo>();
            try
            {
                using (SqlConnection connection = new SqlConnection(SQL_STRING))
                using (SqlCommand cmd = new SqlCommand("select nome,idcargo from tblfunc where email = @Email", connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
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
            catch (SqlException)
            {

            }
            return list;
        }
        public class Trabalhos
        {
            private int idAnuncio;
            private String titulo;
            private String nomeContratante;
            private DateTime data;
            private String valor;
            private String cidade;
            private String endereco;
            private String estado;
            private String desc;

            public int IdAnuncio { get => idAnuncio; set => idAnuncio = value; }
            public string Titulo { get => titulo; set => titulo = value; }
            public string NomeContratante { get => nomeContratante; set => nomeContratante = value; }
            public DateTime Data { get => data; set => data = value; }
            public string Valor { get => valor; set => valor = value; }
            public string Cidade { get => cidade; set => cidade = value; }
            public string Endereco { get => endereco; set => endereco = value; }
            public string Estado { get => estado; set => estado = value; }
            public string Desc { get => desc; set => desc = value; }
        }

        public async Task<List<Trabalhos>> trabalhosG()
        {
            var list = new List<Trabalhos>();
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            {
                await connection.OpenAsync();
                using (SqlCommand cmd = new SqlCommand("select idanuncio from tblanuncio_status where status_anuncio = @Status", connection))
                {
                    cmd.Parameters.AddWithValue("@Status", "Aguardando Aprovação");
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            idAnuncio.Add(reader.GetInt32(0));
                        }
                    }
                }

                foreach (var id in idAnuncio)
                {
                    using (SqlCommand cmd2 = new SqlCommand("spBuscarInformacoesAnuncio", connection))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@idanuncio", id);
                        using (var reader2 = await cmd2.ExecuteReaderAsync())
                        {
                            while (await reader2.ReadAsync())
                            {
                                list.Add(new Trabalhos
                                {
                                    IdAnuncio = reader2.GetInt32(0),
                                    Titulo = reader2.GetString(1),
                                    Data = reader2.GetDateTime(2),
                                    Desc = reader2.GetString(4),
                                    Valor = "R$ " + reader2.GetDecimal(3),
                                    NomeContratante = reader2.GetString(5),
                                    Endereco = reader2.GetString(6) + " Nº " + reader2.GetInt32(7) + ", " + reader2.GetString(8),
                                    Cidade = reader2.GetString(9),
                                    Estado = reader2.GetString(10)
                                });
                            }
                        }
                    }
                }
                return list;
            }
        }

        public class AprovarTrabalhos
        {
            public bool IsSuccessful { get; set; }
        }

        public AprovarTrabalhos Aprovacao(int idAnuncioEspecifico)
        {
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            {
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("spAprovarAnuncio", connection))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@idanuncio", idAnuncioEspecifico);
                    cmd2.Parameters.AddWithValue("@status", status);

                    int affectedRows = cmd2.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        // Nenhuma linha afetada, tratar como erro
                        return new AprovarTrabalhos { IsSuccessful = false };
                    }
                }
            }
            return new AprovarTrabalhos { IsSuccessful = true };
        }

        public class Perfils
        {
            private int idDenuncia;
            private byte[] image;
            private string name;
            private string email;
            private string telefone;
            private string genero;
            private string cpf;
            private string rg;
            private DateTime dataNasc;

            private string tipoUser;

            public string Name { get => name; set => name = value; }
            public string Email { get => email; set => email = value; }
            public string Telefone { get => telefone; set => telefone = value; }
            public string Genero { get => genero; set => genero = value; }
            public string Cpf { get => cpf; set => cpf = value; }
            public string Rg { get => rg; set => rg = value; }
            public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
            public byte[] Image { get => image; set => image = value; }
            public string TipoUser { get => tipoUser; set => tipoUser = value; }
            public int IdDenuncia { get => idDenuncia; set => idDenuncia = value; }
        }

        public List<Perfils> perfilsDenunciados()
        {
            var list = new List<Perfils>();
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("select idDenuncia from tblperfil_denunciado", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idDenuncia.Add(reader.GetInt32(0));
                        }
                    }
                }
                foreach (var id in idDenuncia)
                {
                    using (SqlCommand cmd2 = new SqlCommand("spBuscarPerfisDenunciados", connection))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@idDenuncia", id);
                        using (var reader2 = cmd2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                list.Add(new Perfils
                                {
                                    IdDenuncia = reader2.GetInt32(0),
                                    Name = reader2.GetString(1),
                                    Email = reader2.GetString(2),
                                    Telefone = reader2.GetString(3),
                                    TipoUser = reader2.GetString(4),
                                    DataNasc = reader2.GetDateTime(5),
                                    Cpf = reader2.GetString(6),
                                    Rg = reader2.GetString(7),
                                    Genero = reader2.GetString(8),
                                    Image = (byte[])reader2["foto"]
                                });
                            }
                        }
                    }
                }
                return list;
            }
        }

        public class AprovarDenuncias
        {
            public bool IsSuccessful { get; set; }
        }
        public AprovarDenuncias Aprovar_denuncias(int idAnuncioEspecifico)
        {
            using (SqlConnection connection = new SqlConnection(SQL_STRING))
            {
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("spAprovarAnuncio", connection))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@idanuncio", idAnuncioEspecifico);
                    cmd2.Parameters.AddWithValue("@status", status);

                    int affectedRows = cmd2.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        // Nenhuma linha afetada, tratar como erro
                        return new AprovarDenuncias { IsSuccessful = false };
                    }
                }
            }
            return new AprovarDenuncias { IsSuccessful = true };
        }
    }    
}
