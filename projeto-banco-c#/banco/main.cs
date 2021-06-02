using System;
namespace Banco{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Banco banco = Banco.Instance;
            Cliente cliente = new Cliente();
            Conta conta;

            String nome = cliente.Nome;

            //Cria dois clientes e suas contas
            banco.AdicionarCliente("Janne", "Simms");
            cliente = banco.GetCliente(0);
            cliente.AdicionarConta(new ContaPoupanca(500.00, 0.05));
            cliente.AdicionarConta(new ContaCorrente(200.00, 500.00));

            banco.AdicionarCliente("Owen", "Bryant");
            cliente = banco.GetCliente(1);
            cliente.AdicionarConta(new ContaCorrente(200.00));

            // Testa  a conta corrente de Jane Simms (com cheque especial)

            cliente = banco.GetCliente(0);
            conta = cliente.GetConta(1);
            Console.WriteLine("Cliente [" + cliente.Sobrenome +"," + cliente.Nome +"] " +
                              "Tem um saldo em conta corrente de R$ " + conta.Saldo +"." +
                              " Com Cheque Especial de R$ 500.00");

            try
            {
                Console.WriteLine("Conta Corrente [Jane Simms] : Saque de R$ 150,00");
                conta.Sacar(150.00);
                Console.WriteLine("Conta Corrente [Jane Simms] : Depósito de R$ 22,50");
                conta.Depositar(22.50);
                Console.WriteLine("Conta Corrente [Jane Simms] : Saque de R$ 147,62");
                conta.Sacar(147.62);
                Console.WriteLine("Conta Corrente [Jane Simms] : Saque de R$ 470,00");
                conta.Sacar(470.00); 
            }catch(ExcecaoChequeEspecial e1){
                Console.WriteLine("Exceção: " + e1.Message + "   Déficit: " + e1.Deficit); 
            }finally{
                Console.WriteLine("Cliente [" + cliente.Sobrenome
                                  + ", " + cliente.Nome + "]"
                                  + " Tem um saldo em conta corrente de "
                                  + conta.Saldo);
            }

            // Testa a conta corrente de Owen Bryant (sem cheque especial)
            cliente = banco.GetCliente(1);
            conta = cliente.GetConta(0);
            Console.WriteLine("Cliente [" + cliente.Sobrenome
                              + ", " + cliente.Nome + "]"
                              + " tem um saldo de "
                              + conta.Saldo);
            try 
            {
                 Console.WriteLine("Conta Corrente [Owen Bryant] : Saque de R$ 100,00");
                 conta.Sacar(100.00);
                 Console.WriteLine("Conta Corrente [Owen Bryant] : Depósito de R$ 25,00");
                 conta.Depositar(25.00);
                 Console.WriteLine("Conta Corrente [Owen Bryant] : Saque de R$ 175,00");
                 conta.Sacar(175.00);
            } catch (ExcecaoChequeEspecial e1) {
                 Console.WriteLine("Exceção: " + e1.Message + "   Déficit: " + e1.Deficit);
            } finally {
                 Console.WriteLine("Cliente [" + cliente.Sobrenome
                                  + ", " + cliente.Nome + "]"
                                  + " Tem um saldo dem conta corrente de " 
                                  + conta.Saldo);
            } 

        }
    }
}

