using System;
using System.Data;
using System.Data.SqlClient;

namespace Limpia_DesktopTeste
{
    class ClsBanco
    {
        SqlConnection cone = new SqlConnection(@"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Limpia; Data Source=" + Environment.MachineName + "\\SQLEXPRESS");
        private string senha;

        public string Senha { get => senha; set => senha = value; }
        public string Id { get => id; set => id = value; }

        private string id;

        public ClsBanco()
        {
            senha = "";
            id = "";
        }

        public String Login()
        {
            String aff;
            cone.Open();
            SqlCommand sqlCommand = cone.CreateCommand();
            SqlCommand comand = sqlCommand;

            SqlCommand test = new SqlCommand("login_contratante", cone);
            test.CommandType = CommandType.StoredProcedure;
            test.Parameters.AddWithValue("@email", Id).Value = id;
            test.Parameters.AddWithValue("@senha", Senha).Value = senha;
            SqlDataReader rdr = test.ExecuteReader();
            aff = rdr.ToString();
            cone.Close();
            return aff;
        }
    }
}
