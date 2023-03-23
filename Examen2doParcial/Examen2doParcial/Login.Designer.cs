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
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ocultarButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(187, 41);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 26);
            this.usuarioTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(187, 93);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(100, 26);
            this.claveTextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ocultarButton
            // 
            this.ocultarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocultarButton.FlatAppearance.BorderSize = 0;
            this.ocultarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocultarButton.Image = global::Examen2doParcial.Properties.Resources.eye;
            this.ocultarButton.Location = new System.Drawing.Point(293, 90);
            this.ocultarButton.Name = "ocultarButton";
            this.ocultarButton.Size = new System.Drawing.Size(31, 32);
            this.ocultarButton.TabIndex = 8;
            this.ocultarButton.UseVisualStyleBackColor = true;
            this.ocultarButton.Click += new System.EventHandler(this.ocultarButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.FlatAppearance.BorderSize = 0;
            this.salirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirButton.Image = global::Examen2doParcial.Properties.Resources.logout;
            this.salirButton.Location = new System.Drawing.Point(242, 144);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(31, 32);
            this.salirButton.TabIndex = 7;
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.FlatAppearance.BorderSize = 0;
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Image = global::Examen2doParcial.Properties.Resources.check;
            this.aceptarButton.Location = new System.Drawing.Point(187, 142);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(36, 37);
            this.aceptarButton.TabIndex = 9;
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salirButton;
            this.ClientSize = new System.Drawing.Size(399, 200);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.ocultarButton);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioTextBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
    }
}