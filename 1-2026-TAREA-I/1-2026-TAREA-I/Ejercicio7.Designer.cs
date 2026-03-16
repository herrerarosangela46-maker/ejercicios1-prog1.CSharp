namespace _1_2026_TAREA_I
{
    partial class Ejercicio7
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
            label1 = new Label();
            label2 = new Label();
            btnResultado = new Button();
            txtNumero = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 73);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 0;
            label1.Text = "Número par o impar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(142, 197);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 1;
            label2.Text = "Digite un número:";
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.MediumOrchid;
            btnResultado.Cursor = Cursors.Hand;
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResultado.Location = new Point(257, 287);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(108, 42);
            btnResultado.TabIndex = 2;
            btnResultado.Text = "Mostrar";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            btnResultado.MouseHover += btn_Hover;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumero.Location = new Point(309, 197);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(165, 29);
            txtNumero.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(156, 397);
            label3.Name = "label3";
            label3.Size = new Size(300, 17);
            label3.TabIndex = 4;
            label3.Text = "Ingrese un número para saber si es par o impar";
            // 
            // Ejercicio7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(644, 455);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(btnResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio7";
            Text = "Programa 7-Numero par e impar";
            Load += Ejercicio7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnResultado;
        private TextBox txtNumero;
        private Label label3;
    }
}