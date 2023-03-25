namespace Examen2doParcial
{
    public partial class Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            Ticket enlace = new Ticket();//creando objeto de la clase  "Ticket"
            enlace.MdiParent = this;
            enlace.Show();//mostrando formulario de ticket

        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            RegistroTicketsForm enlace = new RegistroTicketsForm();
            enlace.MdiParent = this;//el formulario "RegistroTickets sera hijo de menu
            enlace.Show();//mostrando formulario
        }
    }
}
