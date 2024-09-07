namespace ACT_Figuras
{
    partial class DatosRectangulos
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
            DatRect = new Panel();
            BaseRect = new TextBox();
            AlturaRect = new TextBox();
            BaseRec = new Label();
            AlturaRec = new Label();
            btnAreaRec = new Button();
            btnPerimetroRec = new Button();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            btnVolver = new Button();
            panel1 = new Panel();
            DatRect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 32);
            label1.TabIndex = 0;
            label1.Text = "Datos De Rectangulos";
            // 
            // DatRect
            // 
            DatRect.BackColor = SystemColors.ActiveBorder;
            DatRect.Controls.Add(BaseRect);
            DatRect.Controls.Add(AlturaRect);
            DatRect.Controls.Add(BaseRec);
            DatRect.Controls.Add(AlturaRec);
            DatRect.Location = new Point(28, 129);
            DatRect.Name = "DatRect";
            DatRect.Size = new Size(271, 223);
            DatRect.TabIndex = 1;
            // 
            // BaseRect
            // 
            BaseRect.Location = new Point(41, 141);
            BaseRect.Name = "BaseRect";
            BaseRect.Size = new Size(141, 23);
            BaseRect.TabIndex = 3;
            // 
            // AlturaRect
            // 
            AlturaRect.Location = new Point(41, 65);
            AlturaRect.Name = "AlturaRect";
            AlturaRect.Size = new Size(141, 23);
            AlturaRect.TabIndex = 2;
            // 
            // BaseRec
            // 
            BaseRec.AutoSize = true;
            BaseRec.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BaseRec.Location = new Point(41, 108);
            BaseRec.Name = "BaseRec";
            BaseRec.Size = new Size(57, 30);
            BaseRec.TabIndex = 1;
            BaseRec.Text = "Base";
            // 
            // AlturaRec
            // 
            AlturaRec.AutoSize = true;
            AlturaRec.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AlturaRec.Location = new Point(41, 12);
            AlturaRec.Name = "AlturaRec";
            AlturaRec.Size = new Size(74, 30);
            AlturaRec.TabIndex = 0;
            AlturaRec.Text = "Altura";
            // 
            // btnAreaRec
            // 
            btnAreaRec.Location = new Point(42, 54);
            btnAreaRec.Name = "btnAreaRec";
            btnAreaRec.Size = new Size(75, 23);
            btnAreaRec.TabIndex = 2;
            btnAreaRec.Text = "Area";
            btnAreaRec.UseVisualStyleBackColor = true;
            btnAreaRec.Click += btnAreaRec_Click;
            // 
            // btnPerimetroRec
            // 
            btnPerimetroRec.Location = new Point(42, 141);
            btnPerimetroRec.Name = "btnPerimetroRec";
            btnPerimetroRec.Size = new Size(75, 23);
            btnPerimetroRec.TabIndex = 3;
            btnPerimetroRec.Text = "Perimetro";
            btnPerimetroRec.UseVisualStyleBackColor = true;
            btnPerimetroRec.Click += btnPerimetroRec_Click;
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
            label3.Location = new Point(335, 75);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 8;
            label3.Text = "Calcular";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.Location = new Point(713, 383);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 55);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btnAreaRec);
            panel1.Controls.Add(btnPerimetroRec);
            panel1.Location = new Point(379, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 223);
            panel1.TabIndex = 5;
            // 
            // DatosRectangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnVolver);
            Controls.Add(DatRect);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "DatosRectangulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rectangulo";
            DatRect.ResumeLayout(false);
            DatRect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel DatRect;
        private Label BaseRec;
        private Label AlturaRec;
        private TextBox BaseRect;
        private TextBox AlturaRect;
        private Button btnAreaRec;
        private Button btnPerimetroRec;
        private ErrorProvider errorProvider1;
        private Button btnVolver;
        private Panel panel1;
        private Label label3;
    }
}