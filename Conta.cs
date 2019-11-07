using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãodeContas
{
    class Conta
    {
        private double levantar;
        private string cheques;
        private double depositar;
        private double saldoinicial = 100.00;
        private string subscridor;

        public Conta(string nome, double saldoinicial)

        {

            this.subscridor = nome;
            this.saldoinicial = saldoinicial;


        }
        public double LevantarSaldo(double montante)
        {
            double montante;
            this.saldoinicial = this.saldoinicial - montante;
            return this.saldoinicial;
        }

        public double DepositarSaldo(double montante)
        {
            this.saldoinicial = montante + this.saldoinicial;
            return this.saldoinicial;
        } 

       
        public string MostrarSaldo()
        {
            string saldo = this.saldoinicial.ToString();
            return saldo;
        }
    }
}
