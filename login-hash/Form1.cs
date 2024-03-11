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
                //e verifica pelo usuário e senha que coincidem
                if (row.ItemArray[1].Equals(usuario) && row.ItemArray[2].Equals(senha))
                {
                    txtUsuarioLogin.Text = String.Empty;
                    txtSenhaLogin.Text = String.Empty;
                    MessageBox.Show("Login realizado com sucesso !");
                    break;
                }
                //Se não achar então
                else
                {
                    MessageBox.Show("Usuário/Senha incorretos");
                    break;
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Confirma a senha
            if (_senha != _confirmaSenha)
            {
                MessageBox.Show("A senha não confere.");
            }
            // A senha tem que ter no minimo 8 caracteres
            else if (_senha.Length < 8)
            {
                MessageBox.Show("A senha deve conter no mínimo 8 caracteres");
            }
            //Se o email não for válido
            else if (!match.Success)
            {
                MessageBox.Show("Email inválido");
            }
            //Se não informou o usuário
            else if (_nomeUsuario == null)
            {
                MessageBox.Show("VOcê deve informar um usuário");
            }
            //Se estiver tudo certo então cria o usuário
            else
            {
            }

    }
}
}
