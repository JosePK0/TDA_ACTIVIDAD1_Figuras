namespace ACT_Figuras
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btnCirculo = new PictureBox();
            btnTriangulo = new PictureBox();
            btnRectangulo = new PictureBox();
            btnCuadrado = new PictureBox();
            label1 = new Label();
            btnSalir = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnCirculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTriangulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRectangulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCuadrado).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCirculo
            // 
            btnCirculo.Image = (Image)resources.GetObject("btnCirculo.Image");
            btnCirculo.Location = new Point(0, 0);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(142, 111);
            btnCirculo.SizeMode = PictureBoxSizeMode.Zoom;
            btnCirculo.TabIndex = 0;
            btnCirculo.TabStop = false;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnTriangulo
            // 
            btnTriangulo.Image = (Image)resources.GetObject("btnTriangulo.Image");
            btnTriangulo.Location = new Point(0, 0);
            btnTriangulo.Name = "btnTriangulo";
            btnTriangulo.Size = new Size(142, 111);
            btnTriangulo.SizeMode = PictureBoxSizeMode.Zoom;
            btnTriangulo.TabIndex = 1;
            btnTriangulo.TabStop = false;
            btnTriangulo.Click += btnTriangulo_Click;
            // 
            // btnRectangulo
            // 
            btnRectangulo.Image = (Image)resources.GetObject("btnRectangulo.Image");
            btnRectangulo.Location = new Point(0, 0);
            btnRectangulo.Name = "btnRectangulo";
            btnRectangulo.Size = new Size(142, 111);
            btnRectangulo.SizeMode = PictureBoxSizeMode.Zoom;
            btnRectangulo.TabIndex = 2;
            btnRectangulo.TabStop = false;
            btnRectangulo.Click += btnRectangulo_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Image = (Image)resources.GetObject("btnCuadrado.Image");
            btnCuadrado.Location = new Point(0, 0);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(142, 111);
            btnCuadrado.SizeMode = PictureBoxSizeMode.Zoom;
            btnCuadrado.TabIndex = 3;
            btnCuadrado.TabStop = false;
            btnCuadrado.Click += btnCuadrado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 32);
            label1.TabIndex = 4;
            label1.Text = "Calculadora de Perimetros y Areas";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.Location = new Point(713, 384);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 54);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 68);
            label2.Name = "label2";
            label2.Size = new Size(231, 32);
            label2.TabIndex = 6;
            label2.Text = "Seleciona la figura";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnCirculo);
            panel1.Location = new Point(122, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 111);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnRectangulo);
            panel2.Location = new Point(122, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 111);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(btnCuadrado);
            panel3.Location = new Point(471, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(142, 111);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Controls.Add(btnTriangulo);
            panel4.Location = new Point(471, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(142, 111);
            panel4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(156, 253);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 10;
            label3.Text = "Circulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(497, 253);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 11;
            label4.Text = "Triangulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(142, 417);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 12;
            label5.Text = "Retangulo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(497, 417);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 13;
            label6.Text = "Cuadrado";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)btnCirculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTriangulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRectangulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCuadrado).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnCirculo;
        private PictureBox btnTriangulo;
        private PictureBox btnRectangulo;
        private PictureBox btnCuadrado;
        private Label label1;
        private Button btnSalir;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
