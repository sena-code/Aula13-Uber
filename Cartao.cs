namespace Uber
{
    public class Cartao : Passageiro
    {
        public string Numero {get; set;}
        public string Titular {get; set;}
        public string Bandeira {get; set;}
        public string Cvv {get; set;}

        public string Cadastrar(){
            return "Cartão Cadastrado";
        }

        public string Excluir(){
            return "Cartão Excluido";
        }
    }
}