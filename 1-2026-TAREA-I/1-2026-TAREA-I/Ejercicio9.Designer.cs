namespace _1_2026_TAREA_I
{
    partial class Ejercicio9
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
            btn_Ver = new Button();
            txtCiudad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 104);
            label1.Name = "label1";
            label1.Size = new Size(273, 32);
            label1.TabIndex = 0;
            label1.Text = "Ciudades Dominicanas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(167, 191);
            label2.Name = "label2";
            label2.Size = new Size(265, 25);
            label2.TabIndex = 1;
            label2.Text = "Digite un número del 1 al 10";
            // 
            // btn_Ver
            // 
            btn_Ver.BackColor = Color.MediumSlateBlue;
            btn_Ver.Cursor = Cursors.Hand;
            btn_Ver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Ver.Location = new Point(249, 338);
            btn_Ver.Name = "btn_Ver";
            btn_Ver.Size = new Size(113, 45);
            btn_Ver.TabIndex = 2;
            btn_Ver.Text = "Mostrar";
            btn_Ver.UseVisualStyleBackColor = false;
            btn_Ver.Click += btn_Ver_Click;
            btn_Ver.MouseHover += btn_Hover;
            // 
            // txtCiudad
            // 
            txtCiudad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtCiudad.Location = new Point(216, 265);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(175, 33);
            txtCiudad.TabIndex = 3;
            // 
            // Ejercicio9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(613, 466);
            Controls.Add(txtCiudad);
            Controls.Add(btn_Ver);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio9";
            Text = "Programa 9-Ciudades dominicanas";
            Load += Ejercicio9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_Ver;
        private TextBox txtCiudad;
    }
}