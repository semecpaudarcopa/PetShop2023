using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop2023.Administradores
{
    
    public partial class UC_AddUsuario : UserControl
    {
        Conexao fx = new Conexao();
        String consulta;
        public UC_AddUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String funcao = cbFuncao.Text;
            String Nome = txtNome.Text;
            String data = DateTimePicker.Text;
            Int64 fone = Int64.Parse(txtTelefone.Text);
            String email = txtEmail.Text;
            String usuario = txtUsuario.Text;
            String passe = txtSenha.Text;


            try
            {
                consulta = "insert into usuarios(userRole,nome,dob,celular,email,username,pass) values ('" + funcao + "','" + Nome + "','" + data + "'," + fone + ", '" + email + "','" + usuario + "','" + passe + "' )";
                fx.SetData(consulta, "Inscrito com sucesso");
                Limpar1();
            }
            catch (Exception)
            {
                MessageBox.Show("Usuário já cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar1();
            }
        }

        private void Limpar1()
        {
            cbFuncao.SelectedIndex = -1;
            txtNome.Clear();
            DateTimePicker.ResetText();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            consulta = "select*from usuarios where username='" + txtUsuario.Text + "'";
            DataSet ds = fx.GetData(consulta);

            if (ds.Tables[0].Rows.Count == 0)
            {
                ptUsuario.ImageLocation = @"C:\Users\lindebergue\source\repos\PetShop2023\Resources\yes.ICO";

            }
            else
            {
                ptUsuario.ImageLocation = @"C:\Users\lindebergue\source\repos\PetShop2023\Resources\no.jpg";
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            consulta = "select*from usuarios where nome='" + txtNome.Text + "'";
            DataSet ds = fx.GetData(consulta);

            if (ds.Tables[0].Rows.Count == 0)
            {
                ptNome.ImageLocation = @"C:\Users\lindebergue\source\repos\PetShop2023\Resources\yes.ICO";

            }
            else
            {
                ptNome.ImageLocation = @"C:\Users\lindebergue\source\repos\PetShop2023\Resources\no.jpg";
            }
        }
    }
}
