namespace ACT_Figuras
{
    partial class DatosCirculo
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
            btnVolver = new Button();
            label2 = new Label();
            RadioCir = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            DatCir = new Panel();
            btnPerimetroCir = new Button();
            btnAreaCir = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            DatCir.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            errorProvider1.SetIconAlignment(label1, ErrorIconAlignment.BottomLeft);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 0;
            label1.Text = "Datos del Circulo";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.Location = new Point(713, 383);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 55);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(59, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Radios";
            // 
            // RadioCir
            // 
            RadioCir.Location = new Point(26, 83);
            RadioCir.Name = "RadioCir";
            RadioCir.Size = new Size(150, 23);
            RadioCir.TabIndex = 3;
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
            label3.Location = new Point(330, 83);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 7;
            label3.Text = "Calcular";
            // 
            // DatCir
            // 
            DatCir.BackColor = SystemColors.ActiveBorder;
            DatCir.Controls.Add(label2);
            DatCir.Controls.Add(RadioCir);
            DatCir.Location = new Point(107, 147);
            DatCir.Name = "DatCir";
            DatCir.Size = new Size(200, 197);
            DatCir.TabIndex = 6;
            // 
            // btnPerimetroCir
            // 
            btnPerimetroCir.Location = new Point(35, 104);
            btnPerimetroCir.Name = "btnPerimetroCir";
            btnPerimetroCir.Size = new Size(75, 23);
            btnPerimetroCir.TabIndex = 5;
            btnPerimetroCir.Text = "Perimetro";
            btnPerimetroCir.UseVisualStyleBackColor = true;
            btnPerimetroCir.Click += btnPerimetroCir_Click;
            // 
            // btnAreaCir
            // 
            btnAreaCir.Location = new Point(35, 39);
            btnAreaCir.Name = "btnAreaCir";
            btnAreaCir.Size = new Size(75, 23);
            btnAreaCir.TabIndex = 4;
            btnAreaCir.Text = "Area";
            btnAreaCir.UseVisualStyleBackColor = true;
            btnAreaCir.Click += btnAreaCir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(btnAreaCir);
            panel2.Controls.Add(btnPerimetroCir);
            panel2.Location = new Point(398, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 174);
            panel2.TabIndex = 7;
            // 
            // DatosCirculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(DatCir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DatosCirculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Circulo";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            DatCir.ResumeLayout(false);
            DatCir.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVolver;
        private Label label2;
        private TextBox RadioCir;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Panel DatCir;
        private Panel panel2;
        private Button btnAreaCir;
        private Button btnPerimetroCir;
    }
}