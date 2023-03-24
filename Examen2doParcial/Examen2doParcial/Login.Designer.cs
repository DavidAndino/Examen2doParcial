namespace Examen2doParcial
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ocultarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.usuarioTextBox.Location = new System.Drawing.Point(136, 204);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(128, 26);
            this.usuarioTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(157, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(143, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // claveTextBox
            // 
            this.claveTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.claveTextBox.Location = new System.Drawing.Point(136, 269);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(128, 26);
            this.claveTextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(103, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "INICIAR SESIÓN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aceptarButton
            // 
            this.aceptarButton.BackColor = System.Drawing.Color.Transparent;
            this.aceptarButton.FlatAppearance.BorderSize = 0;
            this.aceptarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Image = global::Examen2doParcial.Properties.Resources.check;
            this.aceptarButton.Location = new System.Drawing.Point(161, 312);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(36, 37);
            this.aceptarButton.TabIndex = 9;
            this.aceptarButton.UseVisualStyleBackColor = false;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.BackColor = System.Drawing.Color.Transparent;
            this.salirButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salirButton.FlatAppearance.BorderSize = 0;
            this.salirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.salirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirButton.Image = global::Examen2doParcial.Properties.Resources.logout;
            this.salirButton.Location = new System.Drawing.Point(216, 314);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(31, 32);
            this.salirButton.TabIndex = 7;
            this.salirButton.UseVisualStyleBackColor = false;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Examen2doParcial.Properties.Resources.users_theuser_6177;
            this.pictureBox1.Location = new System.Drawing.Point(161, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ocultarButton
            // 
            this.ocultarButton.BackColor = System.Drawing.Color.Transparent;
            this.ocultarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocultarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocultarButton.FlatAppearance.BorderSize = 0;
            this.ocultarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocultarButton.Image = global::Examen2doParcial.Properties.Resources.eye;
            this.ocultarButton.Location = new System.Drawing.Point(270, 269);
            this.ocultarButton.Name = "ocultarButton";
            this.ocultarButton.Size = new System.Drawing.Size(31, 32);
            this.ocultarButton.TabIndex = 8;
            this.ocultarButton.UseVisualStyleBackColor = false;
            this.ocultarButton.Click += new System.EventHandler(this.ocultarButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen2doParcial.Properties.Resources.degradado_azul;
            this.CancelButton = this.salirButton;
            this.ClientSize = new System.Drawing.Size(399, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.ocultarButton);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioTextBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ocultarButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}