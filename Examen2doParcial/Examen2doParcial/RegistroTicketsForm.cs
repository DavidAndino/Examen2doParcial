using BaseDatos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Examen2doParcial
{
    public partial class RegistroTicketsForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public RegistroTicketsForm()
        {
            InitializeComponent();
        }
        //objetos globales
        DataTable registrosTickets = new DataTable();//instanciando objeto de tipo DataTable
        TicketDB boleto = new TicketDB();//instanciando objeto de tipo TicketDB que invocara al metodo "traerTickets"
        TicketEntidad boletoActual = new TicketEntidad();

        //variables globales
        bool guardar, cancelar, editar;

        private void traerTicketsForm()
        {
            registrosTickets = boleto.traerTickets();
            registrosDataGridView.DataSource = registrosTickets;
        }

        private void RegistroTicketsForm_Load(object sender, System.EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            traerTicketsForm();//invocando metodo de la misma clase para mostrar registros en el DataGridView
        }
        private void guardarButton_Click(object sender, EventArgs e)
        {
            boletoActual.Activo = activoCheckBox.Checked;
            bool editado = boleto.ticketModificado(boletoActual);
            if (editado)
            {
                MessageBox.Show("El estado del ticket fue modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traerTicketsForm();//actualizando dataGridView
                guardar = true;
                //reiniciando controles una vez guardado el registro en cuestion
                limpiarControles();
                activarDesactivarControlesYBotones();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el estado del ticket", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            if (registrosDataGridView.SelectedRows.Count > 0)
            {
                editar = true;
                activarDesactivarControlesYBotones();
                editar = false;
                //pasando los datos del registro a los controles del formulario
                idTicketTextBox.Text = registrosDataGridView.CurrentRow.Cells["IdTicket"].Value.ToString();
                boletoActual.Id = Convert.ToInt16(idTicketTextBox.Text);//pasando Id del ticket en cuestion a la propiedad Id de la clase TicketEntidad
                tipoSoportecomboBox.Text = registrosDataGridView.CurrentRow.Cells["TipoSoporte"].Value.ToString();
                serieTextBox.Text = registrosDataGridView.CurrentRow.Cells["NumeroSerie"].Value.ToString();
                activoCheckBox.Checked = Convert.ToBoolean(registrosDataGridView.CurrentRow.Cells["Activo"].Value);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            cancelar = true;
            limpiarControles();
            activarDesactivarControlesYBotones();
        }

        private void activarDesactivarControlesYBotones()
        {
            //si el usuario cancela o guarda el registro actual, por medio de esta condicion se vuelven a habilitar los controles desactivados, y a deshabilitar los activados
            if (cancelar == true || guardar == true)
            {
                guardarButton.Enabled = false;
                cancelarButton.Enabled = false;
                activoCheckBox.Enabled = false;
                modificarButton.Enabled = true;
            }

            if (editar == true)
            {
                activoCheckBox.Enabled = true;
                guardarButton.Enabled = true;
                cancelarButton.Enabled = true;

            }
        }
        private void limpiarControles()
        {
            idTicketTextBox.Clear();
            tipoSoportecomboBox.DataSource = null;
            tipoSoportecomboBox.Items.Clear();
            serieTextBox.Clear();
            activoCheckBox.Checked = false;
        }


    }
}
