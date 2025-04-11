namespace Aplicativo
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender,EventArgs e)
        {
            label3.BackColor = this.BackColor;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void picturebox2_Click(object sender,EventArgs e)
        {
            
        }

        private void btnEmpresa_Click(object sender,EventArgs e)
        {
            TelaEmpresa tela = new TelaEmpresa();
            tela.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender,EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }



    }
}
