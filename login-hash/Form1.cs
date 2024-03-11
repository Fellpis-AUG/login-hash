using Login_Hash;
using System.Data;
using System.Text.RegularExpressions;

namespace login_hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string Usuario, Senha, Email;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //variaveis locais para tratar o usuario e a senha
            string usuario = txtUsuarioLogin.Text;
            string senha = Crypto.sha256encrypt(txtSenhaLogin.Text);

            //percorre cada tabela do banco de dados
            foreach (DataRow row in loginsDataSet.Acessos)
            {
                //e verifica pelo usu�rio e senha que coincidem
                if (row.ItemArray[1].Equals(usuario) && row.ItemArray[2].Equals(senha))
                {
                    txtUsuarioLogin.Text = String.Empty;
                    txtSenhaLogin.Text = String.Empty;
                    MessageBox.Show("Login realizado com sucesso !");
                    break;
                }
                //Se n�o achar ent�o
                else
                {
                    MessageBox.Show("Usu�rio/Senha incorretos");
                    break;
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Confirma a senha
            if (_senha != _confirmaSenha)
            {
                MessageBox.Show("A senha n�o confere.");
            }
            // A senha tem que ter no minimo 8 caracteres
            else if (_senha.Length < 8)
            {
                MessageBox.Show("A senha deve conter no m�nimo 8 caracteres");
            }
            //Se o email n�o for v�lido
            else if (!match.Success)
            {
                MessageBox.Show("Email inv�lido");
            }
            //Se n�o informou o usu�rio
            else if (_nomeUsuario == null)
            {
                MessageBox.Show("VOc� deve informar um usu�rio");
            }
            //Se estiver tudo certo ent�o cria o usu�rio
            else
            {
            }

    }
}
}
