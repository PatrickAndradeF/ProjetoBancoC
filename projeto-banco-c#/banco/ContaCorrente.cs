using System;
namespace Banco{

    public class ContaCorrente : Conta{
        private double chequeEspecial;

        public double ChequeEspecial{

            get{
                return chequeEspecial;
            }

            private set{
                chequeEspecial = value;
            }
        }

        public ContaCorrente(double saldo) : base(saldo){
        }

        public ContaCorrente(double saldo, double protecao) : base(saldo){
          chequeEspecial = protecao;   
        }

        public override void Sacar(double valor){
            if(base.Saldo >= valor && this.chequeEspecial > 0){
              base.Saldo -= valor;
            } else if(base.Saldo >= valor){
              base.Saldo -= valor;
            } else if((base.Saldo + this.chequeEspecial) >= valor){
              this.chequeEspecial = (base.Saldo + this.chequeEspecial) - valor;
              base.Saldo = 0;
            }else if(base.Saldo < valor && this.chequeEspecial == 0){
               throw new ExcecaoChequeEspecial("Não há cheque especial", valor-base.Saldo);
            } else{
              throw new ExcecaoChequeEspecial("Saldo insuficiente no cheque especial",valor -  (base.Saldo + this.chequeEspecial));
            }

        }
    }
}
