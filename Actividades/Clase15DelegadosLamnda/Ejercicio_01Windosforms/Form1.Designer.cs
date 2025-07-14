namespace Ejercicio_01Windosforms
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
            menuStrip1 = new MenuStrip();
            altaToolStripMenuItem = new ToolStripMenuItem();
            tsmTestDelegados = new ToolStripMenuItem();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            tsmMostrar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { altaToolStripMenuItem, tsmMostrar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "File";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmTestDelegados, alumnoToolStripMenuItem });
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(40, 20);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // tsmTestDelegados
            // 
            tsmTestDelegados.Name = "tsmTestDelegados";
            tsmTestDelegados.Size = new Size(152, 22);
            tsmTestDelegados.Text = "Test Delegados";
            tsmTestDelegados.Click += tsmTestDelegados_Click;
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(152, 22);
            alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // tsmMostrar
            // 
            tsmMostrar.Enabled = false;
            tsmMostrar.Name = "tsmMostrar";
            tsmMostrar.Size = new Size(70, 20);
            tsmMostrar.Text = "Modificar";
            tsmMostrar.Click += tsmMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem tsmMostrar;
        private ToolStripMenuItem tsmTestDelegados;
        private ToolStripMenuItem alumnoToolStripMenuItem;
    }
}
