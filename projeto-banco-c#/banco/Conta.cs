using System;
namespace Banco{
    public class Conta{
        private double saldo;

        public double Saldo{

            get{
                return saldo;
            }

            protected set{
                saldo = value;
            }
        }

        public Conta(double saldoInicial){
            saldo = saldoInicial;
        }

        public bool Depositar(double valor){
            saldo += valor;
            return true;
        }

        public virtual void Sacar(double valor){
            if (saldo <= valor)
                throw new ExcecaoChequeEspecial("Saldo insuficiente", saldo - valor);
            else
                saldo-=valor;
        }
    }
}
