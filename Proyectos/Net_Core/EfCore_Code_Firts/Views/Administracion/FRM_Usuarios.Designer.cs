namespace EfCore_Code_Firts.Views.Administracion
{
    partial class FRM_Usuarios
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
            btnGrabar = new Button();
            cmbRol = new ComboBox();
            label1 = new Label();
            txtApellido = new TextBox();
            lstUsuarios = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtContrasenia = new TextBox();
            label6 = new Label();
            btnEditar = new Button();
            btnCancelar = new Button();
            bttnSalir = new Button();
            lblErrores = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(132, 489);
            btnGrabar.Margin = new Padding(5);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(153, 45);
            btnGrabar.TabIndex = 0;
            btnGrabar.Text = "Graabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Vendedor", "Caja", "Bodega", "Reportes" });
            cmbRol.Location = new Point(143, 301);
            cmbRol.Margin = new Padding(5);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(243, 39);
            cmbRol.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Usuarios";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(143, 205);
            txtApellido.Margin = new Padding(5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(243, 39);
            txtApellido.TabIndex = 3;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 31;
            lstUsuarios.Location = new Point(488, 152);
            lstUsuarios.Margin = new Padding(5);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(327, 314);
            lstUsuarios.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 81);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 32);
            label2.TabIndex = 5;
            label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 168);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 32);
            label3.TabIndex = 6;
            label3.Text = "Apellido Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 264);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 7;
            label4.Text = "Rol de Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 345);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 8;
            label5.Text = "Contrasenia";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 124);
            txtNombre.Margin = new Padding(5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 39);
            txtNombre.TabIndex = 9;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(143, 382);
            txtContrasenia.Margin = new Padding(5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(243, 39);
            txtContrasenia.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 115);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(192, 32);
            label6.TabIndex = 11;
            label6.Text = "Lista de Usuarios";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(295, 489);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 45);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(458, 489);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 45);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // bttnSalir
            // 
            bttnSalir.Location = new Point(621, 489);
            bttnSalir.Margin = new Padding(5);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(153, 45);
            bttnSalir.TabIndex = 14;
            bttnSalir.Text = "Salir";
            bttnSalir.UseVisualStyleBackColor = true;
            bttnSalir.Click += bttnSalir_Click;
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.ForeColor = Color.Red;
            lblErrores.Location = new Point(143, 574);
            lblErrores.Margin = new Padding(5, 0, 5, 0);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(226, 32);
            lblErrores.TabIndex = 15;
            lblErrores.Text = "Gestion de Usuarios";
            lblErrores.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(458, 544);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 45);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FRM_Usuarios
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 642);
            Controls.Add(btnEliminar);
            Controls.Add(lblErrores);
            Controls.Add(bttnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(label6);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstUsuarios);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(cmbRol);
            Controls.Add(btnGrabar);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FRM_Usuarios";
            Text = "FRM_Usuarios";
            Load += FRM_Usuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGrabar;
        private ComboBox cmbRol;
        private Label label1;
        private TextBox txtApellido;
        private ListBox lstUsuarios;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtContrasenia;
        private Label label6;
        private Button btnEditar;
        private Button btnCancelar;
        private Button bttnSalir;
        private Label lblErrores;
        private Button btnEliminar;
    }
}