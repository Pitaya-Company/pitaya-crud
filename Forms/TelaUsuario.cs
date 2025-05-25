using System;
using System.ComponentModel.DataAnnotations;
using pitaya_crud.Models;
using pitaya_crud.Services;

namespace pitaya_crud.Forms
{
    public partial class TelaUsuario : Form
    {
        private readonly UsuarioService _usuarioService;
        public TelaUsuario()
        {
            _usuarioService = new UsuarioService();
            InitializeComponent();
        }

        private async void registrarButton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Email = emailText.Text.Trim(),
                Senha = senhaText.Text.Trim()
            };

            if (!usuario.IsValid())
                throw new ValidationException("Email ou senha inválidos");

            await _usuarioService.CreateUsuarioAsync(usuario);
            MessageBox.Show("Usuário criado");
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            emailText.Text = "";
            senhaText.Text = "";
        }

        private async void alterarButton_Click(object sender, EventArgs e)
        {
            var email = emailExistenteText.Text.Trim();
            var senha = senhaExistenteText.Text.Trim();

            if (!_usuarioService.Login(email, senha))
            {
                MessageBox.Show("Email ou senha inválidos");
                return;
            }

            var usuario = await _usuarioService.GetUsuarioByEmail(email);
            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado");
                return;
            }

            var usuarioAtualizado = UsuarioPrompt.ShowDialog(usuario);
            await _usuarioService.UpdateUsuarioAsync(usuarioAtualizado);
            MessageBox.Show("Usuário atualizado com sucesso!");
        }

        private async void deletarButton_Click(object sender, EventArgs e)
        {
            if (!_usuarioService.Login(emailExistenteText.Text.Trim(), senhaExistenteText.Text.Trim()))
            {
                MessageBox.Show($"Email ou senha inválidos");
                return;
            }

            var usuario = await _usuarioService.GetUsuarioByEmail(emailExistenteText.Text.Trim())
                          ?? throw new KeyNotFoundException("Usuario não encontrado");
            await _usuarioService.DeleteUsuarioAsync(usuario.Id);
            MessageBox.Show("Usuário deletado");
        }
    }
}
