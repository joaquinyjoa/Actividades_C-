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
            tsmVerLog = new ToolStripMenuItem();
            tsmDeserializarJSON = new ToolStripMenuItem();
            tsmTask = new ToolStripMenuItem();
            verLogToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            lstUsuarios = new ListBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmListadoCrud, tsmVerLog, tsmDeserializarJSON, tsmTask, verLogToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // tsmListadoCrud
            // 
            tsmListadoCrud.Name = "tsmListadoCrud";
            tsmListadoCrud.Size = new Size(178, 22);
            tsmListadoCrud.Text = "1.-Listado CRUD";
            tsmListadoCrud.Click += tsmListadoCrud_Click;
            // 
            // tsmVerLog
            // 
            tsmVerLog.Name = "tsmVerLog";
            tsmVerLog.Size = new Size(178, 22);
            tsmVerLog.Text = "2.-Ver log";
            tsmVerLog.Click += tsmVerLog_Click;
            // 
            // tsmDeserializarJSON
            // 
            tsmDeserializarJSON.Name = "tsmDeserializarJSON";
            tsmDeserializarJSON.Size = new Size(178, 22);
            tsmDeserializarJSON.Text = "3.-Deserializar JSON";
            tsmDeserializarJSON.Click += tsmDeserializarJSON_Click;
            // 
            // tsmTask
            // 
            tsmTask.Name = "tsmTask";
            tsmTask.Size = new Size(178, 22);
            tsmTask.Text = "4.-Task";
            tsmTask.Click += tsmTask_Click;
            // 
            // verLogToolStripMenuItem
            // 
            verLogToolStripMenuItem.Name = "verLogToolStripMenuItem";
            verLogToolStripMenuItem.Size = new Size(178, 22);
            verLogToolStripMenuItem.Text = "2.-Ver log";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstUsuarios);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 230);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(6, 22);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(764, 199);
            lstUsuarios.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 269);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem tsmListadoCrud;
        private ToolStripMenuItem tsmVerLog;
        private ToolStripMenuItem tsmDeserializarJSON;
        private ToolStripMenuItem tsmTask;
        private ToolStripMenuItem verLogToolStripMenuItem;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private ListBox lstUsuarios;
    }
}