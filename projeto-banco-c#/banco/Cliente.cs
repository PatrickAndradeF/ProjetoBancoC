using System;
using System.Collections.Generic;

namespace Banco{
    public class Cliente{
        private String nome;
        private String sobrenome;

        public String Nome{

            get{
                return nome;
            }

            private set{
                nome = value;
            }
        }

        public String Sobrenome{

            get{
                return sobrenome;
            }

            private set{
                sobrenome = value;
            }
        }

        private List<Conta> Contas = new List<Conta>();

        public Cliente(String nome, String sobrenome){
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public Cliente(){     
        }
        

        public Conta GetConta(int i){
            return Contas[i];
        }

        public int GetNumeroDeContas(){
            return Contas.Count;
        }

        public void AdicionarConta(Conta conta){
            Contas.Add(conta);
        }

    }
}
