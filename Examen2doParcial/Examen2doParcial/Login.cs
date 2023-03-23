namespace Examen2doParcial
{
    public partial class Login : Syncfusion.Windows.Forms.Office2010Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, System.EventArgs e)
        {

            //validando controles vacios
            if (string.IsNullOrEmpty(usuarioTextBox.Text))
            {
                errorProvider1.SetError(usuarioTextBox, "Ingrese el usuario");
                usuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(claveTextBox.Text))
            {
                errorProvider1.SetError(claveTextBox, "Ingrese la contraseña");
                claveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //base datos

        }

        private void salirButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ocultarButton_Click(object sender, System.EventArgs e)
        {
            if (claveTextBox.PasswordChar == '*')
            {
                claveTextBox.PasswordChar = '\0';
                claveTextBox.Focus();
            }
            else
            {
                claveTextBox.PasswordChar = '*';
                claveTextBox.Focus();
            }
        }
    }
}
