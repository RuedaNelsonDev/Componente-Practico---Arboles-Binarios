namespace Fase4_Nelson_Rueda
{
    public partial class FormLogin : Form
    {
        private static FormLogin instancia;

        public FormLogin()
        {
            InitializeComponent();
        }
        private void mostrarForm(Type formType)
        {
            this.Hide();
            Form formInstance = (Form)Activator.CreateInstance(formType);
            formInstance.Show();

        }
        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {

            string contrasena = txtLoginContrasena.Text;

            if (contrasena == "unad")
            {
                mostrarForm(typeof(FormMenu));
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intente nuevamente.");
            }
           
        }
    }
}