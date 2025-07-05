namespace Tutoria0407
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            txtDetalle = new TextBox();
            label1 = new Label();
            lstPaises = new ListBox();
            label2 = new Label();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(146, 229);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 45);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(146, 117);
            txtDetalle.Margin = new Padding(5);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(201, 39);
            txtDetalle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Paises";
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.ItemHeight = 31;
            lstPaises.Location = new Point(468, 80);
            lstPaises.Margin = new Padding(5);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(241, 345);
            lstPaises.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 80);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 4;
            label2.Text = "Detalle";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(146, 284);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 45);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(304, 229);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 45);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(304, 284);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 45);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 522);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(label2);
            Controls.Add(lstPaises);
            Controls.Add(label1);
            Controls.Add(txtDetalle);
            Controls.Add(btnGuardar);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtDetalle;
        private Label label1;
        private ListBox lstPaises;
        private Label label2;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnEliminar;
    }
}
