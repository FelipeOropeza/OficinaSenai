using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    class Turma
    {
        public int Id_tur { get; set; }
        public string Nm_tur { get; set; }
        public int Fk_prof { get; set; }

        public bool insertTurma(string SN)
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(Conexao.conexao);
                MySqlConnection.Open();

                string procedure = $"call spInsertTurmaProf('{Nm_tur}', '{SN}')";

                MySqlCommand comandoSql = MySqlConnection.CreateCommand();
                comandoSql.CommandText = procedure;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método insertTurma: " + ex.Message);
                return false;
            }
        }
    }
}
