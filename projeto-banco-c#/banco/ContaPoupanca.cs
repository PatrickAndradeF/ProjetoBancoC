using System;
namespace Banco{

    public class ContaPoupanca:Conta{

        private double taxaDeJuros;
        
        public ContaPoupanca(double saldo, double taxa) : base(saldo){
            this.taxaDeJuros = taxa;
        }
    }
}