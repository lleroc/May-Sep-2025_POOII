namespace Alertas_Timer.Views.Servidores
{
    partial class frm_servidores
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
            btn_guardar = new Button();
            chb_estado = new CheckBox();
            label1 = new Label();
            txt_nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_ip = new TextBox();
            label4 = new Label();
            txt_ubicacion = new TextBox();
            label5 = new Label();
            txt_sistema_operativo = new TextBox();
            label6 = new Label();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_cancelar = new Button();
            btn_salir = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(73, 495);
            btn_guardar.Margin = new Padding(5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(153, 45);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // chb_estado
            // 
            chb_estado.AutoSize = true;
            chb_estado.Location = new Point(125, 442);
            chb_estado.Margin = new Padding(5);
            chb_estado.Name = "chb_estado";
            chb_estado.Size = new Size(18, 17);
            chb_estado.TabIndex = 1;
            chb_estado.UseVisualStyleBackColor = true;
            chb_estado.CheckedChanged += chb_estado_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Servidores";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(73, 102);
            txt_nombre.Margin = new Padding(5);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(330, 39);
            txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 65);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 4;
            label2.Text = "Nombre Servidor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 151);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 6;
            label3.Text = "Direccion IP";
            // 
            // txt_ip
            // 
            txt_ip.Location = new Point(73, 188);
            txt_ip.Margin = new Padding(5);
            txt_ip.Name = "txt_ip";
            txt_ip.Size = new Size(330, 39);
            txt_ip.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 232);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 8;
            label4.Text = "Ubicacion";
            // 
            // txt_ubicacion
            // 
            txt_ubicacion.Location = new Point(73, 269);
            txt_ubicacion.Margin = new Padding(5);
            txt_ubicacion.Name = "txt_ubicacion";
            txt_ubicacion.Size = new Size(330, 39);
            txt_ubicacion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 313);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(209, 32);
            label5.TabIndex = 10;
            label5.Text = "Sistema Operativo";
            // 
            // txt_sistema_operativo
            // 
            txt_sistema_operativo.Location = new Point(73, 350);
            txt_sistema_operativo.Margin = new Padding(5);
            txt_sistema_operativo.Name = "txt_sistema_operativo";
            txt_sistema_operativo.Size = new Size(330, 39);
            txt_sistema_operativo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 395);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 32);
            label6.TabIndex = 11;
            label6.Text = "Estado";
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(236, 495);
            btn_editar.Margin = new Padding(5);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(153, 45);
            btn_editar.TabIndex = 12;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(399, 495);
            btn_eliminar.Margin = new Padding(5);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(153, 45);
            btn_eliminar.TabIndex = 13;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(562, 495);
            btn_cancelar.Margin = new Padding(5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(153, 45);
            btn_cancelar.TabIndex = 14;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(725, 495);
            btn_salir.Margin = new Padding(5);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(153, 45);
            btn_salir.TabIndex = 15;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(425, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(453, 376);
            listBox1.TabIndex = 16;
            // 
            // frm_servidores
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 554);
            Controls.Add(listBox1);
            Controls.Add(btn_salir);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_sistema_operativo);
            Controls.Add(label4);
            Controls.Add(txt_ubicacion);
            Controls.Add(label3);
            Controls.Add(txt_ip);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(chb_estado);
            Controls.Add(btn_guardar);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_servidores";
            Text = "frm_servidores";
            Load += frm_servidores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private CheckBox chb_estado;
        private Label label1;
        private TextBox txt_nombre;
        private Label label2;
        private Label label3;
        private TextBox txt_ip;
        private Label label4;
        private TextBox txt_ubicacion;
        private Label label5;
        private TextBox txt_sistema_operativo;
        private Label label6;
        private Button btn_editar;
        private Button btn_eliminar;
        private Button btn_cancelar;
        private Button btn_salir;
        private ListBox listBox1;
    }
}