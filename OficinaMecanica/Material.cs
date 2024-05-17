using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica
{
    class Material
    {
        public int Id_mat { get; set; }
        public string Cod_sap { get; set; }
        public string Desc_mat { get; set; }
        public string Uni_mat { get; set; }

        public static DataTable GetMateriais()
        {
            var dt = new DataTable();

            var sql = "select id_mat, cod_sap, desc_mat, uni_mat from tbl_material;";

            try
            {
                using(var cn = new MySql)
            }
        }
    }
}
