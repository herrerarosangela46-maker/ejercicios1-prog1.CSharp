namespace _1_2026_TAREA_I
{
    partial class Ejercicio8
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
            txt_valor = new TextBox();
            txt_Resultado = new TextBox();
            btn_Convertir = new Button();
            label2 = new Label();
            btn_Celsius = new RadioButton();
            btn_Fahrenheit = new RadioButton();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(101, 56);
            label1.Name = "label1";
            label1.Size = new Size(491, 32);
            label1.TabIndex = 0;
            label1.Text = "Conversión de grados fahrenheit y celsius";
            // 
            // txt_valor
            // 
            txt_valor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txt_valor.Location = new Point(326, 160);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(186, 33);
            txt_valor.TabIndex = 1;
            // 
            // txt_Resultado
            // 
            txt_Resultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txt_Resultado.Location = new Point(237, 389);
            txt_Resultado.Name = "txt_Resultado";
            txt_Resultado.Size = new Size(191, 33);
            txt_Resultado.TabIndex = 2;
            // 
            // btn_Convertir
            // 
            btn_Convertir.Cursor = Cursors.Hand;
            btn_Convertir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Convertir.Location = new Point(261, 304);
            btn_Convertir.Name = "btn_Convertir";
            btn_Convertir.Size = new Size(143, 52);
            btn_Convertir.TabIndex = 3;
            btn_Convertir.Text = "Convertir";
            btn_Convertir.UseVisualStyleBackColor = true;
            btn_Convertir.Click += btn_Convertir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(137, 163);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 4;
            label2.Text = "Ingrese un valor";
            // 
            // btn_Celsius
            // 
            btn_Celsius.AutoSize = true;
            btn_Celsius.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_Celsius.Location = new Point(184, 226);
            btn_Celsius.Name = "btn_Celsius";
            btn_Celsius.Size = new Size(75, 24);
            btn_Celsius.TabIndex = 5;
            btn_Celsius.TabStop = true;
            btn_Celsius.Text = "Celsius";
            btn_Celsius.UseVisualStyleBackColor = true;
            // 
            // btn_Fahrenheit
            // 
            btn_Fahrenheit.AutoSize = true;
            btn_Fahrenheit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_Fahrenheit.Location = new Point(365, 226);
            btn_Fahrenheit.Name = "btn_Fahrenheit";
            btn_Fahrenheit.Size = new Size(102, 24);
            btn_Fahrenheit.TabIndex = 6;
            btn_Fahrenheit.TabStop = true;
            btn_Fahrenheit.Text = "Fahrenheit";
            btn_Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 456);
            label3.Name = "label3";
            label3.Size = new Size(483, 17);
            label3.TabIndex = 7;
            label3.Text = "Ingrese un valor y seleccione fahrenheit o celsius para obtener su conversión";
            // 
            // Ejercicio8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(720, 495);
            Controls.Add(label3);
            Controls.Add(btn_Fahrenheit);
            Controls.Add(btn_Celsius);
            Controls.Add(label2);
            Controls.Add(btn_Convertir);
            Controls.Add(txt_Resultado);
            Controls.Add(txt_valor);
            Controls.Add(label1);
            Name = "Ejercicio8";
            Text = "Programa 8-Conversion de grados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_valor;
        private TextBox txt_Resultado;
        private Button btn_Convertir;
        private Label label2;
        private RadioButton btn_Celsius;
        private RadioButton btn_Fahrenheit;
        private Label label3;
    }
}