using System.Globalization;

namespace MinhaCalculadora
{
    public partial class Form1 : Form
    {
        int opcao = 0;
        double n1, n2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Botoes(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            txtResultado.Text = txtResultado.Text + num.Text;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            opcao = 1;
            if (txtResultado.Text != "")
            {
                n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = " ";
                lblOperacao.Text = " + ";
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            opcao = 2;
            if (txtResultado.Text != "")
            {
                n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = " ";
                lblOperacao.Text = " - ";
            }

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            opcao = 3;
            if (txtResultado.Text != "")
            {
                n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = " ";
                lblOperacao.Text = " * ";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            opcao = 4;
            if (txtResultado.Text != "")
            {
                n1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = " ";
                lblOperacao.Text = " ÷ ";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            lblOperacao.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            Calculadora calc = new Calculadora();

            if (opcao == 1)
            {

                n2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                calc.SetNum1(n1);
                calc.SetNum2(n2);

                txtResultado.Text = calc.Somar().ToString("f2", CultureInfo.InvariantCulture);
            }
            else if (opcao == 2)
            {
                n2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                calc.SetNum1(n1);
                calc.SetNum2(n2);

                txtResultado.Text = calc.Subtrair().ToString("f2", CultureInfo.InvariantCulture);
            }
            else if (opcao == 3)
            {
                n2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                calc.SetNum1(n1);
                calc.SetNum2(n2);

                txtResultado.Text = calc.Multiplicar().ToString("f2", CultureInfo.InvariantCulture);
            }
            else if (opcao == 4)
            {
                n2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                calc.SetNum1(n1);
                calc.SetNum2(n2);

                txtResultado.Text = calc.Dividir().ToString("f2", CultureInfo.InvariantCulture);
            }

        }
    }
}