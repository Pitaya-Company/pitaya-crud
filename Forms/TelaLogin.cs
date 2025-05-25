using pitaya_crud.Forms;
using pitaya_crud.Services;

namespace pitaya_crud.Forms
{
    public partial class TelaLogin : Form
    {
        private readonly UsuarioService _usuarioService;

        public TelaLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = TextBoxLogin.Text.Trim();
            string senha = TextBoxSenha.Text.Trim();

            if (_usuarioService.Login(email,senha))
            {
                Hide();

                var telaInicial = new TelaInicial();
                telaInicial.ShowDialog();

                Show();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lema_Click(object sender, EventArgs e)
        {

        }

        private void FormaBackground_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBoxLogin.Clear();
            TextBoxSenha.Clear();
        }
    }
}
