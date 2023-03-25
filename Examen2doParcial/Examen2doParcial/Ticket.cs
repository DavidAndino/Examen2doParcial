using BaseDatos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Examen2doParcial
{
    public partial class Ticket : Syncfusion.Windows.Forms.Office2010Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        //creando objetos globales
        TicketEntidad boleto = new TicketEntidad();
        TicketDB boletoDB = new TicketDB();
        ClienteEntidad cliente = new ClienteEntidad();
        ClienteDB clienteDeDB = new ClienteDB();
        decimal descto = 0;
        bool cancelar, guardar;
        private void guardarButton_Click(object sender, EventArgs e)
        {

            boleto.Fecha = dateTimePicker1.Value;
            boleto.TipoSoporte = comboBox1.Text;
            boleto.NumeroSerie = serieTextBox.Text;
            boleto.DescripcionSolicitud = descripcionRichTextBox.Text;
            boleto.DescripcionRespuesta = respuestaRichTextBox.Text;
            boleto.Activo = checkBox1.Checked;

            //validando que no haya entradas vacias y en caso de no haber, se asignan valores al objeto "boleto" de la clase "TicketEntidad"
            if (string.IsNullOrEmpty(idClienteTextBox.Text))
            {
                errorProvider1.SetError(idClienteTextBox, "Ingrese el DNI del cliente");
                return;
            }
            errorProvider1.Clear();

            cliente.ID = idClienteTextBox.Text;

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Seleccione una opción");
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(serieTextBox.Text))
            {
                errorProvider1.SetError(serieTextBox, "Ingrese el número de serie o IMEI del equipo");
                serieTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(descripcionRichTextBox.Text))
            {
                errorProvider1.SetError(descripcionRichTextBox, "Ingrese una descripcion");
                descripcionRichTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(respuestaRichTextBox.Text))
            {
                errorProvider1.SetError(respuestaRichTextBox, "Ingrese una respuesta");
                respuestaRichTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(precioTextBox.Text))
            {
                errorProvider1.SetError(precioTextBox, "Ingrese el precio");
                precioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //definiendo variable que almacenara el valor de la variable booleana en el metodo "ticketGuardado" de la  clase "TicketDB"
            string idCliente = cliente.ID;//pasando id de cliente a una variable de tipo string, que servira como parametro en la siguiente invocacion
            bool guardado = boletoDB.ticketGuardado(boleto, idCliente);

            //evaluando si la variable anterior trae un valor verdadero o falso
            if (guardado)//si es verdadero
            {
                limpiarControles();
                guardarButton.Enabled = false;
                MessageBox.Show("Ticket generado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar generar el ticket", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            idUsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void clienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(idClienteTextBox.Text))
            {
                cliente = clienteDeDB.traerClientesPorID(idClienteTextBox.Text);
                nombreTextBox.Text = cliente.Nombre;
            }
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(precioTextBox.Text))
            {
                boleto.Precio = Convert.ToDecimal(precioTextBox.Text);//asignando precio
                boleto.ISV = boleto.Precio * 0.15M;//calculando isv

                //valores moetarios
                isvTextBox.Text = boleto.ISV.ToString();//llenando textBox del impuesto
                if (desctoTextBox.Text != "")
                {
                    descto = Convert.ToDecimal(desctoTextBox.Text);
                    boleto.Descuento = descto;//asignando descuento
                }

                //proceso
                boleto.Total = (boleto.Precio + boleto.ISV) - boleto.Descuento;//calculando total
                totalTextBox.Text = boleto.Total.ToString();//llenando text box de total                                                      
                guardarButton.Enabled = true;//habilitando boto para guardar una vez ingresado el precio
            }
        }
        private void activarDesactivarBoton()
        {
            //si el usuario cancela o guarda el registro actual, por medio de esta condicion se vuelven a habilitar los controles desactivados, y a deshabilitar los activados
            if (cancelar == true)
            {
                cancelarButton.Enabled = false;//desactivando boton cancelar si el usuario lo presiona, para que no quede activo en el siguiente registro.
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            limpiarControles();
            activarDesactivarBoton();
        }

        private void limpiarControles()
        {
            idClienteTextBox.Clear();
            nombreTextBox.Clear();
            serieTextBox.Clear();
            descripcionRichTextBox.Clear();
            respuestaRichTextBox.Clear();
            precioTextBox.Clear();
            isvTextBox.Clear();
            desctoTextBox.Clear();
            totalTextBox.Clear();
            boleto = null;
            descto = 0;
        }
    }
}
