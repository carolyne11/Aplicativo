namespace Aplicativo
{
    partial class TelaEmpresa
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
            txtLoginColaborador = new TextBox();
            txtSenhaColaborador = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 103);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 145);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // txtLoginColaborador
            // 
            txtLoginColaborador.Location = new Point(230, 100);
            txtLoginColaborador.Name = "txtLoginColaborador";
            txtLoginColaborador.Size = new Size(174, 23);
            txtLoginColaborador.TabIndex = 2;
            txtLoginColaborador.TextChanged += textBox1_TextChanged;
            // 
            // txtSenhaColaborador
            // 
            txtSenhaColaborador.Location = new Point(230, 137);
            txtSenhaColaborador.Name = "txtSenhaColaborador";
            txtSenhaColaborador.Size = new Size(174, 23);
            txtSenhaColaborador.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.pie_chart_wladimir_bulgarscience_photo_library1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(586, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TelaEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 254);
            Controls.Add(txtSenhaColaborador);
            Controls.Add(txtLoginColaborador);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaEmpresa";
            Text = "telaColaborador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLoginColaborador;
        private TextBox txtSenhaColaborador;
        private PictureBox pictureBox1;
    }
}