namespace pitaya_crud.Forms;

using Models;

public static class UsuarioPrompt
{
    public static Usuario ShowDialog(Usuario usuarioOriginal)
    {
        Form prompt = new Form()
        {
            Width = 320,
            Height = 180,
            Text = "Editar usuário",
            FormBorderStyle = FormBorderStyle.FixedDialog,
            StartPosition = FormStartPosition.CenterScreen,
            MinimizeBox = false,
            MaximizeBox = false
        };

        Label emailLabel = new Label() { Left = 10, Top = 20, Text = "Email", AutoSize = true };
        TextBox emailBox = new TextBox() { Left = 70, Top = 20, Width = 220, Text = usuarioOriginal.Email };

        Label senhaLabel = new Label() { Left = 10, Top = 60, Text = "Senha", AutoSize = true };
        TextBox senhaBox = new TextBox() { Left = 70, Top = 60, Width = 220, Text = usuarioOriginal.Senha, UseSystemPasswordChar = true };

        Button confirmButton = new Button() { Text = "Salvar", Left = 110, Width = 80, Top = 100, DialogResult = DialogResult.OK };

        prompt.Controls.Add(emailLabel);
        prompt.Controls.Add(emailBox);
        prompt.Controls.Add(senhaLabel);
        prompt.Controls.Add(senhaBox);
        prompt.Controls.Add(confirmButton);

        prompt.AcceptButton = confirmButton;

        if (prompt.ShowDialog() == DialogResult.OK)
        {
            usuarioOriginal.Email = emailBox.Text.Trim();
            usuarioOriginal.Senha = senhaBox.Text.Trim();
            return usuarioOriginal;
        }

        return null;
    }
}