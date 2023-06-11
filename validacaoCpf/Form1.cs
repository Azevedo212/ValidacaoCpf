namespace validacaoCpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_resultado.Text = "";
            lb_invalido.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            string idade = tx_idade.Text;
            string sexo = tx_sexo.Text;
            double peso = Convert.ToDouble(tx_peso.Text);
            double altura = Convert.ToDouble(tx_altura.Text);

            if (Validacao.ValidaCPF(cpf) == true)
            {
                Pessoa p = new Pessoa(nome, cpf, idade, sexo, peso, altura);
                (string classificacao, string grau, double imc) = p.CalcularIMC();
                lb_resultado.Text = $" classificação: {classificacao}\n grau: {grau}\n Imc: {imc.ToString("0.00")}\n";
                lb_invalido.Text = " ";
            }

            else
            {
                lb_invalido.Text = "O CPF é inválido!";
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_idade.Clear();
            tx_sexo.ResetText();
            tx_peso.ResetText();
            tx_altura.ResetText();
            lb_resultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}