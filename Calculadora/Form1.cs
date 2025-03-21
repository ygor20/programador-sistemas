using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public decimal Resultado { get; set; }
        public decimal valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            valor = Convert.ToDecimal( txtVisor.Text); 
            txtVisor.Text = "";
            lblOperacao.Text = "+";
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "*";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            valor = Convert.ToDecimal(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "-";

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToDecimal(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "/";

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                
                case Operacao.Adicao:
                    Resultado = valor + Convert.ToDecimal (txtVisor.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = valor - Convert.ToDecimal(txtVisor.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = valor * Convert.ToDecimal(txtVisor.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = valor / Convert.ToDecimal(txtVisor.Text);
                    break;
            }
            txtVisor.Text = Convert.ToString ( Resultado);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text.Contains(","))
            txtVisor.Text += ",";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            lblOperacao.Text = "";

        }
    }
}
