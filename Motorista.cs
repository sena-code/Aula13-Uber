namespace Uber
{
    public class Motorista : Usuario
    {
        public string Carro { get; set; }

        public string Placa { get; set; }

        public string AceitarPassageiro(string carro){

            return "Passageiro Aceito";
        }

        public string ReceberPagamento(string pagamento){
            if(pagamento == "Finalizar Corrida"){
                return "Pagamento Recebido";
            } return "Pedente";
        }
    }
}