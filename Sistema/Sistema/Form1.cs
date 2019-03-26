using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            /* string login, senha;
             login = txtUsuario.Text;
             senha = txtSenha.Text;
             if(verificarLogin(login, senha))
             {
                 FormMenu telaMenu = new FormMenu();
                 telaMenu.ShowDialog();
                 Sistema.FormLogin.ActiveForm.Visible = false;
             }
             else
             {
                 MessageBox.Show("Login incorreto. Por favor, tente novamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtUsuario.Text = "";
                 txtSenha.Text = "";
             }*/

            Login login = new Login();
            login.setSenha(txtSenha.Text);
            login.setUsuario(txtUsuario.Text);

            if (login.verificarLogin())
            {
                FrmMenu telaMenu = new FrmMenu();
                telaMenu.ShowDialog();
                Sistema.FrmLogin.ActiveForm.Visible = false;

            }
            else
            {
                MessageBox.Show("Login incorreto. Por favor, tente novamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
        }

    }
}
        
    

