namespace _1_2026_TAREA_I
{
    partial class Ejercicio4
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
            txtValor = new TextBox();
            btnCalcular = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(110, 58);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un número";
            label1.Click += label1_Click;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(165, 129);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(156, 29);
            txtValor.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Honeydew;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(142, 192);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(192, 53);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular raíz cuadrada";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            btnCalcular.MouseHover += btn_Hover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(197, 280);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtResultado.Location = new Point(165, 320);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(160, 29);
            txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 438);
            label3.Name = "label3";
            label3.Size = new Size(305, 17);
            label3.TabIndex = 5;
            label3.Text = "Digite un número para obtener su raíz cuadrada";
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(507, 487);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "Ejercicio4";
            Text = "Programa 4-Raiz cuadrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtResultado;
        private Label label3;
    }
}