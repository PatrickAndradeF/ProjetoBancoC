using System;

namespace Banco{

    public class ExcecaoChequeEspecial:Exception{

        public double Deficit{
            get;
            private set;
        }

        public ExcecaoChequeEspecial(String mensagem, double deficit) : base(mensagem){
            this.Deficit = deficit;
        }
    }
}
