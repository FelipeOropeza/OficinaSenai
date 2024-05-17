using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    class Material
    {
        public int Id_mat { get; set; }
        public string Cod_sap { get; set; }
        public string Desc_mat { get; set; }
        public string Uni_mat { get; set; }

        public static DataTable GetMateriais(bool ativos)
        {
            var dt = new DataTable();

            var sql = "select * from vwMatLocaliza;";

            try
            {
                using(var cn = new MySqlConnection(Conexao.conexao))
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
