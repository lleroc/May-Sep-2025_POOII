namespace Alertas_Timer.Views
{
    partial class frm_menu
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
            menuStrip1 = new MenuStrip();
            alertasToolStripMenuItem = new ToolStripMenuItem();
            servidoresToolStripMenuItem = new ToolStripMenuItem();
            parametrosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alertasToolStripMenuItem, servidoresToolStripMenuItem, parametrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1043, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // alertasToolStripMenuItem
            // 
            alertasToolStripMenuItem.Name = "alertasToolStripMenuItem";
            alertasToolStripMenuItem.Size = new Size(100, 36);
            alertasToolStripMenuItem.Text = "Alertas";
            alertasToolStripMenuItem.Click += alertasToolStripMenuItem_Click;
            // 
            // servidoresToolStripMenuItem
            // 
            servidoresToolStripMenuItem.Name = "servidoresToolStripMenuItem";
            servidoresToolStripMenuItem.Size = new Size(139, 36);
            servidoresToolStripMenuItem.Text = "Servidores";
            servidoresToolStripMenuItem.Click += servidoresToolStripMenuItem_Click;
            // 
            // parametrosToolStripMenuItem
            // 
            parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            parametrosToolStripMenuItem.Size = new Size(146, 36);
            parametrosToolStripMenuItem.Text = "Parametros";
            parametrosToolStripMenuItem.Click += parametrosToolStripMenuItem_Click;
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 571);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "frm_menu";
            Text = "Menu Prrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alertasToolStripMenuItem;
        private ToolStripMenuItem servidoresToolStripMenuItem;
        private ToolStripMenuItem parametrosToolStripMenuItem;
    }
}