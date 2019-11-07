using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãodeContas
{
    public partial class Form1 : Form
    {
        private string subscridor = "Por preencher";
        private double saldoinicial = 100.0;

        public Form1()
        {

            InitializeComponent();

        }

        private void BCriarCOrdem_Click(object sender, EventArgs e)
        {
            this.subscridor = " Rafael ";
            TbNome.AppendText(this.subscridor);
            double saldoinicial;
            saldoinicial = this.saldoinicial;
            TbSaldoInicial.AppendText(Convert.ToString(saldoinicial));

            RTBCaracteristicas.AppendText(" Nova conta criada : " + " \n " +
                " Subscridor : " + this.subscridor + " \n " +
                " Saldo inicial : " + this.saldoinicial);
        }

        private void BCriarContaPoupança_Click(object sender, EventArgs e)
        {
            this.subscridor = "Paulo";
            TbNome.AppendText(this.subscridor);
            double saldoinicial;
            saldoinicial = this.saldoinicial;
            TbSaldoInicial.AppendText(Convert.ToString(saldoinicial));

            RTBCaracteristicas.AppendText(" Nova conta criada : " + " \n " +
                " Subscridor : " + this.subscridor + " \n " +
                " Saldo inicial : " + this.saldoinicial);

        }

        private void BLevantarOrdem_Click(object sender, EventArgs e)
        {
            Conta levantar = new Conta(TbNome.Text,Convert.ToInt32(TbSaldoInicial.Text));
            double montantecontaordem = Convert.ToDouble(TbLevantarOrdem.Text);

            if(TbNome.Text == "null" || TbSaldoInicial.Text=="null")
            {
                TbNome.AppendText("Paulo");
                TbSaldoInicial.AppendText("100.00");
            }
            else
            {

                levantar.LevantarSaldo(montantecontaordem); 
            
            }

            RTBCaracteristicas.AppendText("Levantou " + montantecontaordem + " euros");
            RTBCaracteristicas.AppendText("Saldo disponivel = " + this.saldoinicial);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RTBCaracteristicas.Clear();
            Conta mostrarsaldo = new Conta(this.subscridor, this.saldoinicial);
            RTBCaracteristicas.AppendText(" \n " + " - - - Saldo disponivel : " + mostrarsaldo.MostrarSaldo());

        }

        private void BDepositarOrdem_Click(object sender, EventArgs e)
        {
        }
    }
}
