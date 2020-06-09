using System;

namespace Uber
{
    class Program : Passageiro
    {
        static void Main(string[] args)
        {
              Usuario user = new Usuario();

              Passageiro passageiro = new Passageiro();

              Motorista driver = new Motorista();

              Cartao card = new Cartao();

              
            passageiro.motorista = "Encontrado";

            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();


            user.Login(login, senha);

            if(user.TokenLogin != "" && user.TokenLogin != null){

                Console.WriteLine("Acesso liberado! Usuário logado");

                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("Nos informe o numero do seu cartão:");

                string numero = Console.ReadLine();

                Console.WriteLine("Coloque o Titular:");

                string Titular = Console.ReadLine();

                Console.WriteLine("Bandeira :");

                string Bandeira = Console.ReadLine();

                Console.WriteLine("CVV : ");

                string CVV = Console.ReadLine();

                System.Console.WriteLine(card.Cadastrar());

                Console.WriteLine("-------------------------------------------");

                System.Console.WriteLine("Nos informe o seu local: ");

                string LocalInicio = Console.ReadLine();

                System.Console.WriteLine("Nos informe o seu destino: ");

                string LocalChegada = Console.ReadLine();
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("Calculando Rota...");

                Console.WriteLine("-------------------------------------------");

                Console.WriteLine(passageiro.ProcurarMotorista());

                Console.WriteLine("-------------------------------------------");


                Console.WriteLine(passageiro.Motobrabo());

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-------------------------------------------");
               
                
                Console.WriteLine("Informe nos o status da Corrida para o pagamento automático: \n -Finalizado \n -Pendente");

                passageiro.statusCorrida = Console.ReadLine();

                if(passageiro.statusCorrida == "Finalizado"){
                System.Console.WriteLine("Pagamento efetuado");
                }

                else{ System.Console.WriteLine("Pagamento pendente pois a corrida não foi finalizada");
                
                
        }




                


            }else{
                Console.WriteLine("Usuario deslogado");
                
                
            }





        }
    }
}
