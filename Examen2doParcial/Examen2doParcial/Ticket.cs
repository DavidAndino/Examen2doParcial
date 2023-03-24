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

        private void guardarButton_Click(object sender, EventArgs e)
        {
            decimal isv, descto;
            boleto.Fecha = dateTimePicker1.Value;
            boleto.NombreCliente = clienteTextBox.Text;
            boleto.TipoSoporte = comboBox1.Text;
            boleto.NumeroSerie = serieTextBox.Text;
            boleto.DescripcionSolicitud = descripcionRichTextBox.Text;
            boleto.DescripcionRespuesta = respuestaRichTextBox.Text;
            boleto.Activo = checkBox1.Checked;

            //validando que no haya entradas vacias y en caso de no haber, se asignan valores al objeto "boleto" de la clase "TicketEntidad"
            if (string.IsNullOrEmpty(clienteTextBox.Text))
            {
                errorProvider1.SetError(clienteTextBox, "Ingrese el nombre del cliente");
                clienteTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

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

            boleto.Precio = Convert.ToDecimal(precioTextBox.Text);//asignando precio
            //proceso
            boleto.ISV = boleto.Precio * 0.15M;//calculando isv
            //valores moetarios
            isvTextBox.Text = boleto.ISV.ToString();//llenando textBox del impuesto
            if (desctoTextBox.Text != "")
            {
                descto = Convert.ToDecimal(desctoTextBox.Text);
                boleto.Descuento = descto;//asignando descuento
            }
            boleto.Total = (boleto.Precio + boleto.ISV) - boleto.Descuento;//calculando total
            totalTextBox.Text = boleto.Total.ToString();//llenando text box de total

            //definiendo variable que almacenara el valor de la variable booleana en el metodo "ticketGuardado" de la  clase "TicketDB"
            bool guardado = boletoDB.ticketGuardado(boleto);

            //evaluando si la variable anterior trae un valor verdadero o falso
            if (guardado)//si es verdadero
            {
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


    }
}
