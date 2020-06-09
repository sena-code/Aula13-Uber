namespace Uber
{
    public class Conta : Motorista
    {
        public string Agencia { get; set;}

        public string ContaMoto{ get; set;}

        public string Cadastrar(){

            return "Cadastrado";
        }

        public string Excluir(){
            return "Excluido";
        }


    }
}