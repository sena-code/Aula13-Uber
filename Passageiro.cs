namespace Uber
{
    public class Passageiro : Usuario
    {
      public string SolicitarMotorista(){
            return "Procurando motorista...";
        }

        /// <summary>
        /// Paga o motorista se a corrida foi finalizada
        /// </summary>
        /// <param name="statusCorrida">Status vindo da classe Corrida</param>
        /// <returns>Retorna se recebeu o pgto ou não</returns>
        public bool Pagar(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return true;
            }

            return false;
        }

        
    }
}