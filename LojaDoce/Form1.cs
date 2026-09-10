namespace LojaDoce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            //
            try
            {
                Pedido pedido = new Pedido();

                // 

                pedido.NomeDoce = txtNomeDoce.Text;

                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);

                pedido.Quantidade = int.Parse(txtQuantidade.Text);

                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);

                // UTILIZAÇÃO DO OBJETO                
                // Chamamos os métodos da classe e exibimos nas Labels 
                double desconto = pedido.CalcularDesconto();
                double valorFinal = pedido.CalcularValorFinal();
                double parcela = pedido.CalcularParcela();
                bool brindeAprovado = pedido.ValidarBrinde();

                //Exibindo os dados formatatos na tela

                lblNome.Text = $"{pedido.NomeDoce.ToUpper()}";
                lblDesconto.Text = $"R$ {desconto:N2}";
                lblValorFinal.Text = $"R${valorFinal:N2}";
                lblParcela.Text = $"3x de R${parcela:N2}";

                //Limpando campos
                txtNomeDoce.Clear();
                txtPrecoUnitario.Clear();
                txtQuantidade.Clear();
                txtIdadeCliente.Clear();

                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Vocé ganhou um brinde surpresa!";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Blue;
                }

            }

            catch (FormatException)
            {
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                    "Erro de Digitação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }


        }

        private void lblPrecoUnitario_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeDoce_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
