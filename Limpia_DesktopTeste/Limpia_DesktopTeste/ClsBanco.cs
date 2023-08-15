using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Login() {
            int aff;
            cone.Open();
            SqlCommand sqlCommand = cone.CreateCommand();
            SqlCommand comand = sqlCommand;
            comand.CommandType = CommandType.Text;
            comand.Parameters.AddWithValue("@id", Id);
            comand.Parameters.AddWithValue("@senha", Senha);
            comand.CommandText = "select * from tblFunc where (@id=idfunc and @senha=senha)";
            aff = comand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comand);
            da.Fill(dt);
            cone.Close();
            return aff;
        }
    }
}
