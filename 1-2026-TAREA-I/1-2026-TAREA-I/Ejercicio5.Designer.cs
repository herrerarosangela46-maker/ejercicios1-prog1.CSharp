namespace _1_2026_TAREA_I
{
    partial class Ejercicio5
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
            label3 = new Label();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            label4 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 52);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 0;
            label1.Text = "Área de un triángulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(115, 133);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 1;
            label2.Text = "Base:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(115, 212);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // txtBase
            // 
            txtBase.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtBase.Location = new Point(198, 130);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(129, 29);
            txtBase.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtAltura.Location = new Point(200, 204);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(127, 29);
            txtAltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Honeydew;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(162, 271);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 41);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            btnCalcular.MouseHover += btn_Hover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 367);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 6;
            label4.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(200, 359);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(129, 29);
            txtResultado.TabIndex = 7;
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(470, 458);
            Controls.Add(txtResultado);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio5";
            Text = "Programa 5-Area de un triangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBase;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label label4;
        private TextBox txtResultado;
    }
}