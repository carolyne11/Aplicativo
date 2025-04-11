namespace Aplicativo
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            label1 = new Label();
            label2 = new Label();
            txtLoginEmpresa = new TextBox();
            txtSenhaEmpresa = new TextBox();
            btnEntrar = new Button();
            btnEmpresa = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 183);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 221);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // txtLoginEmpresa
            // 
            txtLoginEmpresa.Location = new Point(309, 175);
            txtLoginEmpresa.Name = "txtLoginEmpresa";
            txtLoginEmpresa.Size = new Size(193, 23);
            txtLoginEmpresa.TabIndex = 2;
            // 
            // txtSenhaEmpresa
            // 
            txtSenhaEmpresa.Location = new Point(309, 213);
            txtSenhaEmpresa.Name = "txtSenhaEmpresa";
            txtSenhaEmpresa.Size = new Size(192, 23);
            txtSenhaEmpresa.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(365, 252);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Location = new Point(723, 415);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(73, 33);
            btnEmpresa.TabIndex = 6;
            btnEmpresa.Text = "Empresa";
            btnEmpresa.UseVisualStyleBackColor = true;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 447);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(358, 147);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 8;
            label3.Text = "Bem Vindo(a)";
            label3.Click += label3_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(2, 415);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(96, 33);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(btnEmpresa);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenhaEmpresa);
            Controls.Add(txtLoginEmpresa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLoginEmpresa;
        private TextBox txtSenhaEmpresa;
        private Button btnEntrar;
        private Button btnEmpresa;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnCadastrar;
    }
}
