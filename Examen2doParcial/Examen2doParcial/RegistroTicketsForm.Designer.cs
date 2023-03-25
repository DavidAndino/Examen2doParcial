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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTicketsForm));
            this.registrosDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tipoSoportecomboBox = new System.Windows.Forms.ComboBox();
            this.idTicketTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
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
            this.registrosDataGridView.Location = new System.Drawing.Point(30, 342);
            this.registrosDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.registrosDataGridView.Name = "registrosDataGridView";
            this.registrosDataGridView.Size = new System.Drawing.Size(1075, 219);
            this.registrosDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // serieTextBox
            // 
            this.serieTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(26, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Número  de serie: ";
            // 
            // tipoSoportecomboBox
            // 
            this.tipoSoportecomboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.idTicketTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(26, 221);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ticket Activo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(315, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Activar/Desactivar Ticket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(566, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Guardar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(698, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Descartar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(29, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Refrescar Tabla";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Examen2doParcial.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(42, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelarButton.BackgroundImage = global::Examen2doParcial.Properties.Resources.Cancel_icon_icons_com_73703;
            this.cancelarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.Enabled = false;
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Location = new System.Drawing.Point(713, 247);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(49, 49);
            this.cancelarButton.TabIndex = 34;
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.Color.Transparent;
            this.guardarButton.BackgroundImage = global::Examen2doParcial.Properties.Resources.save_783482;
            this.guardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarButton.Enabled = false;
            this.guardarButton.FlatAppearance.BorderSize = 0;
            this.guardarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarButton.Location = new System.Drawing.Point(570, 244);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(52, 54);
            this.guardarButton.TabIndex = 33;
            this.guardarButton.UseVisualStyleBackColor = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.BackColor = System.Drawing.Color.Transparent;
            this.modificarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarButton.FlatAppearance.BorderSize = 0;
            this.modificarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarButton.Image = global::Examen2doParcial.Properties.Resources._62914memo_109205;
            this.modificarButton.Location = new System.Drawing.Point(383, 237);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(74, 68);
            this.modificarButton.TabIndex = 4;
            this.modificarButton.UseVisualStyleBackColor = false;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // RegistroTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1124, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}