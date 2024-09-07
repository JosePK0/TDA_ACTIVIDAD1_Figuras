namespace ACT_Figuras
{
    partial class DatosTriangulo
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
            DatAreaT = new Panel();
            AlturaTri = new TextBox();
            BaseTri = new TextBox();
            label2 = new Label();
            Label3 = new Label();
            DatPerimetroT = new Panel();
            btnPerimetroTri = new Button();
            LadoTri3 = new TextBox();
            LadoTri2 = new TextBox();
            LadoTri1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnAreaTri = new Button();
            errorProvider1 = new ErrorProvider(components);
            label7 = new Label();
            btnVolver = new Button();
            DatAreaT.SuspendLayout();
            DatPerimetroT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 32);
            label1.TabIndex = 1;
            label1.Text = "Datos De Triangulo";
            // 
            // DatAreaT
            // 
            DatAreaT.BackColor = SystemColors.ActiveBorder;
            DatAreaT.Controls.Add(AlturaTri);
            DatAreaT.Controls.Add(BaseTri);
            DatAreaT.Controls.Add(label2);
            DatAreaT.Controls.Add(Label3);
            DatAreaT.Location = new Point(52, 103);
            DatAreaT.Name = "DatAreaT";
            DatAreaT.Size = new Size(227, 343);
            DatAreaT.TabIndex = 2;
            // 
            // AlturaTri
            // 
            AlturaTri.Location = new Point(38, 176);
            AlturaTri.Name = "AlturaTri";
            AlturaTri.Size = new Size(126, 23);
            AlturaTri.TabIndex = 3;
            // 
            // BaseTri
            // 
            BaseTri.Location = new Point(38, 77);
            BaseTri.Name = "BaseTri";
            BaseTri.Size = new Size(126, 23);
            BaseTri.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 133);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Altura";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(50, 18);
            Label3.Name = "Label3";
            Label3.Size = new Size(52, 25);
            Label3.TabIndex = 0;
            Label3.Text = "Base";
            // 
            // DatPerimetroT
            // 
            DatPerimetroT.BackColor = SystemColors.ActiveBorder;
            DatPerimetroT.Controls.Add(btnPerimetroTri);
            DatPerimetroT.Controls.Add(LadoTri3);
            DatPerimetroT.Controls.Add(LadoTri2);
            DatPerimetroT.Controls.Add(LadoTri1);
            DatPerimetroT.Controls.Add(label5);
            DatPerimetroT.Controls.Add(label6);
            DatPerimetroT.Controls.Add(label4);
            DatPerimetroT.Location = new Point(408, 103);
            DatPerimetroT.Name = "DatPerimetroT";
            DatPerimetroT.Size = new Size(216, 343);
            DatPerimetroT.TabIndex = 3;
            // 
            // btnPerimetroTri
            // 
            btnPerimetroTri.Location = new Point(70, 298);
            btnPerimetroTri.Name = "btnPerimetroTri";
            btnPerimetroTri.Size = new Size(75, 23);
            btnPerimetroTri.TabIndex = 5;
            btnPerimetroTri.Text = "Perimetro";
            btnPerimetroTri.UseVisualStyleBackColor = true;
            btnPerimetroTri.Click += btnPerimetroTri_Click;
            // 
            // LadoTri3
            // 
            LadoTri3.Location = new Point(19, 243);
            LadoTri3.Name = "LadoTri3";
            LadoTri3.Size = new Size(126, 23);
            LadoTri3.TabIndex = 6;
            // 
            // LadoTri2
            // 
            LadoTri2.Location = new Point(19, 152);
            LadoTri2.Name = "LadoTri2";
            LadoTri2.Size = new Size(126, 23);
            LadoTri2.TabIndex = 4;
            // 
            // LadoTri1
            // 
            LadoTri1.Location = new Point(19, 68);
            LadoTri1.Name = "LadoTri1";
            LadoTri1.Size = new Size(126, 23);
            LadoTri1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 108);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 5;
            label5.Text = "Lado 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 196);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 4;
            label6.Text = "Lado 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 18);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 2;
            label4.Text = "Lado 1";
            // 
            // btnAreaTri
            // 
            btnAreaTri.Location = new Point(121, 344);
            btnAreaTri.Name = "btnAreaTri";
            btnAreaTri.Size = new Size(75, 23);
            btnAreaTri.TabIndex = 4;
            btnAreaTri.Text = "Area";
            btnAreaTri.UseVisualStyleBackColor = true;
            btnAreaTri.Click += btnAreaTri_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            errorProvider1.SetIconAlignment(label7, ErrorIconAlignment.BottomLeft);
            label7.Location = new Point(293, 64);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 8;
            label7.Text = "Calcular";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.Location = new Point(713, 383);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 55);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // DatosTriangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(btnVolver);
            Controls.Add(btnAreaTri);
            Controls.Add(DatPerimetroT);
            Controls.Add(DatAreaT);
            Controls.Add(label1);
            Name = "DatosTriangulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Triangulo";
            DatAreaT.ResumeLayout(false);
            DatAreaT.PerformLayout();
            DatPerimetroT.ResumeLayout(false);
            DatPerimetroT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel DatAreaT;
        private Panel DatPerimetroT;
        private Label Label3;
        private Button btnAreaTri;
        private Button btnPerimetroTri;
        private Label label2;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox AlturaTri;
        private TextBox BaseTri;
        private TextBox LadoTri3;
        private TextBox LadoTri2;
        private TextBox LadoTri1;
        private ErrorProvider errorProvider1;
        private Button btnVolver;
        private Label label7;
    }
}