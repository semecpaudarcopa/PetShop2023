using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop2023
{
    public partial class Login : Form
    {
        Conexao fx = new Conexao();
        String consulta;
        DataSet ds;
        public Login()
        {
            InitializeComponent();
            
        }
        private void Limpar()
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            consulta = "select*from usuarios";
            ds = fx.GetData(consulta);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtSenha.Text == "root" && txtUsuario.Text == "root")
                {
                    ADM f1 = new ADM();
                    f1.Show();
                    Hide();
                }
            }
            else
            {
                consulta = "select*from usuarios where username='" + txtUsuario.Text + "' and pass='" +  txtSenha.Text + "' ";
                ds = fx.GetData(consulta);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String função = ds.Tables[0].Rows[0][1].ToString();
                    if (função == "Administrador")
                    {
                        ADM f1 = new ADM();//(txtSenha.Text);
                        f1.Show();
                        Hide();
                    }
                    else if (função == "Loja")
                    {
                        LOJA f1 = new LOJA();
                        f1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
