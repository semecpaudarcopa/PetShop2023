using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetShop2023
{
    public partial class ADM : Form
    {
        String usuario;
        public ADM()
        {
            InitializeComponent();
        }

        public ADM(string text)
        {
            
            Text = text;
        }
        public String ID
        {
            get { return usuario.ToString(); }
        }

        private void btnAddUsuarios_Click(object sender, EventArgs e)
        {
            uC_AddUsuario1.Visible = true;
            uC_AddUsuario1.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ADM_Load(object sender, EventArgs e)
        {

        }
    }
}
