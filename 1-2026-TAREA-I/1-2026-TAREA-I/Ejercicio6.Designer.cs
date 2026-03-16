namespace _1_2026_TAREA_I
{
    partial class Ejercicio6
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
            lbl1 = new Label();
            lbl2 = new Label();
            txtNumero = new TextBox();
            btnResultado = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(83, 67);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(336, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "Número positivo o negativo";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl2.Location = new Point(171, 186);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(145, 21);
            lbl2.TabIndex = 1;
            lbl2.Text = "Digite un número";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumero.Location = new Point(160, 239);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(166, 29);
            txtNumero.TabIndex = 2;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.LavenderBlush;
            btnResultado.Cursor = Cursors.Hand;
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(191, 317);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(108, 43);
            btnResultado.TabIndex = 3;
            btnResultado.Text = "Mostrar";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            btnResultado.MouseHover += btn_Hover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 417);
            label1.Name = "label1";
            label1.Size = new Size(348, 17);
            label1.TabIndex = 4;
            label1.Text = "Ingrese un número para saber si es positivo o negativo";
            // 
            // Ejercicio6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(524, 462);
            Controls.Add(label1);
            Controls.Add(btnResultado);
            Controls.Add(txtNumero);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Ejercicio6";
            Text = "Programa 6-Numero + o -";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txtNumero;
        private Button btnResultado;
        private Label label1;
    }
}