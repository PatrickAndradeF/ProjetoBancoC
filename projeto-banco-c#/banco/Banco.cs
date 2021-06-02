using System;
using System.Collections.Generic;
namespace Banco{
    public sealed class Banco{
        private static readonly Banco instance = new Banco();

        public static Banco Instance{

            get{
                return instance;
            }
        }

        private List<Cliente> Clientes = new List<Cliente>();

        private Banco(){
        }
    
        public void AdicionarCliente(String nome, String sobrenome){
            Clientes.Add(new Cliente(nome, sobrenome));
        }

        public int GetNumeroDeClientes(){
            return Clientes.Count;
        }

        public Cliente GetCliente(int indice){
            return Clientes[indice];
        }

    }
}
