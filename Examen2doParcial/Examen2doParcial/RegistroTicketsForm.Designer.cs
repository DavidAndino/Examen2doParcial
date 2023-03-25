namespace Examen2doParcial
{
    partial class RegistroTicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registrosDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.modificarButton = new System.Windows.Forms.Button();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tipoSoportecomboBox = new System.Windows.Forms.ComboBox();
            this.idTicketTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guardarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrosDataGridView
            // 
            this.registrosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrosDataGridView.Location = new System.Drawing.Point(23, 331);
            this.registrosDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.registrosDataGridView.Name = "registrosDataGridView";
            this.registrosDataGridView.Size = new System.Drawing.Size(1075, 219);
            this.registrosDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTROS  DE TICKETS AL";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(23, 279);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(214, 31);
            this.modificarButton.TabIndex = 4;
            this.modificarButton.Text = "Activar/Desactivar Ticket";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // serieTextBox
            // 
            this.serieTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.serieTextBox.Enabled = false;
            this.serieTextBox.Location = new System.Drawing.Point(187, 182);
            this.serieTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(233, 26);
            this.serieTextBox.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Número  de serie: ";
            // 
            // tipoSoportecomboBox
            // 
            this.tipoSoportecomboBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tipoSoportecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoSoportecomboBox.Enabled = false;
            this.tipoSoportecomboBox.FormattingEnabled = true;
            this.tipoSoportecomboBox.Items.AddRange(new object[] {
            "Celular",
            "Ordenador"});
            this.tipoSoportecomboBox.Location = new System.Drawing.Point(187, 138);
            this.tipoSoportecomboBox.Name = "tipoSoportecomboBox";
            this.tipoSoportecomboBox.Size = new System.Drawing.Size(121, 27);
            this.tipoSoportecomboBox.TabIndex = 25;
            // 
            // idTicketTextBox
            // 
            this.idTicketTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.idTicketTextBox.Enabled = false;
            this.idTicketTextBox.Location = new System.Drawing.Point(187, 96);
            this.idTicketTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.idTicketTextBox.Name = "idTicketTextBox";
            this.idTicketTextBox.Size = new System.Drawing.Size(121, 26);
            this.idTicketTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id de Ticket: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo de soporte: ";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(146, 224);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activoCheckBox.TabIndex = 32;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 221);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ticket Activo:";
            // 
            // guardarButton
            // 
            this.guardarButton.Enabled = false;
            this.guardarButton.Location = new System.Drawing.Point(255, 279);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(165, 31);
            this.guardarButton.TabIndex = 33;
            this.guardarButton.Text = "Guardar Cambios";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Enabled = false;
            this.cancelarButton.Location = new System.Drawing.Point(439, 279);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(165, 31);
            this.cancelarButton.TabIndex = 34;
            this.cancelarButton.Text = "Descartar Cambios";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // RegistroTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1124, 574);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.serieTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tipoSoportecomboBox);
            this.Controls.Add(this.idTicketTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrosDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistroTicketsForm";
            this.Text = "RegistroTicketsForm";
            this.Load += new System.EventHandler(this.RegistroTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView registrosDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox tipoSoportecomboBox;
        private System.Windows.Forms.TextBox idTicketTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}