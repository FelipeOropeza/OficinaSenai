﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    public partial class frmSaidaMat : Form
    {
        DataTable dt = new DataTable();
        public frmSaidaMat()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            dt = Material.selectMovimentacao(true);
            dgvSaidaMat.DataSource = dt;
        }
    }
}
