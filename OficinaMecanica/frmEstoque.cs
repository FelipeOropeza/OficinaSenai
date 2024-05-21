using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OficinaMecanica
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool opcao = txtOpcao.Checked;

            try
            {
                if (!txtNome.Text.Equals(""))
                {
                    if(opcao == false)
                    {
                        Posicao posFunc = new Posicao();
                        posFunc.Nm_pos = txtNome.Text;
                        if (posFunc.insertPosicao())
                        {
                            MessageBox.Show($"A posição {posFunc.Nm_pos} foi cadastrado com sucesso!");
                            txtNome.Clear();
                            txtNome.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel cadastrar a posição!");
                        }
                    }
                    else
                    {
                        Armazem armFunc = new Armazem();
                        armFunc.Des_arm = txtNome.Text;
                        if (armFunc.insertArmazem())
                        {
                            MessageBox.Show($"O armazem {armFunc.Des_arm} foi cadastrado com sucesso!");
                            txtNome.Clear();
                            txtNome.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel cadastrar um armazem!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar estoque: " + ex.Message);
            }
        }
    }
}
