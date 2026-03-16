namespace _1_2026_TAREA_I
{
    partial class Ejercicio3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_ValorA = new TextBox();
            txt_ValorB = new TextBox();
            txt_ValorC = new TextBox();
            btnResultado = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl1.Location = new Point(126, 77);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(238, 37);
            lbl1.TabIndex = 0;
            lbl1.Text = "Digite 3 números";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(155, 169);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 1;
            label1.Text = "Valor A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(156, 296);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Valor C:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(156, 229);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 3;
            label3.Text = "Valor B:";
            // 
            // txt_ValorA
            // 
            txt_ValorA.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txt_ValorA.Location = new Point(231, 167);
            txt_ValorA.Name = "txt_ValorA";
            txt_ValorA.Size = new Size(100, 27);
            txt_ValorA.TabIndex = 4;
            // 
            // txt_ValorB
            // 
            txt_ValorB.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txt_ValorB.Location = new Point(231, 227);
            txt_ValorB.Name = "txt_ValorB";
            txt_ValorB.Size = new Size(100, 27);
            txt_ValorB.TabIndex = 5;
            // 
            // txt_ValorC
            // 
            txt_ValorC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txt_ValorC.Location = new Point(231, 294);
            txt_ValorC.Name = "txt_ValorC";
            txt_ValorC.Size = new Size(100, 27);
            txt_ValorC.TabIndex = 6;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.HotPink;
            btnResultado.Cursor = Cursors.Hand;
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(155, 368);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(173, 45);
            btnResultado.TabIndex = 7;
            btnResultado.Text = "Mostrar resultado";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            btnResultado.MouseHover += btn_Hover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(92, 486);
            label4.Name = "label4";
            label4.Size = new Size(321, 17);
            label4.TabIndex = 8;
            label4.Text = "Ingrese 3 valores para conocer el mayor de los tres";
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(505, 529);
            Controls.Add(label4);
            Controls.Add(btnResultado);
            Controls.Add(txt_ValorC);
            Controls.Add(txt_ValorB);
            Controls.Add(txt_ValorA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Name = "Ejercicio3";
            Text = "Programa 3-Mayor de 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_ValorA;
        private TextBox txt_ValorB;
        private TextBox txt_ValorC;
        private Button btnResultado;
        private Label label4;
    }
}