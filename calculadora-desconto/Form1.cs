using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_desconto
{
    public partial class frmCalculadoraDesconto : Form
    {
        public frmCalculadoraDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Recebendo o valor da compra e o valor do desconto requirido
                decimal preco = decimal.Parse(txtValorCompra.Text);
                decimal desconto = decimal.Parse(txtDesconto.Text);

                // Calculando o valor da compra com o desconto
                decimal valorDesconto = (preco * desconto) / 100;
                decimal precoFinal = preco - valorDesconto;

                // Exibindo o valor final
                lblValorFinal.Text = $"R$ {precoFinal:F2}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço/desconto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
