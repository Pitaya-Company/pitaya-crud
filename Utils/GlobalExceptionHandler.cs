namespace pitaya_crud.Utils
{
    internal static class GlobalExceptionHandler
    {
        public static void Initialize()
        {
            Application.ThreadException += (sender, e) => TrataErro(e.Exception);

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                if (e.ExceptionObject is Exception ex) TrataErro(ex);
            };
        }

        private static void TrataErro(Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro inesperado \n\n {ex.Message}", 
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
