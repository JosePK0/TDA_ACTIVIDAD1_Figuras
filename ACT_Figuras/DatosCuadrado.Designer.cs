namespace ACT_Figuras
{
    partial class DatosCuadrado
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            DatCuadrado = new Panel();
            Lado1Cua = new TextBox();
            label2 = new Label();
            btnAreaCua = new Button();
            btnPerimetro = new Button();
            btnVolver = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            DatCuadrado.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 32);
            label1.TabIndex = 0;
            label1.Text = "Datos Del Cuadrado";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            errorProvider1.SetIconAlignment(label3, ErrorIconAlignment.BottomLeft);
            label3.Location = new Point(295, 89);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 8;
            label3.Text = "Calcular";
            // 
            // DatCuadrado
            // 
            DatCuadrado.BackColor = SystemColors.ActiveBorder;
            DatCuadrado.Controls.Add(Lado1Cua);
            DatCuadrado.Controls.Add(label2);
            DatCuadrado.Location = new Point(43, 161);
            DatCuadrado.Name = "DatCuadrado";
            DatCuadrado.Size = new Size(276, 134);
            DatCuadrado.TabIndex = 1;
            // 
            // Lado1Cua
            // 
            Lado1Cua.Location = new Point(42, 71);
            Lado1Cua.Name = "Lado1Cua";
            Lado1Cua.Size = new Size(155, 23);
            Lado1Cua.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 23);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 0;
            label2.Text = "Lado ";
            // 
            // btnAreaCua
            // 
            btnAreaCua.Location = new Point(43, 10);
            btnAreaCua.Name = "btnAreaCua";
            btnAreaCua.Size = new Size(110, 23);
            btnAreaCua.TabIndex = 4;
            btnAreaCua.Text = "Area";
            btnAreaCua.UseVisualStyleBackColor = true;
            btnAreaCua.Click += btnAreaCua_Click;
            // 
            // btnPerimetro
            // 
            btnPerimetro.Location = new Point(43, 99);
            btnPerimetro.Name = "btnPerimetro";
            btnPerimetro.Size = new Size(110, 23);
            btnPerimetro.TabIndex = 5;
            btnPerimetro.Text = "Perimetro";
            btnPerimetro.UseVisualStyleBackColor = true;
            btnPerimetro.Click += btnPerimetro_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.Location = new Point(713, 383);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 55);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btnPerimetro);
            panel1.Controls.Add(btnAreaCua);
            panel1.Location = new Point(400, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 139);
            panel1.TabIndex = 7;
            // 
            // DatosCuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(DatCuadrado);
            Controls.Add(label1);
            Name = "DatosCuadrado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cuadrado";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            DatCuadrado.ResumeLayout(false);
            DatCuadrado.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ErrorProvider errorProvider1;
        private Panel DatCuadrado;
        private Label label2;
        private TextBox Lado1Cua;
        private Button btnAreaCua;
        private Button btnPerimetro;
        private Button btnVolver;
        private Panel panel1;
        private Label label3;
    }
}