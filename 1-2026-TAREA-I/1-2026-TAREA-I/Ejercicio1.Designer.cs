namespace _1_2026_TAREA_I
{
    partial class Ejercicio1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblValorA = new Label();
            label3 = new Label();
            lblValorB = new Label();
            btnResultado = new Button();
            txtResultado = new TextBox();
            txtValorA = new TextBox();
            txtValorB = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 39);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 0;
            label1.Text = "División";
            // 
            // lblValorA
            // 
            lblValorA.AutoSize = true;
            lblValorA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValorA.Location = new Point(60, 155);
            lblValorA.Name = "lblValorA";
            lblValorA.Size = new Size(69, 21);
            lblValorA.TabIndex = 1;
            lblValorA.Text = "Valor A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(300, 159);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 2;
            label3.Text = "Entre";
            // 
            // lblValorB
            // 
            lblValorB.AutoSize = true;
            lblValorB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValorB.Location = new Point(410, 155);
            lblValorB.Name = "lblValorB";
            lblValorB.Size = new Size(68, 21);
            lblValorB.TabIndex = 3;
            lblValorB.Text = "Valor B:";
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.MistyRose;
            btnResultado.Cursor = Cursors.Hand;
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(257, 263);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(126, 36);
            btnResultado.TabIndex = 5;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            btnResultado.MouseHover += result_hover;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtResultado.Location = new Point(257, 331);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(126, 29);
            txtResultado.TabIndex = 6;
            // 
            // txtValorA
            // 
            txtValorA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtValorA.Location = new Point(135, 152);
            txtValorA.Name = "txtValorA";
            txtValorA.Size = new Size(100, 29);
            txtValorA.TabIndex = 7;
            // 
            // txtValorB
            // 
            txtValorB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtValorB.Location = new Point(484, 152);
            txtValorB.Name = "txtValorB";
            txtValorB.Size = new Size(100, 29);
            txtValorB.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(327, 26);
            // 
            // digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem
            // 
            digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem.Name = "digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem";
            digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem.Size = new Size(326, 22);
            digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem.Text = "Digite 2 valores para obtener la división de estos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 419);
            label2.Name = "label2";
            label2.Size = new Size(318, 17);
            label2.TabIndex = 9;
            label2.Text = "Ingrese 2 valores para obtener la división de estos";
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(661, 460);
            Controls.Add(label2);
            Controls.Add(txtValorB);
            Controls.Add(txtValorA);
            Controls.Add(txtResultado);
            Controls.Add(btnResultado);
            Controls.Add(lblValorB);
            Controls.Add(label3);
            Controls.Add(lblValorA);
            Controls.Add(label1);
            Name = "Ejercicio1";
            Text = "Programa 1-Division";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblValorA;
        private Label label3;
        private Label lblValorB;
        private Button btnResultado;
        private TextBox txtResultado;
        private TextBox txtValorA;
        private TextBox txtValorB;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem digite2ValoresParaObtenerLaDivisiónDeEstosToolStripMenuItem;
        private Label label2;
    }
}
