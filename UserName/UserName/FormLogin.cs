using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserName
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string password = "admin";

            if (txtUsuario.Text == user & txtSenha.Text == password)
            {
                MessageBox.Show("Acesso Liberado");
                Form1 FormMain = new Form1();
                FormMain.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuário/Senha incorretos");
            }
        }
    }
}
