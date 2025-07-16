namespace FrmLogin
{
    partial class FrmPrincipal
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
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            tsmListadoCrud = new ToolStripMenuItem();
            verLogToolStripMenuItem = new ToolStripMenuItem();
            deserializarJSONToolStripMenuItem = new ToolStripMenuItem();
            taskToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmListadoCrud, verLogToolStripMenuItem, deserializarJSONToolStripMenuItem, taskToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // tsmListadoCrud
            // 
            tsmListadoCrud.Name = "tsmListadoCrud";
            tsmListadoCrud.Size = new Size(180, 22);
            tsmListadoCrud.Text = "1.-Listado CRUD";
            tsmListadoCrud.Click += tsmListadoCrud_Click;
            // 
            // verLogToolStripMenuItem
            // 
            verLogToolStripMenuItem.Name = "verLogToolStripMenuItem";
            verLogToolStripMenuItem.Size = new Size(180, 22);
            verLogToolStripMenuItem.Text = "2.-Ver log";
            // 
            // deserializarJSONToolStripMenuItem
            // 
            deserializarJSONToolStripMenuItem.Name = "deserializarJSONToolStripMenuItem";
            deserializarJSONToolStripMenuItem.Size = new Size(180, 22);
            deserializarJSONToolStripMenuItem.Text = "3.-Deserializar JSON";
            // 
            // taskToolStripMenuItem
            // 
            taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            taskToolStripMenuItem.Size = new Size(180, 22);
            taskToolStripMenuItem.Text = "4.-Task";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 269);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem tsmListadoCrud;
        private ToolStripMenuItem verLogToolStripMenuItem;
        private ToolStripMenuItem deserializarJSONToolStripMenuItem;
        private ToolStripMenuItem taskToolStripMenuItem;
    }
}