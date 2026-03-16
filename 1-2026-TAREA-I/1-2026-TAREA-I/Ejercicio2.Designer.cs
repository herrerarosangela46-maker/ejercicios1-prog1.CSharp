namespace _1_2026_TAREA_I
{
    partial class Ejercicio2
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
            btnResultado = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(128, 92);
            label1.Name = "label1";
            label1.Size = new Size(265, 32);
            label1.TabIndex = 0;
            label1.Text = "Comparar número a 0";
            label1.Click += label1_Click;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(171, 232);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(180, 29);
            txtValor.TabIndex = 1;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.CornflowerBlue;
            btnResultado.Cursor = Cursors.Hand;
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResultado.Location = new Point(171, 296);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(181, 63);
            btnResultado.TabIndex = 2;
            btnResultado.Text = "Mostrar resultado";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            btnResultado.MouseHover += btn_Hover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 197);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 3;
            label2.Text = "Digite un número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 418);
            label3.Name = "label3";
            label3.Size = new Size(402, 17);
            label3.TabIndex = 4;
            label3.Text = "Ingrese un número para saber si es mayor, menor o igual a cero";
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(527, 469);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnResultado);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "Ejercicio2";
            Text = "Programa 2-Mayor que 0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Button btnResultado;
        private Label label2;
        private Label label3;
    }
}