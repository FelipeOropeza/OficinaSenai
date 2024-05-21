using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    class Professor
    {
        public int Id_prof { get; set; }
        public string Nm_prof { get; set; }
        public string Sn_prof { get; set; }

        public static DataTable selectProf()
        {
            var dt = new DataTable();

            var sql = "select * from tbl_professor;";

            try
            {
                using (var cn = new MySqlConnection(Conexao.conexao))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;

        }
    }
}
