namespace Ejercicio_03
{
    partial class FrmListarSuper
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
            components = new System.ComponentModel.Container();
            lstObjetos = new ListBox();
            btnAgregar = new Button();
            toolTip2 = new ToolTip(components);
            btnEliminar = new Button();
            btnModificar = new Button();
            toolTip1 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            SuspendLayout();
            // 
            // lstObjetos
            // 
            lstObjetos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstObjetos.FormattingEnabled = true;
            lstObjetos.ItemHeight = 15;
            lstObjetos.Location = new Point(12, 18);
            lstObjetos.Name = "lstObjetos";
            lstObjetos.Size = new Size(296, 394);
            lstObjetos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(314, 18);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(58, 63);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "X";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(314, 87);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(58, 63);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(314, 156);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(58, 63);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmListarSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 424);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstObjetos);
            Name = "FrmListarSuper";
            Text = "FrmListarSuper";
            Load += FrmListarSuper_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstObjetos;
        private Button btnAgregar;
        private ToolTip toolTip2;
        private Button btnEliminar;
        private Button btnModificar;
        private ToolTip toolTip1;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
    }
}