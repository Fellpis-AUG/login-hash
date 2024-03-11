namespace login_hash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            login = new TabPage();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            Usuario = new Label();
            Senha = new Label();
            registro = new TabPage();
            pictureBox2 = new PictureBox();
            btnRegistro = new Button();
            texEmail = new TextBox();
            texSenha = new TextBox();
            texConfirmarSenha = new TextBox();
            texUsuario = new TextBox();
            Email = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BancoDeDados = new TabPage();
            configuração = new TabPage();
            tabControl1.SuspendLayout();
            login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(login);
            tabControl1.Controls.Add(registro);
            tabControl1.Controls.Add(BancoDeDados);
            tabControl1.Controls.Add(configuração);
            tabControl1.Location = new Point(21, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(351, 215);
            tabControl1.TabIndex = 0;
            // 
            // login
            // 
            login.Controls.Add(pictureBox1);
            login.Controls.Add(btnLogin);
            login.Controls.Add(txtSenhaLogin);
            login.Controls.Add(txtUsuarioLogin);
            login.Controls.Add(Usuario);
            login.Controls.Add(Senha);
            login.Location = new Point(4, 24);
            login.Name = "login";
            login.Padding = new Padding(3);
            login.Size = new Size(343, 187);
            login.TabIndex = 0;
            login.Text = "login";
            login.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(251, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 63);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(123, 108);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(105, 67);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(117, 23);
            txtSenhaLogin.TabIndex = 3;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(105, 27);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(117, 23);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(52, 30);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 1;
            Usuario.Text = "Usuario";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(52, 70);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 0;
            Senha.Text = "Senha";
            // 
            // registro
            // 
            registro.Controls.Add(pictureBox2);
            registro.Controls.Add(btnRegistro);
            registro.Controls.Add(texEmail);
            registro.Controls.Add(texSenha);
            registro.Controls.Add(texConfirmarSenha);
            registro.Controls.Add(texUsuario);
            registro.Controls.Add(Email);
            registro.Controls.Add(label3);
            registro.Controls.Add(label2);
            registro.Controls.Add(label1);
            registro.Location = new Point(4, 24);
            registro.Name = "registro";
            registro.Padding = new Padding(3);
            registro.Size = new Size(343, 187);
            registro.TabIndex = 1;
            registro.Text = "registro";
            registro.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(228, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 106);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(118, 148);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // texEmail
            // 
            texEmail.Location = new Point(108, 119);
            texEmail.Name = "texEmail";
            texEmail.Size = new Size(100, 23);
            texEmail.TabIndex = 7;
            // 
            // texSenha
            // 
            texSenha.Location = new Point(108, 59);
            texSenha.Name = "texSenha";
            texSenha.Size = new Size(100, 23);
            texSenha.TabIndex = 6;
            // 
            // texConfirmarSenha
            // 
            texConfirmarSenha.Location = new Point(108, 86);
            texConfirmarSenha.Name = "texConfirmarSenha";
            texConfirmarSenha.Size = new Size(100, 23);
            texConfirmarSenha.TabIndex = 5;
            texConfirmarSenha.TextChanged += textBox2_TextChanged;
            // 
            // texUsuario
            // 
            texUsuario.Location = new Point(108, 31);
            texUsuario.Name = "texUsuario";
            texUsuario.Size = new Size(100, 23);
            texUsuario.TabIndex = 4;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(28, 122);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 94);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirmar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // BancoDeDados
            // 
            BancoDeDados.Location = new Point(4, 24);
            BancoDeDados.Name = "BancoDeDados";
            BancoDeDados.Size = new Size(343, 187);
            BancoDeDados.TabIndex = 2;
            BancoDeDados.Text = "banco de dados";
            BancoDeDados.UseVisualStyleBackColor = true;
            // 
            // configuração
            // 
            configuração.Location = new Point(4, 24);
            configuração.Name = "configuração";
            configuração.Size = new Size(343, 187);
            configuração.TabIndex = 3;
            configuração.Text = "configuração";
            configuração.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            login.ResumeLayout(false);
            login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            registro.ResumeLayout(false);
            registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage login;
        private TabPage registro;
        private TabPage BancoDeDados;
        private TabPage configuração;
        private TextBox txtUsuarioLogin;
        private Label Usuario;
        private Label Senha;
        private TextBox txtSenhaLogin;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private TextBox texEmail;
        private TextBox texSenha;
        private TextBox texConfirmarSenha;
        private TextBox texUsuario;
        private Label Email;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnRegistro;
    }
}
