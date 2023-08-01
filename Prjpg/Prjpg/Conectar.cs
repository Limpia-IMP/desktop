using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjpg
{

    public class Conectar
    {
        SqlConnection cone = new SqlConnection(@"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=MENTALIA; Data Source=" + Environment.MachineName + "\\SQLEXPRESS");



        private string Pesquisar() {

        }


    }
}
