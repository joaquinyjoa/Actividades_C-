namespace Ejercicio_01
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
            btn_saludar = new Button();
            tb_nombre = new TextBox();
            tb_apellido = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmb_materia = new ComboBox();
            SuspendLayout();
            // 
            // btn_saludar
            // 
            btn_saludar.BackColor = SystemColors.Control;
            btn_saludar.ForeColor = SystemColors.ActiveCaptionText;
            btn_saludar.Location = new Point(499, 39);
            btn_saludar.Name = "btn_saludar";
            btn_saludar.Size = new Size(75, 23);
            btn_saludar.TabIndex = 0;
            btn_saludar.Text = "Saludar";
            btn_saludar.UseVisualStyleBackColor = false;
            btn_saludar.Click += btn_saludar_Click;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(12, 40);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.PlaceholderText = "ingrese nombre";
            tb_nombre.Size = new Size(230, 23);
            tb_nombre.TabIndex = 1;
            // 
            // tb_apellido
            // 
            tb_apellido.Location = new Point(248, 40);
            tb_apellido.Name = "tb_apellido";
            tb_apellido.PlaceholderText = "ingrese apellido";
            tb_apellido.Size = new Size(230, 23);
            tb_apellido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "INGRESE NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(248, 9);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "INGRESE APELLIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 6;
            label2.Text = "MATERIA FAVORITA";
            // 
            // cmb_materia
            // 
            cmb_materia.FormattingEnabled = true;
            cmb_materia.Location = new Point(12, 84);
            cmb_materia.Name = "cmb_materia";
            cmb_materia.Size = new Size(230, 23);
            cmb_materia.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(623, 128);
            Controls.Add(cmb_materia);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tb_apellido);
            Controls.Add(tb_nombre);
            Controls.Add(btn_saludar);
            Name = "Form1";
            Text = "Actividad 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_saludar;
        private TextBox tb_nombre;
        private TextBox tb_apellido;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox cmb_materia;
    }
}
