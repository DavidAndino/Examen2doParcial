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
        decimal descto;
        private void guardarButton_Click(object sender, EventArgs e)
        {

            boleto.Fecha = dateTimePicker1.Value;
            boleto.TipoSoporte = comboBox1.Text;
            boleto.NumeroSerie = serieTextBox.Text;
            boleto.DescripcionSolicitud = descripcionRichTextBox.Text;
            boleto.DescripcionRespuesta = respuestaRichTextBox.Text;
            boleto.Activo = checkBox1.Checked;
            cliente.ID = idClienteTextBox.Text;

            //definiendo variable que almacenara el valor de la variable booleana en el metodo "ticketGuardado" de la  clase "TicketDB"
            string idCliente = cliente.ID;//pasando id de cliente a una variable de tipo string, que servira como parametro en la siguiente invocacion
            bool guardado = boletoDB.ticketGuardado(boleto, idCliente);

            //evaluando si la variable anterior trae un valor verdadero o falso
            if (guardado)//si es verdadero
            {
                limpiarControles();
                DesactivarBotones();
                MessageBox.Show("Ticket generado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //validando que solo se ingresen valores numericos
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            //validando que se presione "Enter" en el campo de Id del cliente, y que este no este vacio
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(idClienteTextBox.Text))
            {
                //validando que la identidad ingresada este registrada en la base de datos
                cliente = clienteDeDB.traerClientesPorID(idClienteTextBox.Text);//pasando la id ingresada en el textbox al parametro del metodo traerClientesPorID

                if (cliente != null)//si la identidad ingresada conincide con una de la base de datos
                {
                    nombreTextBox.Text = cliente.Nombre;//se llena el textBox con el nombre respectivo del cliente
                }
                else if (cliente == null)
                {
                    MessageBox.Show("No se pudo encontrar el nombre del cliente en el sistema. Verifique el Nº de DNI ingresado o regístrelo en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nombreTextBox.Clear();//limpiando nombre de cliente en caso de que el usuario haya ingresado uno que si esta en la base de datos, pero que no era el que queria ingresar
                    return;
                }


            }
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validando que solo se ingresen valores numericos
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                errorProvider1.SetError(precioTextBox, "Solo puede ingresar valores numéricos en este campo");
            }
            else
            {
                errorProvider1.Clear();
            }

            //validando que se presione enter y que el control de precio no este vacio
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(precioTextBox.Text))
            {
                errorProvider1.Clear();//eliminando molesta  advertencia que podria quedar luego que se  ingresen datos correctos en los controles de precio, descuento  y/o id de cliente
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
                ActivarBotones();
            }
        }
        private void DesactivarBotones()
        {
            guardarButton.Enabled = false;
            cancelarButton.Enabled = false;//desactivando boton cancelar si el usuario lo presiona, para que no quede activo en el siguiente registro.

        }
        private void ActivarBotones()
        {
            guardarButton.Enabled = true;
            cancelarButton.Enabled = true;//desactivando boton cancelar si el usuario lo presiona, para que no quede activo en el siguiente registro.

        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            limpiarControles();
            DesactivarBotones();
        }

        private void desctoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validando que solo se  ingresen numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                errorProvider1.SetError(desctoTextBox, "Solo puede ingresar valores numéricos en este campo");
            }
            else
            {
                errorProvider1.Clear();
            }
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
            boleto.Descuento = 0;
        }
    }
}
